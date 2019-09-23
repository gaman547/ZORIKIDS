using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ZORI_KIDS_KG.Model;
using ZORI_KIDS_KG.Models;

namespace ZORI_KIDS_KG.Controllers
{
    public class SecurityController : Controller
    {
        private zori_kids_dbContext _db;

        public SecurityController(zori_kids_dbContext context)
        {
            _db = context;            
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            try
            {              
                var _admin = _db.Admins.Where(s => s.Email == model.User).FirstOrDefault();
                var _user =  _db.Parinte.Where(u => u.Email == model.User).FirstOrDefault();

                if (_admin != null)
                {
                    if(_admin.Password == model.Password)
                    {
                        await LoginUser(model.User, true);

                        return RedirectToAction("Index", "Dashboard");
                    }
                    else
                    {
                        return RedirectToAction("Login", "Security");  
                    }
                }
                else if (_user != null)
                {
                    if(_user.Password == model.Password)
                    {
                        await LoginUser(model.User, false);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Login", "Security");
                    }
                }
                else
                {
                    return RedirectToAction("Login", "Security");
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message + " " + "Contacteaza admin!" });  
            }
        }

        public async Task<IActionResult> Logout()
        {
             await HttpContext.SignOutAsync(
             CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Parinte model)
        {           

            Parinte asd = new Parinte();
            asd = model;
            asd.RolesId = 7;
            _db.Parinte.Add(asd);
            _db.SaveChanges();

            return RedirectToAction("Login", "Security");
        }
       
        private async Task LoginUser(string username, bool administrator)
        {
            var claims = new List<Claim>
            {
               new Claim(ClaimTypes.Name, username),
               new Claim(ClaimTypes.Role, administrator ? "Administrator" : "Utilizator"),
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                //
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }
    }
}