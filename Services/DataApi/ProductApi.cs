using MahdiShop.DataLayer.Data;
using MahdiShop.DataLayer.Models.Product;
using MahdiShop.DataLayer.Polymorphis;

namespace MahdiShop.DataLayer.DataApi
{
    public class ProductApi : IProduct
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
