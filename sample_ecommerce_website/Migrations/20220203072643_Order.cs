using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sample_ecommerce_website.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ShoppingCartId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    AddressID = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    Province = table.Column<string>(maxLength: 60, nullable: false),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: false),
                    Country = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.AddressID);
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
                    HomeAddressAddressID = table.Column<string>(nullable: true),
                    ShippingAddressAddressID = table.Column<string>(nullable: true),
                    BillingAddressAddressID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_UserAddresses_BillingAddressAddressID",
                        column: x => x.BillingAddressAddressID,
                        principalTable: "UserAddresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserAddresses_HomeAddressAddressID",
                        column: x => x.HomeAddressAddressID,
                        principalTable: "UserAddresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_UserAddresses_ShippingAddressAddressID",
                        column: x => x.ShippingAddressAddressID,
                        principalTable: "UserAddresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CartID = table.Column<string>(nullable: true),
                    Total = table.Column<double>(nullable: false),
                    ItemQuantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
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
                    OrderDetailsID = table.Column<string>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    BillingAddressAddressID = table.Column<string>(nullable: true),
                    ShippingAddressAddressID = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    OrderModificationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderDetailsID);
                    table.ForeignKey(
                        name: "FK_Orders_UserAddresses_BillingAddressAddressID",
                        column: x => x.BillingAddressAddressID,
                        principalTable: "UserAddresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_User_Id",
                        column: x => x.Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_UserAddresses_ShippingAddressAddressID",
                        column: x => x.ShippingAddressAddressID,
                        principalTable: "UserAddresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemID = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ProductID = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    OrderDetailsID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderDetailsID",
                        column: x => x.OrderDetailsID,
                        principalTable: "Orders",
                        principalColumn: "OrderDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShoppingCartId",
                table: "Products",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderDetailsID",
                table: "OrderItems",
                column: "OrderDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillingAddressAddressID",
                table: "Orders",
                column: "BillingAddressAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id",
                table: "Orders",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressAddressID",
                table: "Orders",
                column: "ShippingAddressAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_User_BillingAddressAddressID",
                table: "User",
                column: "BillingAddressAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_User_HomeAddressAddressID",
                table: "User",
                column: "HomeAddressAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_User_ShippingAddressAddressID",
                table: "User",
                column: "ShippingAddressAddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Carts_ShoppingCartId",
                table: "Products",
                column: "ShoppingCartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Carts_ShoppingCartId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Products_ShoppingCartId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "Products");
        }
    }
}
