using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Data.Migrations
{
    public partial class Päevik3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Harjutus",
                table: "Päevik");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Harjutus",
                table: "Päevik",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
