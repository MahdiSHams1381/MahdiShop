using MahdiShop.Data.Models.Interface;
using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models.Product;
using MahdiShop.DataLayer.Models.User;
using MahdiShop.DataLayer.Polymorphis;
using System;
using System.Collections.Generic;

namespace MahdiShop.Data.Ripocitory
{
    public class ProductRepo : IProductRepo
    {
        private Context _context;
        public ProductRepo(Context context) { _context = context; }

        public bool AddProductToDb(IProduct Product)
        {
            throw new NotImplementedException();
        }

        public List<Product> FilterTheProduct(string FilterItem)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProductFromDb(int id)
        {
            throw new NotImplementedException();
        }

        public User searchProductByUserId(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpDateProductinDb(IProduct Product)
        {
            throw new NotImplementedException();
        }
    }
}
