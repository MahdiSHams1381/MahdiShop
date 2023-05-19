using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models;
using MahdiShop.DataLayer.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MahdiShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Context _context;
        public HomeController(ILogger<HomeController> logger , Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> product = _context.Product.Select(n => n).OrderByDescending(n => n.SeeNumber).ToList();
            //String q = "";
            //foreach(Product w in product)
            //{
            //    q += " , new Product() {"+$"category={w.category}  , Description="{w.Description}" , Name="{w.Name}" , Price={w.Price} , Profile="{w.Profile}""+"}";

            //}
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
