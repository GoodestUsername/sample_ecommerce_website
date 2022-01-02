using Microsoft.EntityFrameworkCore.Migrations;

namespace sample_ecommerce_website.Migrations
{
    public partial class Images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Images",
                columns: new[] { "ImageID", "ImageURL", "ProductID" },
                values: new object[,]
                {
                    { "asdasdwe", "https://www.shutterstock.com/image-photo/wooden-baseball-bat-isolated-on-white-378948592", "asdfasdgafgdg" },
                    { "jkpafas", "https://www.shutterstock.com/image-vector/black-realistic-tshirt-front-view-isolated-1925573966", "basdafgagasd" },
                    { "ahnfkdh", "https://www.shutterstock.com/image-photo/new-tennis-racket-isolated-on-white-471436889", "asdwrwdrwerew" },
                    { "iurheiu", "https://www.shutterstock.com/image-photo/tennis-racket-on-white-background-760686820", "asdwrwdrwerew" },
                    { "sdyiueki", "https://www.shutterstock.com/image-vector/tennis-racket-silhouette-1075969826", "asdwrwdrwerew" },
                    { "zljshxdl", "https://www.shutterstock.com/image-photo/blue-blank-t-shirt-template-isolated-690352057", "sdfsdsgsssaa" },
                    { "dfkjndsf", "https://www.shutterstock.com/image-photo/soccer-ball-isolated-on-white-129557066", "opiljuppoiop" },
                    { "gflsdhe", "https://www.shutterstock.com/image-photo/red-tshirt-clothes-on-isolated-white-618080519", "nnlhjhjhiy" },
                    { "asjkfnd", "https://www.shutterstock.com/image-photo/vintage-red-shoes-on-white-background-92008067", "jhahasja" },
                    { "eqnasfdw", "https://www.shutterstock.com/image-photo/professional-wireless-game-mouse-on-dark-750226153", "asdjioasdos" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductID",
                table: "Images",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
