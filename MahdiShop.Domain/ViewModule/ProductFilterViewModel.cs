using MahdiShop.DataLayer.Models.Product;
using System.Collections.Generic;

namespace MahdiShop.Views.ViewModule
{
    public class ProductFilterViewModel
    {
        public string ProductName { get; set; }
        public decimal PriceFrom { get; set; }
        public decimal PriceTo { get; set; }
        public string CategoryName { get; set; }
        public List<Category> category { get; set; }
        public List<Product> productss { get; set; }
    }
}
