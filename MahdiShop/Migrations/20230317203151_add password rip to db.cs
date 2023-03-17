using Microsoft.EntityFrameworkCore.Migrations;

namespace MahdiShop.Migrations
{
    public partial class addpasswordriptodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordRip",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordRip",
                table: "User");
        }
    }
}
