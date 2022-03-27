using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MsisdnBlockList.Data;
using MsisdnBlockList.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MsisdnBlockList.Controllers
{
    public class MSISDNController : Controller
    {
        private readonly MySqlContext _context;

        private readonly ILogger<MSISDNController> _logger;

        public MSISDNController(MySqlContext context, ILogger<MSISDNController> logger)
        {
            _context = context;
            _logger = logger;
        }
        
        public IActionResult Index(string msisdn)
        {
            try
            {
                int userId = GetUserID();
                var rez = _context.msisdn.Where(m => m.deleted == null && m.msisdn.StartsWith(msisdn) && m.user_id == userId).ToList();
                if (!ModelState.IsValid)
                {
                    return View("Search");
                }
                return View("Index", rez);
            }
            catch(Exception ex)
            {
                return LogErrorAndRedirect(ex);
            }
        }

        string GetUserName()
        {
            if (HttpContext.Request.Headers.Keys.Contains("Authorization"))
            {
                string header = HttpContext.Request.Headers["Authorization"];
                if (header.Contains("Basic"))
                {
                    string userPass = System.Text.UTF8Encoding.UTF8.GetString(Convert.FromBase64String(header.Substring(6)));
                    string[] user = userPass.Split(':');
                    return user[0];
                }
                else
                {
                    return "UNKNOWN";
                }
            }
            return "UNKNOWN";
        }

        int GetUserID()
        {
            string userName = GetUserName();
            User nb = _context.user.Where(u => u.user_name == userName).FirstOrDefault();
            if (nb == null)
            {
                nb = new User
                {
                    user_name = userName
                };
                _context.Add(nb);
                _context.SaveChanges();
                return nb.user_id;
            }
            return nb.user_id;
        }

        public IActionResult Create()
        {
            try
            {
                return View();
            }
            catch(Exception ex)
            {
                return LogErrorAndRedirect(ex);
            }
        }

        IActionResult LogErrorAndRedirect(Exception ex)
        {
            _logger.LogError("Error message {0}", ex.Message);
            _logger.LogError("Source {0}", ex.Source);
            _logger.LogError("Stack {0}", ex.StackTrace);
            return RedirectToAction("Error", "Error", new { message = ex.Message });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("msisdn")] MSISDN m)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string phoneNumber = m.GetFormatedPhoneNumber();
                    MSISDN number = _context.msisdn.Where(b => b.msisdn == phoneNumber).FirstOrDefault();
                    _logger.LogInformation("Number found?", number == null);
                    if (number == null)
                    {
                        number = new MSISDN
                        {
                            created = DateTime.Now,
                            status = (int)Status.Blocked,
                            msisdn = m.GetFormatedPhoneNumber(),
                            user_id = GetUserID()
                        };
                        
                        _context.Add(number);
                        
                        await _context.SaveChangesAsync();
                        ViewBag.Message = "MSISDN je kreiran.";
                        _logger.LogInformation("Got id", number.msisdn_id);
                        return View("Index", new MSISDN[] { number });
                    }
                    else
                    {                       
                        _logger.LogInformation("Number found... redirecting.");
                        ViewBag.Message = "Telefonski broj je pronađen.";
                        return RedirectToAction("Search", new { msisdn = number.msisdn, br_exists=true });                                               
                    }
                }
                catch (Exception ex)
                {
                    return LogErrorAndRedirect(ex);
                }                
            }
            return View(m);
        }

        public IActionResult Block(int id, string search)
        {
            try
            {
                MSISDN number = _context.msisdn.Where(b => b.msisdn_id == id).FirstOrDefault();
                if (number != null)
                {
                    number.status = (int)Status.Blocked;
                    number.modified = DateTime.Now;
                    number.user_id = GetUserID();
                    _context.SaveChanges();
                }

                return RedirectToAction("Search", new { msisdn = search });
            }
            catch (Exception ex)
            {
                return LogErrorAndRedirect(ex);
            }
        }

        public IActionResult Unblock(int id, string search)
        {
            try
            {
                MSISDN number = _context.msisdn.Where(b => b.msisdn_id == id).FirstOrDefault();
                if (number != null)
                {
                    number.status = (int)Status.NotBlocked;
                    number.modified = DateTime.Now;
                    number.user_id = GetUserID();
                    _context.SaveChanges();
                }
                return RedirectToAction("Search", new { msisdn = search });
            }
            catch(Exception ex)
            {
                return LogErrorAndRedirect(ex);
            }
        }

        public IActionResult Search(string msisdn, MSISDN m, string phone_nbr, bool br_exists)
        {
            try
            {
                var result = _context.msisdn.Include(u => u.user).Where(m => m.deleted == null && m.msisdn.StartsWith(msisdn)).ToList();
                MSISDN number = _context.msisdn.Where(b => b.msisdn == m.msisdn && b.msisdn_id == m.msisdn_id).FirstOrDefault();
                             
                if (ModelState.IsValid)
                {
                    if (number == null)
                    {
                        ViewBag.msisdn = phone_nbr;
                    }
                    if (br_exists)
                    {
                        ViewBag.Message = "Traženi broj je pronađen.";
                    }
                    if (result.Count == 0)
                    {
                        ViewBag.Message = "Traženi broj <strong>nije</strong> pronađen.";
                    }
                    ViewBag.msisdn = msisdn;
                    return View("Index", result);
                }
                else
                {
                    if(result.Count == 0)
                    {
                        ViewBag.Message = "Broj mobilnog telefona <strong>nije</strong> podržan.";
                    }
                    return View("Index", result);
                }                
            }
            catch(Exception ex)
            {
                return LogErrorAndRedirect(ex);
            }
        }

        public IActionResult History(int id)
        {
            try
            {
                var nbr = _context.msisdn.Where(m => m.msisdn_id == id).FirstOrDefault();
                List<Log> log = _context.log.Include(u => u.user).Where(m => m.msisdn_id == id).ToList();
                if (nbr != null)
                {
                    ViewBag.msisdn = nbr.msisdn;
                }
                return View(log);
            }
            catch(Exception ex)
            {
                return LogErrorAndRedirect(ex);
            }
        }
    }
}