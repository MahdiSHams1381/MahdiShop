using MahdiShop.Data.Models.Interface;
using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models.Product;
using MahdiShop.DataLayer.Models.User;
using System;
using System.Collections.Generic;

namespace MahdiShop.Data.Ripocitory
{
    public class ProductRepo : IProductRepo
    {
        private Context _context;
        public ProductRepo(Context context) { _context = context; }

        public bool AddProductToDb(Product Product)
        {
            try{
                _context.Product.Add(Product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<Product> FilterTheProduct(string FilterItem)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
           return  _context.Product.Find(id);
        }

        public bool RemoveProductFromDb(int id)
        {
            try
            {
                _context.Product.Remove(GetById(id));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpDateProductinDb(Product Product)
        {
            throw new NotImplementedException();
        }
    }
}
