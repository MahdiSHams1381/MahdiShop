using MahdiShop.Data.Ripocitory;
using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace MahdiShop.Controllers.ProductController
{
    public class AddProductController : Controller
    {
        private Context _context;
        public AddProductController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public void GetAddProduct(Product product)
        {
            product.ProductId = 15;
            new ProductRepo(_context).AddProductToDb(product);
        }
        public IActionResult AddProduct()
        {
            return View();
        }
    }
}
