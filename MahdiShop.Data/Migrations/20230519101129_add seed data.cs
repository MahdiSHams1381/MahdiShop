using Microsoft.EntityFrameworkCore.Migrations;

namespace MahdiShop.Migrations
{
    public partial class addseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Profile",
                table: "Product",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "Description", "Name", "Price", "Profile" },
                values: new object[,]
                {
                    { 1, null, "the best", "tv", 14000000m, "/css/55f21061-6ed3-4890-9eea-0b666a711af9.jpg" },
                    { 2, null, "the best food in iran", "sandwich", 15000m, "/css/d77a4624-8f71-47eb-b94b-bb517e2f3db7.jpg" },
                    { 3, null, "blue and black", "mobl", 5000000m, "/css/7fd072b6-3bd1-453c-90e2-07e29fe3b12a.jpg" },
                    { 4, null, "best wood", "chair", 3200000m, "/css/6d78ebf4-ee68-46e4-b68e-8be4c978044a.jpg" },
                    { 5, null, "green and red", "saled", 60000m, "/css/9ffe609d-10c2-4232-9cca-8a0afbe42601.jpg" },
                    { 6, null, "asdajlasxa", "shar", 1456m, "/css/55f21061-6ed3-4890-9eea-0b666a711af9.jpg" },
                    { 7, null, "Monaseb Baray hameh senin", "SabziJat", 14000m, "/css/49493ef7-b16c-427f-8ea8-aee2a67ff461.jpg" },
                    { 8, null, "Baray jahizieh", "Home app", 280000000m, "/css/9ffe609d-10c2-4232-9cca-8a0afbe42601.jpg" },
                    { 9, null, "besyarKhoob", "YakhChal", 30000000m, "/css/d77a4624-8f71-47eb-b94b-bb517e2f3db7.jpg" },
                    { 10, null, "dar ranghay motafavet", "Goshi", 5000000m, "/css/e0ce94cb-4ee1-46a4-8001-e1acc8aa315b.jpg" },
                    { 11, null, "hameh chiz ra khord ly konad", "hamzan", 4800000m, "/css/7fd072b6-3bd1-453c-90e2-07e29fe3b12a.jpg" },
                    { 12, null, "besyar dag my koonad", "snaksaz", 2500000m, "/css/8db76f47-db5c-4828-85ac-9ab24ab1ab3c.jpg" },
                    { 13, null, "khoshPokht", "Nan", 3700m, "/css/6d78ebf4-ee68-46e4-b68e-8be4c978044a.jpg" },
                    { 14, null, "a book that  you can read", "book", 145900m, "/css/8012f3fb-645c-4ca4-acdf-a612e3ff7d8b.jpg" },
                    { 15, null, "have blue and yellow", "bag", 25000000m, "/css/40e2420a-7d60-437d-83b9-4fdf7a07455d.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "Profile",
                table: "Product");
        }
    }
}
