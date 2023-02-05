using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Data.Migrations
{
    public partial class Päevik9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Päevik",
                newName: "Kuupäev");

            migrationBuilder.AddColumn<string>(
                name: "Harjutus",
                table: "PäevikSisu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Harjutus",
                table: "PäevikSisu");

            migrationBuilder.RenameColumn(
                name: "Kuupäev",
                table: "Päevik",
                newName: "Title");
        }
    }
}
