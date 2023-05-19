using MahdiShop.Data.Ripocitory;
using MahdiShop.DataLayer.Data;
using MahdiShop.Views.ViewModule;
using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models.Product;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;

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
        public void GetAddProduct( AddProductViewModel product)
        {
            string profileName;
            if (product.Profile == null)
            {
                profileName = "/css/download (1).jpg";
            }
            else
            {
                string newAvatarURL = Guid.NewGuid().ToString() + Path.GetExtension(product.Profile.FileName);
                string newPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "css", newAvatarURL);
                using (var stream = new FileStream(newPath, FileMode.Create))
                {
                    product.Profile.CopyTo(stream);
                }
                profileName = "/css/" + newAvatarURL;
            }
            Product p =  new Product() { Name = product.Name,Price = product.Price, Description = product.Description, category = product.category, Profile = profileName, ProductId = product.ProductId };
            new ProductRepo(_context).AddProductToDb(p);
        }
        public IActionResult AddProduct()
        {
            return View();
        }
    }
}
