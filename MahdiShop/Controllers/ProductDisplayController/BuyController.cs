using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MahdiShop.Controllers.ProductDisplayController
{
    public class BuyController : Controller
    {
        public IActionResult Index(int id)
        {
            var c = new CookieOptions();
            c.Expires = DateTime.Now.AddSeconds(100);
            Response.Cookies.Append("product"+id, Convert.ToString(id), c);
            return Redirect("../../ProductDisplay");
        }
    }
}
