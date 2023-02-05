using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Data.Migrations
{
    public partial class Päevik1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PäevikSisu_Päevik_PäevikId",
                table: "PäevikSisu");

            migrationBuilder.DropColumn(
                name: "Päevik",
                table: "PäevikSisu");

            migrationBuilder.AlterColumn<int>(
                name: "PäevikId",
                table: "PäevikSisu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PäevikSisu_Päevik_PäevikId",
                table: "PäevikSisu",
                column: "PäevikId",
                principalTable: "Päevik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PäevikSisu_Päevik_PäevikId",
                table: "PäevikSisu");

            migrationBuilder.AlterColumn<int>(
                name: "PäevikId",
                table: "PäevikSisu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Päevik",
                table: "PäevikSisu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PäevikSisu_Päevik_PäevikId",
                table: "PäevikSisu",
                column: "PäevikId",
                principalTable: "Päevik",
                principalColumn: "Id");
        }
    }
}
