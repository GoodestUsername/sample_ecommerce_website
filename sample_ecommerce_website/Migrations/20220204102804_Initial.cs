using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sample_ecommerce_website.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<double>(maxLength: 255, nullable: false),
                    Category = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    Stock = table.Column<int>(nullable: false),
                    DiscountId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    AddressId = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    Province = table.Column<string>(maxLength: 60, nullable: false),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: false),
                    Country = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("AddressId", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<string>(nullable: false),
                    ImageURL = table.Column<string>(nullable: false),
                    ProductId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 200, nullable: false),
                    LastName = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNum = table.Column<int>(maxLength: 24, nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    HomeAddressAddressId = table.Column<string>(nullable: true),
                    ShippingAddressAddressId = table.Column<string>(nullable: true),
                    BillingAddressAddressId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_UserAddresses_BillingAddressAddressId",
                        column: x => x.BillingAddressAddressId,
                        principalTable: "UserAddresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserAddresses_HomeAddressAddressId",
                        column: x => x.HomeAddressAddressId,
                        principalTable: "UserAddresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserAddresses_ShippingAddressAddressId",
                        column: x => x.ShippingAddressAddressId,
                        principalTable: "UserAddresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<string>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    ItemQuantity = table.Column<int>(nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CartId", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_User_Id",
                        column: x => x.Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderDetailsId = table.Column<string>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    BillingAddressAddressId = table.Column<string>(nullable: true),
                    ShippingAddressAddressId = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    OrderModificationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OrderDetailsId", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_Orders_UserAddresses_BillingAddressAddressId",
                        column: x => x.BillingAddressAddressId,
                        principalTable: "UserAddresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_User_Id",
                        column: x => x.Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_UserAddresses_ShippingAddressAddressId",
                        column: x => x.ShippingAddressAddressId,
                        principalTable: "UserAddresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<string>(nullable: true),
                    CartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CartItemId", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    OrderDetailsId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OrderItemId", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderDetailsId",
                        column: x => x.OrderDetailsId,
                        principalTable: "Orders",
                        principalColumn: "OrderDetailsId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "DiscountId", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { "7bfd10ec-b1da-4aca-9271-6731715455a5", "Metal Fusion Beyblade", "Meteo L-Drago LW105LF", null, "Meteo L-Drago LW105LF", 69.989999999999995, 4 },
                    { "40cdbf5b-9e8d-4a8f-aa6b-b74700a02453", "Metal Fusion Beyblade", "Cosmic Pegasus F:D", null, "Cosmic Pegasus F:D", 69.989999999999995, 10 },
                    { "052cab8c-985e-4818-8fb8-ffb5d4a10249", "Metal Fusion Beyblade", "Fang Leone", null, "Fang Leone 130W2D", 69.989999999999995, 3 },
                    { "714e4da1-6b46-49df-87fb-7d20b55175a5", "Metal Fusion Beyblade", "Blitz Striker 100RSF ", "wqeqwrewtewtw", "Blitz Striker 100RSF", 69.989999999999995, 0 },
                    { "d549e4fe-bb29-476d-a3ae-c7533c44773c", "Metal Fusion Beyblade", "Flame Libra T125ES ", null, "Flame Libra T125ES", 69.989999999999995, 7 },
                    { "66b879cf-637f-4f29-843d-03a60e35d9e5", "Metal Fusion Beyblade", "Diablo Nemesis X:D", null, "Diablo Nemesis X:D", 69.989999999999995, 9 },
                    { "464aa345-82ef-4e6b-98b4-ea5e6db4ac69", "Metal Fusion Beyblade", "Gravity Destroyer AD145WD", null, "Gravity Destroyer AD145WD", 69.989999999999995, 2 },
                    { "463005ef-ba02-4ac4-b369-eaf5db49b358", "Metal Fusion Beyblade", "Hades Kerbecs BD145DS", null, "Hades Kerbecs BD145DS", 69.989999999999995, 100 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "ImageURL", "ProductId" },
                values: new object[,]
                {
                    { "1a70c6c0-95c3-46b7-a9a6-3abbc69ba1cf", "https://ae01.alicdn.com/kf/HTB1ZZ8GKFXXXXb3aXXXq6xXFXXX0/Bayblades-Spinning-Top-METAL-FUSION-BB88-METEO-L-DRAGO-LW105LF-Launchers-L-R-Double.jpg", "7bfd10ec-b1da-4aca-9271-6731715455a5" },
                    { "5fd6d1cc-6fe4-496f-8182-a264938eb7b6", "https://ae01.alicdn.com/kf/HTB1IcGmcxiH3KVjSZPfq6xBiVXaO/oMoToys-Beyblades-Big-Bang-Pegasis-BB105-Metal-4D-System-Cosmic-Pegasus-F-D-with-Launcher-Pack.jpg_Q90.jpg_.webp", "40cdbf5b-9e8d-4a8f-aa6b-b74700a02453" },
                    { "f81d5219-7f71-40d0-b4b1-5fb86c810c1f", "http://images5.fanpop.com/image/photos/30900000/Random-4D-beyblades-beyblade-metal-fury-30966056-379-335.jpg", "052cab8c-985e-4818-8fb8-ffb5d4a10249" },
                    { "ccba718f-eda0-4b15-95c4-3579cc655150", "https://m.media-amazon.com/images/I/51v6c-NAPHL._AC_.jpg", "714e4da1-6b46-49df-87fb-7d20b55175a5" },
                    { "eeef3006-2ada-4811-97fc-e4ca42e336a8", "https://i5.walmartimages.com/asr/b2f830f2-c6df-4262-a764-ab65cccc2b2d.3e80a3fbe05918fe7e59e91b15e8ab2a.jpeg", "d549e4fe-bb29-476d-a3ae-c7533c44773c" },
                    { "bf3be07b-d65e-4796-8aff-d2b9315fe9ec", "https://i.ebayimg.com/00/s/MTE3NlgxMTc2/z/ZBsAAOSwWWxY-cVZ/$_12.JPG", "66b879cf-637f-4f29-843d-03a60e35d9e5" },
                    { "951bc77e-9d11-4ffa-8452-e8185bcf6f08", "https://cdn11.bigcommerce.com/s-iodt3qca/images/stencil/1280x1280/products/386/1664/DiabloNemesisTakara1NWM__38445.1587767442.jpg?c=2", "66b879cf-637f-4f29-843d-03a60e35d9e5" },
                    { "2767d0eb-5ac0-4709-872c-107d6b05af76", "https://cdn11.bigcommerce.com/s-iodt3qca/images/stencil/1280x1280/products/414/827/s-l1600__21220.1535822191.jpg?c=2", "66b879cf-637f-4f29-843d-03a60e35d9e5" },
                    { "f1311d0c-78f1-492c-9f90-a5f9d62c988e", "https://images-na.ssl-images-amazon.com/images/I/71k4SkSUIIL._AC_SL1500_.jpg", "464aa345-82ef-4e6b-98b4-ea5e6db4ac69" },
                    { "194ac58f-c2a4-43b6-9d08-6a324a040350", "https://i.ebayimg.com/images/g/jKQAAOSwc2dfbBIH/s-l640.jpg", "463005ef-ba02-4ac4-b369-eaf5db49b358" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_Id",
                table: "Carts",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderDetailsId",
                table: "OrderItems",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillingAddressAddressId",
                table: "Orders",
                column: "BillingAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id",
                table: "Orders",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressAddressId",
                table: "Orders",
                column: "ShippingAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_User_BillingAddressAddressId",
                table: "User",
                column: "BillingAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_User_HomeAddressAddressId",
                table: "User",
                column: "HomeAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ShippingAddressAddressId",
                table: "User",
                column: "ShippingAddressAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserAddresses");
        }
    }
}
