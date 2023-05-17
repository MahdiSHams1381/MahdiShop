using MahdiShop.DataLayer.Models.Product;
using MahdiShop.DataLayer.Models.User;
using System;
using System.Collections.Generic;

namespace MahdiShop.Data.Models.Interface
{
    public interface IProductRepo
    {
        bool AddProductToDb(IProduct Product);
        bool RemoveProductFromDb(int id);
        bool UpDateProductinDb(IProduct Product);
        User searchProductByUserId(int id);
        List<Product> FilterTheProduct(String FilterItem);
        Product GetById(int id);
    }
}
