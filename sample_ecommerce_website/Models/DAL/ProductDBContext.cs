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
                new Image { ProductID = "asdfasdgafgdg", ImageID = "asdasdwe", ImageURL = "https://cdn.pixabay.com/photo/2020/03/22/04/09/baseball-bat-4955795_960_720.png" },
                new Image { ProductID = "basdafgagasd", ImageID = "jkpafas", ImageURL = "https://cdn.pixabay.com/photo/2012/04/14/16/20/t-shirt-34481_960_720.png" },
                new Image { ProductID = "asdwrwdrwerew", ImageID = "ahnfkdh", ImageURL = "https://cdn.pixabay.com/photo/2013/07/13/09/45/tennis-racket-155963_960_720.png" },
                new Image { ProductID = "asdwrwdrwerew", ImageID = "iurheiu", ImageURL = "https://cdn.pixabay.com/photo/2014/04/03/10/01/tennis-309621_960_720.png" },
                new Image { ProductID = "asdwrwdrwerew", ImageID = "sdyiueki", ImageURL = "https://cdn.pixabay.com/photo/2014/04/03/11/37/tennis-312002_960_720.png" },
                new Image { ProductID = "sdfsdsgsssaa", ImageID = "zljshxdl", ImageURL = "https://cdn.pixabay.com/photo/2013/07/13/14/07/apparel-162180_960_720.png" },
                new Image { ProductID = "opiljuppoiop", ImageID = "dfkjndsf", ImageURL = "https://cdn.pixabay.com/photo/2013/07/13/10/51/football-157930_960_720.png" },
                new Image { ProductID = "nnlhjhjhiy", ImageID = "gflsdhe", ImageURL = "https://cdn.pixabay.com/photo/2013/07/13/14/08/apparel-162192_960_720.png" },
                new Image { ProductID = "jhahasja", ImageID = "asjkfnd", ImageURL = "https://cdn.pixabay.com/photo/2014/04/03/11/37/tennis-shoes-312023_960_720.png" },
                new Image { ProductID = "asdjioasdos", ImageID = "eqnasfdw", ImageURL = "https://cdn.pixabay.com/photo/2013/07/12/17/41/computer-mouse-152249_960_720.png" }
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
