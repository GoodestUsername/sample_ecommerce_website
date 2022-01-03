using Microsoft.EntityFrameworkCore.Migrations;

namespace sample_ecommerce_website.Migrations
{
    public partial class ChangeImageSource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "ahnfkdh",
                column: "ImageURL",
                value: "https://cdn.pixabay.com/photo/2013/07/13/09/45/tennis-racket-155963_960_720.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "asdasdwe",
                column: "ImageURL",
                value: "https://cdn.pixabay.com/photo/2020/03/22/04/09/baseball-bat-4955795_960_720.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "asjkfnd",
                column: "ImageURL",
                value: "https://cdn.pixabay.com/photo/2014/04/03/11/37/tennis-shoes-312023_960_720.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "dfkjndsf",
                column: "ImageURL",
                value: "https://cdn.pixabay.com/photo/2013/07/13/10/51/football-157930_960_720.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "eqnasfdw",
                column: "ImageURL",
                value: "https://cdn.pixabay.com/photo/2013/07/12/17/41/computer-mouse-152249_960_720.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "gflsdhe",
                column: "ImageURL",
                value: "https://cdn.pixabay.com/photo/2013/07/13/14/08/apparel-162192_960_720.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "iurheiu",
                column: "ImageURL",
                value: "https://cdn.pixabay.com/photo/2014/04/03/10/01/tennis-309621_960_720.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "jkpafas",
                column: "ImageURL",
                value: "https://cdn.pixabay.com/photo/2012/04/14/16/20/t-shirt-34481_960_720.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "sdyiueki",
                column: "ImageURL",
                value: "https://cdn.pixabay.com/photo/2014/04/03/11/37/tennis-312002_960_720.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "zljshxdl",
                column: "ImageURL",
                value: "https://cdn.pixabay.com/photo/2013/07/13/14/07/apparel-162180_960_720.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "ahnfkdh",
                column: "ImageURL",
                value: "https://www.shutterstock.com/image-photo/new-tennis-racket-isolated-on-white-471436889");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "asdasdwe",
                column: "ImageURL",
                value: "https://www.shutterstock.com/image-photo/wooden-baseball-bat-isolated-on-white-378948592");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "asjkfnd",
                column: "ImageURL",
                value: "https://www.shutterstock.com/image-photo/vintage-red-shoes-on-white-background-92008067");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "dfkjndsf",
                column: "ImageURL",
                value: "https://www.shutterstock.com/image-photo/soccer-ball-isolated-on-white-129557066");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "eqnasfdw",
                column: "ImageURL",
                value: "https://www.shutterstock.com/image-photo/professional-wireless-game-mouse-on-dark-750226153");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "gflsdhe",
                column: "ImageURL",
                value: "https://www.shutterstock.com/image-photo/red-tshirt-clothes-on-isolated-white-618080519");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "iurheiu",
                column: "ImageURL",
                value: "https://www.shutterstock.com/image-photo/tennis-racket-on-white-background-760686820");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "jkpafas",
                column: "ImageURL",
                value: "https://www.shutterstock.com/image-vector/black-realistic-tshirt-front-view-isolated-1925573966");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "sdyiueki",
                column: "ImageURL",
                value: "https://www.shutterstock.com/image-vector/tennis-racket-silhouette-1075969826");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "zljshxdl",
                column: "ImageURL",
                value: "https://www.shutterstock.com/image-photo/blue-blank-t-shirt-template-isolated-690352057");
        }
    }
}
