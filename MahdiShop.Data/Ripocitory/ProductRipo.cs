using MahdiShop.Data.Models.Interface;
using MahdiShop.DataLayer.Models.User;
using MahdiShop.DataLayer.Polymorphis;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace MahdiShop.Data.Ripocitory
{
    internal class ProductRipo : IProductRipo
    {
        private Context _context;
        ProductRipo(Context context) { _context = context; }
        
        public bool AddProductToDb(IProduct IProduct)
        {
            //   _context.Product.Add(user);
            // _context.saveChenge();
            throw new NotImplementedException();
        }

        public List<User> FilterTheProduct(string FilterItem)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProductFromDb(int id)
        {          //   _context.Product.Remove(id);
            // _context.saveChenge();
            throw new NotImplementedException();
        }

        public User searchProductByUserId(int id)
        {
            //  _context[_context.indexOf(id)];;
            throw new NotImplementedException();
        }


        public bool UpDateProductinDb(IProduct Product)
        {
            //  _context[_context.indexOf(id)] = Product;
            throw new NotImplementedException();
        }
    }
}
