using MahdiShop.DataLayer.Models.Product;
using MahdiShop.DataLayer.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahdiShop.Data.Models.Interface
{
    public interface IProductRepo
    {
        bool AddProductToDb(Product Product);
        bool RemoveProductFromDb(int id);
        bool UpDateProductinDb(Product Product);
        User searchProductByUserId(int id);
        List<Product> FilterTheProduct(String FilterItem);
        Product GetById(int id);
    }
}
