using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Product DB context
/// </summary>
namespace sample_ecommerce_website.Models.DAL
{
    /// <summary>
    /// DB context class
    /// </summary>
    public class ProductDBContext : IdentityDbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            base.OnModelCreating(myModelBuilder);

            myModelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = "asdfasdgafgdg",
                    Name = "BaseBall Bat",
                    Price = 15.12,
                    Category = "Sports Equipment",
                    Description = "Baseball Bat",
                    DiscountID = null
                },
                new Product
                {
                    ProductID = "basdafgagasd",
                    Name = "Trendy T shirt",
                    Price = 1123.11,
                    Category = "t-shirts",
                    Description = "Trendy T shirt",
                    DiscountID = "IASDAFFASD"
                },
                new Product
                {
                    ProductID = "asdwrwdrwerew",
                    Name = "Tennis Racket",
                    Price = 15.12,
                    Category = "Sports Equipment",
                    Description = "Tennis Racket",
                    DiscountID = null
                },
                new Product
                {
                    ProductID = "sdfsdsgsssaa",
                    Name = "Blue T shirt",
                    Price = 13.11,
                    Category = "t-shirts",
                    Description = "Blue T shirt",
                    DiscountID = "wqeqwrewtewtw"
                },
                new Product
                {
                    ProductID = "opiljuppoiop",
                    Name = "Soccer Ball",
                    Price = 15.12,
                    Category = "Sports Equipment",
                    Description = "Soccer Ball",
                    DiscountID = null
                },
                new Product
                {
                    ProductID = "nnlhjhjhiy",
                    Name = "Red T shirt",
                    Price = 12.11,
                    Category = "t-shirts",
                    Description = "Red T shirt",
                    DiscountID = "nasdsajj"
                },
                new Product
                {
                    ProductID = "jhahasja",
                    Name = "Red Shoe",
                    Price = 15.12,
                    Category = "Shoes",
                    Description = "A red shoe",
                    DiscountID = null
                },
                new Product
                {
                    ProductID = "asdjioasdos",
                    Name = "Gaming Mouse",
                    Price = 89.99,
                    Category = "computer equipment",
                    Description = "Gaming Mouse",
                    DiscountID = null
                }
            );
        }
    }
}
