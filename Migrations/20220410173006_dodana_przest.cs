using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzzWeb.Migrations
{
    public partial class dodana_przest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Leap",
                table: "Data",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Leap",
                table: "Dane");
        }
    }
}
