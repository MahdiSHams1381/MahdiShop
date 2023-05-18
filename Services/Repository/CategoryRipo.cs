using Infrastracture.Interface;
using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahdiShop.Data.Ripocitory
{
    public class CategoryRipo : ICategoryRipo
    {
        private Context _context;
        public CategoryRipo(Context context) { _context = context; }
        public bool AddCategory(Category category)
        {
            try {
                _context.Category.Add(category);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCategory(int id)
        {
            try
            {
                _context.Category.Add(SearchCategoryById(id));
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public Category SearchCategoryById(int id)
        {
            return _context.Category.Find(id);
        }

        public bool UpdeteCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
