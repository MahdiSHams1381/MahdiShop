using Microsoft.EntityFrameworkCore.Migrations;

namespace MahdiShop.Migrations
{
    public partial class addseenumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeeNumber",
                table: "Product",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeeNumber",
                table: "Product");
        }
    }
}
