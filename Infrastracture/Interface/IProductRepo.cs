using MahdiShop.DataLayer.Models.Product;
using MahdiShop.DataLayer.Models.User;
using MahdiShop.DataLayer.Polymorphis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
