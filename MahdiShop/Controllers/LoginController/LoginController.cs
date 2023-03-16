using Microsoft.AspNetCore.Mvc;

namespace MahdiShop.Controllers.LoginController
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
