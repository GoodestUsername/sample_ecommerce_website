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
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            base.OnModelCreating(myModelBuilder);

            myModelBuilder.Entity<Image>(entity => { entity.HasOne(d => d.Product).WithMany(p => p.Images).HasForeignKey("ProductID"); });

            myModelBuilder.Entity<Image>().HasData(
                new Image { ProductID = "asdfasdgafgdg", ImageID = "asdasdwe", ImageURL = "https://www.shutterstock.com/image-photo/wooden-baseball-bat-isolated-on-white-378948592" },
                new Image { ProductID = "basdafgagasd", ImageID = "jkpafas", ImageURL = "https://www.shutterstock.com/image-vector/black-realistic-tshirt-front-view-isolated-1925573966" },
                new Image { ProductID = "asdwrwdrwerew", ImageID = "ahnfkdh", ImageURL = "https://www.shutterstock.com/image-photo/new-tennis-racket-isolated-on-white-471436889" },
                new Image { ProductID = "asdwrwdrwerew", ImageID = "iurheiu", ImageURL = "https://www.shutterstock.com/image-photo/tennis-racket-on-white-background-760686820" },
                new Image { ProductID = "asdwrwdrwerew", ImageID = "sdyiueki", ImageURL = "https://www.shutterstock.com/image-vector/tennis-racket-silhouette-1075969826" },
                new Image { ProductID = "sdfsdsgsssaa", ImageID = "zljshxdl", ImageURL = "https://www.shutterstock.com/image-photo/blue-blank-t-shirt-template-isolated-690352057" },
                new Image { ProductID = "opiljuppoiop", ImageID = "dfkjndsf", ImageURL = "https://www.shutterstock.com/image-photo/soccer-ball-isolated-on-white-129557066" },
                new Image { ProductID = "nnlhjhjhiy", ImageID = "gflsdhe", ImageURL = "https://www.shutterstock.com/image-photo/red-tshirt-clothes-on-isolated-white-618080519" },
                new Image { ProductID = "jhahasja", ImageID = "asjkfnd", ImageURL = "https://www.shutterstock.com/image-photo/vintage-red-shoes-on-white-background-92008067" },
                new Image { ProductID = "asdjioasdos", ImageID = "eqnasfdw", ImageURL = "https://www.shutterstock.com/image-photo/professional-wireless-game-mouse-on-dark-750226153" }
                );

            myModelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = "asdfasdgafgdg",
                    Name = "BaseBall Bat",
                    Price = 15.12,
                    Category = "Sports Equipment",
                    Description = "Baseball Bat",
                    Stock = 4,
                    DiscountID = null
                },
                new Product
                {
                    ProductID = "basdafgagasd",
                    Name = "Trendy T shirt",
                    Price = 1123.11,
                    Category = "t-shirts",
                    Description = "Trendy T shirt",
                    Stock = 10,
                    DiscountID = "IASDAFFASD"
                },
                new Product
                {
                    ProductID = "asdwrwdrwerew",
                    Name = "Tennis Racket",
                    Price = 15.12,
                    Category = "Sports Equipment",
                    Description = "Tennis Racket",
                    Stock = 3,
                    DiscountID = null
                },
                new Product
                {
                    ProductID = "sdfsdsgsssaa",
                    Name = "Blue T shirt",
                    Price = 13.11,
                    Category = "t-shirts",
                    Description = "Blue T shirt",
                    Stock = 0,
                    DiscountID = "wqeqwrewtewtw"
                },
                new Product
                {
                    ProductID = "opiljuppoiop",
                    Name = "Soccer Ball",
                    Price = 15.12,
                    Category = "Sports Equipment",
                    Description = "Soccer Ball",
                    Stock = 7,
                    DiscountID = null
                },
                new Product
                {
                    ProductID = "nnlhjhjhiy",
                    Name = "Red T shirt",
                    Price = 12.11,
                    Category = "t-shirts",
                    Description = "Red T shirt",
                    Stock = 9,
                    DiscountID = "nasdsajj"
                },
                new Product
                {
                    ProductID = "jhahasja",
                    Name = "Red Shoe",
                    Price = 15.12,
                    Category = "Shoes",
                    Description = "A red shoe",
                    Stock = 2,
                    DiscountID = null
                },
                new Product
                {
                    ProductID = "asdjioasdos",
                    Name = "Gaming Mouse",
                    Price = 89.99,
                    Category = "computer equipment",
                    Description = "Gaming Mouse",
                    Stock = 100,
                    DiscountID = null
                }
            );
        }
    }
}
