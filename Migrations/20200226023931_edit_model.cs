using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class edit_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "content",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "highlight",
                table: "Articles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "content",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "highlight",
                table: "Articles");
        }
    }
}
