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
                new Category() { Name = "food", Description = "All of the thing that can eat", CategoryId = 1 },
                new Category() { Name = "HomeTools", Description = "All of the thing that Use in home", CategoryId = 2 },
                new Category() { Name = "Eletrition tools", Description = "All of the thing that work with electronic", CategoryId = 3 }
                );
            #endregion

            #region seed data Product to test
            modelBuilder.Entity<Product>().HasData(
             new Product() { Description="the best" , Name="tv" , Price=14000000 , Profile="/css/55f21061-6ed3-4890-9eea-0b666a711af9.jpg"} , 
             new Product() { Description="the best food in iran" , Name="sandwich" , Price=15000 , Profile="/css/d77a4624-8f71-47eb-b94b-bb517e2f3db7.jpg"} , 
             new Product() { Description="blue and black" , Name="mobl" , Price=5000000 , Profile="/css/7fd072b6-3bd1-453c-90e2-07e29fe3b12a.jpg"} ,
             new Product() { Description="best wood" , Name="chair" , Price=3200000 , Profile="/css/6d78ebf4-ee68-46e4-b68e-8be4c978044a.jpg"} , 
             new Product() { Description="green and red" , Name="saled" , Price=60000 , Profile="/css/9ffe609d-10c2-4232-9cca-8a0afbe42601.jpg"} ,
             new Product() { Description="asdajlasxa" , Name="shar" , Price=1456 , Profile="/css/55f21061-6ed3-4890-9eea-0b666a711af9.jpg"} , 
             new Product() { Description="Monaseb Baray hameh senin" , Name="SabziJat" , Price=14000 , Profile="/css/49493ef7-b16c-427f-8ea8-aee2a67ff461.jpg"} , 
             new Product() { Description="Baray jahizieh" , Name="Home app" , Price=280000000 , Profile="/css/9ffe609d-10c2-4232-9cca-8a0afbe42601.jpg"} , 
             new Product() { Description="besyarKhoob" , Name="YakhChal" , Price=30000000 , Profile="/css/d77a4624-8f71-47eb-b94b-bb517e2f3db7.jpg"} , 
             new Product() { Description="dar ranghay motafavet" , Name="Goshi" , Price=5000000 , Profile="/css/e0ce94cb-4ee1-46a4-8001-e1acc8aa315b.jpg"} , 
             new Product() { Description="hameh chiz ra khord ly konad" , Name="hamzan" , Price=4800000 , Profile="/css/7fd072b6-3bd1-453c-90e2-07e29fe3b12a.jpg"} , 
             new Product() { Description="besyar dag my koonad" , Name="snaksaz" , Price=2500000 , Profile="/css/8db76f47-db5c-4828-85ac-9ab24ab1ab3c.jpg"} ,
             new Product() { Description="khoshPokht" , Name="Nan" , Price=3700 , Profile="/css/6d78ebf4-ee68-46e4-b68e-8be4c978044a.jpg"} , 
             new Product() { Description="a book that  you can read" , Name="book" , Price=145900 , Profile="/css/8012f3fb-645c-4ca4-acdf-a612e3ff7d8b.jpg"} , 
             new Product() { Description="have blue and yellow" , Name="bag" , Price=25000000 , Profile="/css/40e2420a-7d60-437d-83b9-4fdf7a07455d.jpg"}
                );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
