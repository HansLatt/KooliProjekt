using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Data.Migrations
{
    public partial class Päevik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Harjutus",
                table: "Päevik");

            migrationBuilder.CreateTable(
                name: "PäevikSisu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Harjutus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Päevik = table.Column<int>(type: "int", nullable: false),
                    PäevikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PäevikSisu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PäevikSisu_Päevik_PäevikId",
                        column: x => x.PäevikId,
                        principalTable: "Päevik",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PäevikSisu_PäevikId",
                table: "PäevikSisu",
                column: "PäevikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PäevikSisu");

            migrationBuilder.AddColumn<string>(
                name: "Harjutus",
                table: "Päevik",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
