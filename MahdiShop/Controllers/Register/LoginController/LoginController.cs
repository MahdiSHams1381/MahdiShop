using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace MahdiShop.Controllers.Register.LoginController
{
    public class LoginController : Controller
    {
        private Context _context;
        public LoginController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.error = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.Password == user.PasswordRip)
                {
                    _context.User.Add(new User() { UserName = user.UserName, Password = user.Password, UserPhone = user.UserPhone, UserEmail = user.UserEmail, PasswordRip = user.PasswordRip });
                    _context.SaveChanges();
                    return Redirect("/");
                }
                ViewBag.error = "error : your password Rip is not valid";
                return View();
            }
            ViewBag.error = "error : your data is not valid";
            return View();
        }
    }
}
