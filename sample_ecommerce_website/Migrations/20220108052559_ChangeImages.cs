using Microsoft.EntityFrameworkCore.Migrations;

namespace sample_ecommerce_website.Migrations
{
    public partial class ChangeImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "194ac58f-c2a4-43b6-9d08-6a324a040350",
                column: "ImageURL",
                value: "https://i.ebayimg.com/images/g/jKQAAOSwc2dfbBIH/s-l640.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "1a70c6c0-95c3-46b7-a9a6-3abbc69ba1cf",
                column: "ImageURL",
                value: "https://ae01.alicdn.com/kf/HTB1ZZ8GKFXXXXb3aXXXq6xXFXXX0/Bayblades-Spinning-Top-METAL-FUSION-BB88-METEO-L-DRAGO-LW105LF-Launchers-L-R-Double.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "2767d0eb-5ac0-4709-872c-107d6b05af76",
                column: "ImageURL",
                value: "https://cdn11.bigcommerce.com/s-iodt3qca/images/stencil/1280x1280/products/414/827/s-l1600__21220.1535822191.jpg?c=2");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "5fd6d1cc-6fe4-496f-8182-a264938eb7b6",
                column: "ImageURL",
                value: "https://ae01.alicdn.com/kf/HTB1IcGmcxiH3KVjSZPfq6xBiVXaO/oMoToys-Beyblades-Big-Bang-Pegasis-BB105-Metal-4D-System-Cosmic-Pegasus-F-D-with-Launcher-Pack.jpg_Q90.jpg_.webp");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "951bc77e-9d11-4ffa-8452-e8185bcf6f08",
                column: "ImageURL",
                value: "https://cdn11.bigcommerce.com/s-iodt3qca/images/stencil/1280x1280/products/386/1664/DiabloNemesisTakara1NWM__38445.1587767442.jpg?c=2");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "bf3be07b-d65e-4796-8aff-d2b9315fe9ec",
                column: "ImageURL",
                value: "https://i.ebayimg.com/00/s/MTE3NlgxMTc2/z/ZBsAAOSwWWxY-cVZ/$_12.JPG");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "ccba718f-eda0-4b15-95c4-3579cc655150",
                column: "ImageURL",
                value: "https://m.media-amazon.com/images/I/51v6c-NAPHL._AC_.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "eeef3006-2ada-4811-97fc-e4ca42e336a8",
                column: "ImageURL",
                value: "https://i5.walmartimages.com/asr/b2f830f2-c6df-4262-a764-ab65cccc2b2d.3e80a3fbe05918fe7e59e91b15e8ab2a.jpeg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "f1311d0c-78f1-492c-9f90-a5f9d62c988e",
                column: "ImageURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/71k4SkSUIIL._AC_SL1500_.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "f81d5219-7f71-40d0-b4b1-5fb86c810c1f",
                column: "ImageURL",
                value: "http://images5.fanpop.com/image/photos/30900000/Random-4D-beyblades-beyblade-metal-fury-30966056-379-335.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "194ac58f-c2a4-43b6-9d08-6a324a040350",
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/beyblade/images/1/1d/5-018.jpg/revision/latest/scale-to-width-down/350?cb=20130201061230");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "1a70c6c0-95c3-46b7-a9a6-3abbc69ba1cf",
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/beyblade/images/e/e2/MeteoLDrago2.jpg/revision/latest/scale-to-width-down/350?cb=20210729012214");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "2767d0eb-5ac0-4709-872c-107d6b05af76",
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/beyblade/images/0/05/Diablonemesis.jpg/revision/latest/scale-to-width-down/1000?cb=20210729015755");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "5fd6d1cc-6fe4-496f-8182-a264938eb7b6",
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/beyblade/images/e/ed/600px-BigBangPegasis.jpg/revision/latest/scale-to-width-down/1000?cb=20210729032512");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "951bc77e-9d11-4ffa-8452-e8185bcf6f08",
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/beyblade/images/6/62/DiabloNemesisXDTTBox.jpg/revision/latest/scale-to-width-down/1000?cb=20210615224907");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "bf3be07b-d65e-4796-8aff-d2b9315fe9ec",
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/beyblade/images/b/bb/BeybladeLegendsDiabloNemesisXD.png/revision/latest?cb=20140829221511");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "ccba718f-eda0-4b15-95c4-3579cc655150",
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/beyblade/images/e/e6/224466_10150260556836334_652091333_7652945_3113508_n.jpg/revision/latest/scale-to-width-down/350?cb=20210729020541");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "eeef3006-2ada-4811-97fc-e4ca42e336a8",
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/beyblade/images/b/b9/FlameLibra.jpg/revision/latest/scale-to-width-down/500?cb=20101216230749");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "f1311d0c-78f1-492c-9f90-a5f9d62c988e",
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/beyblade/images/2/22/GravityPerseus.jpg/revision/latest?cb=20210729011724");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: "f81d5219-7f71-40d0-b4b1-5fb86c810c1f",
                column: "ImageURL",
                value: "https://static.wikia.nocookie.net/beyblade/images/c/ca/Fangleone.jpg/revision/latest?cb=20210729032300");
        }
    }
}
