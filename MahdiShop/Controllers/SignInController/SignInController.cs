using MahdiShop.Views.ViewModule;
using Microsoft.AspNetCore.Mvc;

namespace MahdiShop.Controllers.SignInController
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SignInViewModule module)
        {
            return View();
        }
    }
}
