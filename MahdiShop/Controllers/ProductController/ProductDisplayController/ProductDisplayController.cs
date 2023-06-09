﻿using MahdiShop.Data.Ripocitory;
using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models.Product;
using MahdiShop.Views.ViewModule;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MahdiShop.Controllers.ProductController.ProductDisplayController
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
            k.category = _context.Category.Select(n => n).ToList();

            return View(k);
        }
        public IActionResult Filter(ProductFilterViewModel model)
        {
            List<Product> p = _context.Product.Where(c => c.Name == model.ProductName || c.Price < model.PriceTo && c.Price > model.PriceFrom).ToList();
            ProductFilterViewModel k = new ProductFilterViewModel();
            k.productss = p;
            return View("index", k);
        }

        public IActionResult ShowProduuct(int id)
        {
            Product p = new ProductRepo(_context).GetById(id);
            p.SeeNumber++;
            _context.Product.Update(p);
            _context.SaveChanges();
            return View(p);
        }
    }
}
