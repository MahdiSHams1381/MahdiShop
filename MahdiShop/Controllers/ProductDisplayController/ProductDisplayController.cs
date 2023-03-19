using MahdiShop.Data;
using MahdiShop.Models.Product;
using MahdiShop.Views.ViewModule;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MahdiShop.Controllers.ProductLauncher
{
    public class ProductDisplayController : Controller
    {
        private Context _context;
        public ProductDisplayController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> p = _context.Product.Select(c => c).ToList();
            ProductFilterViewModel k = new ProductFilterViewModel();
            k.productss = p;
            return View(k);
        }
    }
}
