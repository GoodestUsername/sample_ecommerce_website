using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
/// <summary>
/// Product DB context
/// </summary>
namespace sample_ecommerce_website.Models.DAL
{
    /// <summary>
    /// DB context class
    /// </summary>
    public class ProductDBModel : IdentityDbContext
    {
        public ProductDBModel(DbContextOptions<ProductDBModel> options) : base(options)
        { }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<ShoppingCart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<OrderDetails> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<UserAddress> UserAddresses { get; set; }
        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            base.OnModelCreating(myModelBuilder);

            myModelBuilder.Entity<UserAddress>(entity =>
            {
                entity.HasKey(d => d.AddressId)
                      .HasName("AddressId");
            });

            myModelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(d => d.OrderDetailsId)
                      .HasName("OrderDetailsId");
            });

            myModelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(d => d.OrderItemId)
                      .HasName("OrderItemId");
            });

            myModelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.HasKey(d => d.CartId)
                      .HasName("CartId");
            });

            myModelBuilder.Entity<CartItem>(entity =>
            {
                entity.HasKey(d => d.CartItemId)
                      .HasName("CartItemId");
            });

            myModelBuilder.Entity<Image>( entity =>
            {
                entity.HasOne(d => d.Product)
                      .WithMany(p => p.Images)
                      .HasForeignKey("ProductId");
            });

            myModelBuilder.Entity<OrderItem>( entity =>
            {
                    entity.HasOne(d => d.Order)
                          .WithMany(p => p.OrderItems)
                          .HasForeignKey("OrderDetailsId");
            });

            myModelBuilder.Entity<CartItem>( entity =>
            {
                    entity.HasOne(d => d.ShoppingCart)
                          .WithMany(p => p.CartItems)
                          .HasForeignKey("CartId");
            });


            string LDragoID = "7bfd10ec-b1da-4aca-9271-6731715455a5";
            string CPegasusID = "40cdbf5b-9e8d-4a8f-aa6b-b74700a02453";
            string FLeoneID = "052cab8c-985e-4818-8fb8-ffb5d4a10249";
            string BUnicornoID = "714e4da1-6b46-49df-87fb-7d20b55175a5";
            string LibraID = "d549e4fe-bb29-476d-a3ae-c7533c44773c";
            string DNemesisID = "66b879cf-637f-4f29-843d-03a60e35d9e5";
            string GPersuesID = "464aa345-82ef-4e6b-98b4-ea5e6db4ac69";
            string HKerbecsID = "463005ef-ba02-4ac4-b369-eaf5db49b358";

            myModelBuilder.Entity<Image>().HasData(
                new Image { ProductId = LDragoID, ImageId = "1a70c6c0-95c3-46b7-a9a6-3abbc69ba1cf", ImageURL = "https://ae01.alicdn.com/kf/HTB1ZZ8GKFXXXXb3aXXXq6xXFXXX0/Bayblades-Spinning-Top-METAL-FUSION-BB88-METEO-L-DRAGO-LW105LF-Launchers-L-R-Double.jpg" },
                new Image { ProductId = CPegasusID, ImageId = "5fd6d1cc-6fe4-496f-8182-a264938eb7b6", ImageURL = "https://ae01.alicdn.com/kf/HTB1IcGmcxiH3KVjSZPfq6xBiVXaO/oMoToys-Beyblades-Big-Bang-Pegasis-BB105-Metal-4D-System-Cosmic-Pegasus-F-D-with-Launcher-Pack.jpg_Q90.jpg_.webp" },
                new Image { ProductId = FLeoneID, ImageId = "f81d5219-7f71-40d0-b4b1-5fb86c810c1f", ImageURL = "http://images5.fanpop.com/image/photos/30900000/Random-4D-beyblades-beyblade-metal-fury-30966056-379-335.jpg" },
                new Image { ProductId = BUnicornoID, ImageId = "ccba718f-eda0-4b15-95c4-3579cc655150", ImageURL = "https://m.media-amazon.com/images/I/51v6c-NAPHL._AC_.jpg" },
                new Image { ProductId = LibraID, ImageId = "eeef3006-2ada-4811-97fc-e4ca42e336a8", ImageURL = "https://i5.walmartimages.com/asr/b2f830f2-c6df-4262-a764-ab65cccc2b2d.3e80a3fbe05918fe7e59e91b15e8ab2a.jpeg" },
                new Image { ProductId = DNemesisID, ImageId = "bf3be07b-d65e-4796-8aff-d2b9315fe9ec", ImageURL = "https://i.ebayimg.com/00/s/MTE3NlgxMTc2/z/ZBsAAOSwWWxY-cVZ/$_12.JPG" },
                new Image { ProductId = DNemesisID, ImageId = "951bc77e-9d11-4ffa-8452-e8185bcf6f08", ImageURL = "https://cdn11.bigcommerce.com/s-iodt3qca/images/stencil/1280x1280/products/386/1664/DiabloNemesisTakara1NWM__38445.1587767442.jpg?c=2" },
                new Image { ProductId = DNemesisID, ImageId = "2767d0eb-5ac0-4709-872c-107d6b05af76", ImageURL = "https://cdn11.bigcommerce.com/s-iodt3qca/images/stencil/1280x1280/products/414/827/s-l1600__21220.1535822191.jpg?c=2" },
                new Image { ProductId = GPersuesID, ImageId = "f1311d0c-78f1-492c-9f90-a5f9d62c988e", ImageURL = "https://images-na.ssl-images-amazon.com/images/I/71k4SkSUIIL._AC_SL1500_.jpg" },
                new Image { ProductId = HKerbecsID, ImageId = "194ac58f-c2a4-43b6-9d08-6a324a040350", ImageURL = "https://i.ebayimg.com/images/g/jKQAAOSwc2dfbBIH/s-l640.jpg" }
                );

            myModelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = LDragoID,
                    Name = "Meteo L-Drago LW105LF",
                    Price = 69.99,
                    Category = "Metal Fusion Beyblade",
                    Description = "Meteo L-Drago LW105LF",
                    Stock = 4,
                    DiscountId = null
                },
                new Product
                {
                    ProductId = CPegasusID,
                    Name = "Cosmic Pegasus F:D",
                    Price = 69.99,
                    Category = "Metal Fusion Beyblade",
                    Description = "Cosmic Pegasus F:D",
                    Stock = 10,
                    DiscountId = null
                },
                new Product
                {
                    ProductId = FLeoneID,
                    Name = "Fang Leone 130W2D",
                    Price = 69.99,
                    Category = "Metal Fusion Beyblade",
                    Description = "Fang Leone",
                    Stock = 3,
                    DiscountId = null
                },
                new Product
                {
                    ProductId = BUnicornoID,
                    Name = "Blitz Striker 100RSF",
                    Price = 69.99,
                    Category = "Metal Fusion Beyblade",
                    Description = "Blitz Striker 100RSF ",
                    Stock = 0,
                    DiscountId = "wqeqwrewtewtw"
                },
                new Product
                {
                    ProductId = LibraID,
                    Name = "Flame Libra T125ES",
                    Price = 69.99,
                    Category = "Metal Fusion Beyblade",
                    Description = "Flame Libra T125ES ",
                    Stock = 7,
                    DiscountId = null
                },
                new Product
                {
                    ProductId = DNemesisID,
                    Name = "Diablo Nemesis X:D",
                    Price = 69.99,
                    Category = "Metal Fusion Beyblade",
                    Description = "Diablo Nemesis X:D",
                    Stock = 9,
                    DiscountId = null
                },
                new Product
                {
                    ProductId = GPersuesID,
                    Name = "Gravity Destroyer AD145WD",
                    Price = 69.99,
                    Category = "Metal Fusion Beyblade",
                    Description = "Gravity Destroyer AD145WD",
                    Stock = 2,
                    DiscountId = null
                },
                new Product
                {
                    ProductId = HKerbecsID,
                    Name = "Hades Kerbecs BD145DS",
                    Price = 69.99,
                    Category = "Metal Fusion Beyblade",
                    Description = "Hades Kerbecs BD145DS",
                    Stock = 100,
                    DiscountId = null
                }
            );
        }
    }
}
