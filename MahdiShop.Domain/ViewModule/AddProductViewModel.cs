using MahdiShop.DataLayer.Models.Product;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahdiShop.Views.ViewModule
{
    public class AddProductViewModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public IFormFile Profile { get; set; }
        public string category { get; set; }
        public List<Category> categorySet { get; set; }

    }
}
