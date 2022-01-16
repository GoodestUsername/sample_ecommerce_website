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
                    ProductID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    DiscountID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
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
                    ImageID = table.Column<string>(nullable: false),
                    ImageURL = table.Column<string>(nullable: false),
                    ProductID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageID);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Category", "Description", "DiscountID", "Name", "Price", "Stock" },
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
                columns: new[] { "ImageID", "ImageURL", "ProductID" },
                values: new object[,]
                {
                    { "1a70c6c0-95c3-46b7-a9a6-3abbc69ba1cf", "https://static.wikia.nocookie.net/beyblade/images/e/e2/MeteoLDrago2.jpg/revision/latest/scale-to-width-down/350?cb=20210729012214", "7bfd10ec-b1da-4aca-9271-6731715455a5" },
                    { "5fd6d1cc-6fe4-496f-8182-a264938eb7b6", "https://static.wikia.nocookie.net/beyblade/images/e/ed/600px-BigBangPegasis.jpg/revision/latest/scale-to-width-down/1000?cb=20210729032512", "40cdbf5b-9e8d-4a8f-aa6b-b74700a02453" },
                    { "f81d5219-7f71-40d0-b4b1-5fb86c810c1f", "https://static.wikia.nocookie.net/beyblade/images/c/ca/Fangleone.jpg/revision/latest?cb=20210729032300", "052cab8c-985e-4818-8fb8-ffb5d4a10249" },
                    { "ccba718f-eda0-4b15-95c4-3579cc655150", "https://static.wikia.nocookie.net/beyblade/images/e/e6/224466_10150260556836334_652091333_7652945_3113508_n.jpg/revision/latest/scale-to-width-down/350?cb=20210729020541", "714e4da1-6b46-49df-87fb-7d20b55175a5" },
                    { "eeef3006-2ada-4811-97fc-e4ca42e336a8", "https://static.wikia.nocookie.net/beyblade/images/b/b9/FlameLibra.jpg/revision/latest/scale-to-width-down/500?cb=20101216230749", "d549e4fe-bb29-476d-a3ae-c7533c44773c" },
                    { "2767d0eb-5ac0-4709-872c-107d6b05af76", "https://static.wikia.nocookie.net/beyblade/images/0/05/Diablonemesis.jpg/revision/latest/scale-to-width-down/1000?cb=20210729015755", "66b879cf-637f-4f29-843d-03a60e35d9e5" },
                    { "bf3be07b-d65e-4796-8aff-d2b9315fe9ec", "https://static.wikia.nocookie.net/beyblade/images/b/bb/BeybladeLegendsDiabloNemesisXD.png/revision/latest?cb=20140829221511", "66b879cf-637f-4f29-843d-03a60e35d9e5" },
                    { "951bc77e-9d11-4ffa-8452-e8185bcf6f08", "https://static.wikia.nocookie.net/beyblade/images/6/62/DiabloNemesisXDTTBox.jpg/revision/latest/scale-to-width-down/1000?cb=20210615224907", "66b879cf-637f-4f29-843d-03a60e35d9e5" },
                    { "f1311d0c-78f1-492c-9f90-a5f9d62c988e", "https://static.wikia.nocookie.net/beyblade/images/2/22/GravityPerseus.jpg/revision/latest?cb=20210729011724", "464aa345-82ef-4e6b-98b4-ea5e6db4ac69" },
                    { "194ac58f-c2a4-43b6-9d08-6a324a040350", "https://static.wikia.nocookie.net/beyblade/images/1/1d/5-018.jpg/revision/latest/scale-to-width-down/350?cb=20130201061230", "463005ef-ba02-4ac4-b369-eaf5db49b358" }
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
                name: "IX_Images_ProductID",
                table: "Images",
                column: "ProductID");
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
                name: "Images");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
