using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanulok.Migrations
{
    public partial class Osztaly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Osztaly",
                table: "Diakok",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Osztaly",
                table: "Diakok");
        }
    }
}
