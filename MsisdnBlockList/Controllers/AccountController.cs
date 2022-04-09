using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MsisdnBlockList.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MsisdnBlockList.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<MSISDNController> _logger;

        public AccountController(ILogger<MSISDNController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpGet("login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Validate(string username, string password,string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                if (username == "Mark" && password == "ok")
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim("username", username));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, username));

                    claims.Add(new Claim(ClaimTypes.Name, "Marko Santek"));
                    claims.Add(new Claim(ClaimTypes.Role, "Admin"));

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrinciple = new ClaimsPrincipal(claimsIdentity);

                    await HttpContext.SignInAsync(claimsPrinciple);
                    return RedirectToAction("Index", "Msisdn", returnUrl);
                    //return Redirect(returnUrl);
                }
                ModelState.AddModelError(string.Empty, "Nevažeći pokušaj prijave.");
            }
            TempData["Error"] = "Korisničko ime ili lozinka su nevažeći.";
            return View("login");
        }


        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            
            // odjava, ali prilikom ponovnog logina, google account ce bit zapamcen
            //return Redirect("/");

            //odjava, ali se ulogirati u google account
            return Redirect(@"https://www.google.com/accounts/Logout?continue=https://appengine.google.com/_ah/logout?continue=https://localhost:5001");
        }

        [HttpGet("denied")]
        public IActionResult Denied()
        {
            return View();
        }

    }
}
