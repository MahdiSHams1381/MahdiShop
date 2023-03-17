using MahdiShop.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace MahdiShop.Controllers.LoginController
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index( User user)
        {
            return View();
        }
    }
}
