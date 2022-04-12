using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MsisdnBlockList.Data;
using MsisdnBlockList.Models;
using MsisdnBlockList.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MsisdnBlockList.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly UserService _userService;
        private readonly MySqlContext _context;

        public AccountController(ILogger<AccountController> logger, UserService userService, MySqlContext _context)
        {
            _userService = userService;
            _logger = logger;
            this._context = _context;
        }

        IActionResult LogErrorAndRedirect(Exception ex)
        {
            _logger.LogError("Error message {0}", ex.Message);
            _logger.LogError("Source {0}", ex.Source);
            _logger.LogError("Stack {0}", ex.StackTrace);
            return RedirectToAction("Error", "Error", new { message = ex.Message });
        }

        [AllowAnonymous]
        [HttpGet("login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpGet("login/{provider}")]
        public IActionResult LoginGoogle([FromRoute]string provider, [FromQuery]string returnUrl)
        {
            try 
            {
                if (User != null && User.Identities.Any(i => i.IsAuthenticated))
                {
                    RedirectToAction("", "Msisdn");
                }
                returnUrl = string.IsNullOrEmpty(returnUrl) ? "/" : returnUrl;
                var authProp = new AuthenticationProperties { RedirectUri = returnUrl };

                _logger.LogInformation("User logged in...");
                //await HttpContext.ChallengeAsync(provider, authProp).ConfigureAwait(false);
                return new ChallengeResult(provider, authProp);
            }
            catch(Exception ex)
            {
                return LogErrorAndRedirect(ex);
            }
        }

        [ValidateAntiForgeryToken()]
        [Route("validate")]
        [HttpPost]
        public async Task<IActionResult> Validate(string username, string password, string returnUrl)
        {
            try 
            {
                returnUrl = string.IsNullOrEmpty(returnUrl) ? "/" : returnUrl;
                ViewData["ReturnUrl"] = returnUrl;
                _logger.LogInformation("User found?", returnUrl == null);

                if (_userService.TryValidateUser(username, password, out List<Claim> claims))
                {
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    var items = new Dictionary<string, string>();
                    items.Add(".AuthScheme", CookieAuthenticationDefaults.AuthenticationScheme);
                    var properties = new AuthenticationProperties(items);

                    await HttpContext.SignInAsync(claimsPrincipal, properties);
                    _logger.LogInformation("User logged in... ", username);
                    return RedirectToAction("Index", "Msisdn", returnUrl);
                }

                else
                {
                    _logger.LogWarning("User or password are incorrect");
                    TempData["Error"] = "Korisničko ime ili lozinka su nevažeći.";
                    return View("login");
                }

            }
            catch(Exception ex)
            {
                return LogErrorAndRedirect(ex);
            }

        }


        [Authorize]
        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            var scheme = User.Claims.FirstOrDefault(x => x.Type == ".AuthScheme").Value;
            string domainUrl = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host;
            switch (scheme)
            {
                case "google":
                    //odjava, ali se ulogirati u google account
                    await HttpContext.SignOutAsync();
                    var logout = $"https://www.google.com/accounts/Logout?continue=https://appengine.google.com/_ah/logout?continue={domainUrl}";
                    return Redirect(logout);
                case "Cookies":
                    // odjava, ali prilikom ponovnog logina, google account ce bit zapamcen
                    await HttpContext.SignOutAsync();
                    return Redirect("/");
                default:
                    return new SignOutResult(new[] { CookieAuthenticationDefaults.AuthenticationScheme, scheme });
            }
        }

        [HttpGet("denied")]
        public IActionResult Denied()
        {
            if(User.Identity.IsAuthenticated)
            {
                var role = User.Claims.FirstOrDefault(l => l.Type == ClaimTypes.Role)?.Value;
                if (role == "Admin")
                {
                    return Redirect("/");
                }
            }
            return View();
        }

        //[AllowAnonymous]
        //[HttpPost]
        //[Route("register")]
        public async Task<IActionResult> AddNewUser(string provider, List<Claim> claims)
        {
            var a = new AppUsers();
            //var nbr = 1;
            a.provider = provider;
            a.password = claims.GetClaim(ClaimTypes.Hash);
            a.nameIdentifier = claims.GetClaim(ClaimTypes.NameIdentifier);
            a.username = claims.GetClaim("username");
            a.firstname = claims.GetClaim(ClaimTypes.GivenName);
            a.lastname = claims.GetClaim(ClaimTypes.Surname);
            var name = claims.GetClaim("name");

            // Vrlo rudimentarno rukovanje podjelom punog imena korisnika na ime i prezime. Ne baš robusno.
            if (string.IsNullOrEmpty(a.firstname))
            {
                a.firstname = name?.Split(' ').First();
            }
            if (string.IsNullOrEmpty(a.lastname))
            {
                var nameSplit = name?.Split(' ');
                if (nameSplit.Length > 1)
                {
                    a.lastname = name?.Split(' ').Last();
                }
            }
            a.email = claims.GetClaim(ClaimTypes.Email);
            a.mobile = claims.GetClaim(ClaimTypes.MobilePhone);
            a.roles = claims.GetClaim(ClaimTypes.Role);
            //a.roles = claims.GetClaim("NewUser" + nbr++);
            var entity = _context.appUsers.Add(a);
            await _context.SaveChangesAsync();
            return View("login");
        }
    }
}

