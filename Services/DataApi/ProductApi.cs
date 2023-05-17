using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models.Product;

namespace MahdiShop.DataLayer.DataApi
{
    public class ProductApi : Product
    {
        private Context _context;
        public ProductApi(Context context)
        {
            _context = context;
        }

        public  Product FindTheProductById(int id)
        {
            return _context.Product.Find(id);
        }
    }
}
