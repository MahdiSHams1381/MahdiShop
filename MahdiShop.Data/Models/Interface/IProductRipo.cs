using MahdiShop.DataLayer.Models.User;
using MahdiShop.DataLayer.Polymorphis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahdiShop.Data.Models.Interface
{
    internal interface IProductRipo
    {
        bool AddProductToDb(IProduct Product);
        bool RemoveProductFromDb(int id);
        bool UpDateProductinDb(IProduct Product);
        User searchProductByUserId(int id);
        List<User> FilterTheProduct(String FilterItem);
    }
}
