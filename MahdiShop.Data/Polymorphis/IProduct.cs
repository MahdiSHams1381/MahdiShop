using MahdiShop.DataLayer.Models.Product;

namespace MahdiShop.DataLayer.Polymorphis
{
    public interface IProduct
    {
        Product FindTheProductById(int id);
    }
}
