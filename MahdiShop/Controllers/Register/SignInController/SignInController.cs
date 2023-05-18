using MahdiShop.DataLayer.Data;
using MahdiShop.Views.ViewModule;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MahdiShop.Controllers.Register.SignInController
{
    public class SignInController : Controller
    {
        private Context _context;
        public SignInController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SignInViewModule module)
        {
            if (_context.User.Where(u => u.UserName == module.UserName && u.UserEmail == module.UserEmail && u.Password == module.Password).ToList().Count() > 0)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Email, module.UserEmail) ,
                        new Claim(ClaimTypes.Name, module.UserName) ,
                        new Claim("password", module.Password)
                    };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var properties = new AuthenticationProperties
                {
                    IsPersistent = module.Remmberme
                };
                HttpContext.SignInAsync(principal, properties);
                //  var c = new CookieOptions();
                //  c.Expires = DateTime.Now.AddSeconds(100);
                //  Response.Cookies.Append("c", module.UserName, c);
                // Response.Cookies.Delete("c");
                return Redirect("/");

            }
            ViewBag.error2 = "cant finde the user with this information";
            return View();
        }
    }
}
