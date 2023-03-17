using MahdiShop.Models.Product;
using MahdiShop.Models.User;
using Microsoft.EntityFrameworkCore;

namespace MahdiShop.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
       public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
