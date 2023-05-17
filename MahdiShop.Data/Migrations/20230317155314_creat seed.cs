using Microsoft.EntityFrameworkCore.Migrations;

namespace MahdiShop.Migrations
{
    public partial class creatseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Discription", "Name" },
                values: new object[,]
                {
                    { 1, "All of the thing that can eat", "food" },
                    { 2, "All of the thing that Use in home", "HomeTools" },
                    { 3, "All of the thing that work with electronic", "Eletrition tools" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Password", "UserEmail", "UserName", "UserPhone" },
                values: new object[] { 1, "1234", "Admin@gmail.com", "Admin", "090000000000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
