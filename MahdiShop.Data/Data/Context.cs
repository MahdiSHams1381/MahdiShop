using MahdiShop.DataLayer.Models.Product;
using MahdiShop.DataLayer.Models.User;
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;
namespace MahdiShop.DataLayer.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region seed data User
            modelBuilder.Entity<User>().HasData(
                new User { UserName = "Admin", Password = "1234", UserEmail = "Admin@gmail.com", UserPhone = "090000000000", UserId = 1 }
                );
            #endregion
            #region seed data Category
            modelBuilder.Entity<Category>().HasData(
                new Category() { Name = "food", Discription = "All of the thing that can eat", CategoryId = 1 },
                new Category() { Name = "HomeTools", Discription = "All of the thing that Use in home", CategoryId = 2 },
                new Category() { Name = "Eletrition tools", Discription = "All of the thing that work with electronic", CategoryId = 3 }
                );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
