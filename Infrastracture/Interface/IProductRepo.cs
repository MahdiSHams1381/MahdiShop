using MahdiShop.DataLayer.Models.Product;
using MahdiShop.DataLayer.Models.User;
using System;
using System.Collections.Generic;

namespace MahdiShop.Data.Models.Interface
{
    public interface IProductRepo
    {
        bool AddProductToDb(Product Product);
        bool RemoveProductFromDb(int id);
        bool UpDateProductinDb(Product Product);
        List<Product> FilterTheProduct(String FilterItem);
        Product GetById(int id);
    }
}
