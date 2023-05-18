using Infrastracture.Interface;
using MahdiShop.DataLayer.Models.Product;
using Microsoft.AspNetCore.Mvc;
using MahdiShop.Data.Ripocitory;
using MahdiShop.DataLayer.Data;

namespace MahdiShop.Controllers.ProductController
{
    public class AddCategoryController : Controller
    {
        private Context _Context;
        public AddCategoryController(Context Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        public void GetAddcategory(Category category)
        {
            new CategoryRipo(_Context).AddCategory(category);
        }

    }
}
