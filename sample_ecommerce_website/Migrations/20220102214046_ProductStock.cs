using Microsoft.EntityFrameworkCore.Migrations;

namespace sample_ecommerce_website.Migrations
{
    public partial class ProductStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: "asdfasdgafgdg",
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: "asdjioasdos",
                column: "Stock",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: "asdwrwdrwerew",
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: "basdafgagasd",
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: "jhahasja",
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: "nnlhjhjhiy",
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: "opiljuppoiop",
                column: "Stock",
                value: 7);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");
        }
    }
}
