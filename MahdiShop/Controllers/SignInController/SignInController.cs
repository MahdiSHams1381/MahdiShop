using Microsoft.AspNetCore.Mvc;

namespace MahdiShop.Controllers.SignInController
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
