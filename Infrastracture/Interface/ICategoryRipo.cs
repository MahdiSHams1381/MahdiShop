using MahdiShop.DataLayer.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Interface
{
    public interface ICategoryRipo
    {
        bool AddCategory(Category category);

        bool DeleteCategory(int id);

        bool UpdeteCategory(Category category);
        Category SearchCategoryById(int id);
    }
}
