using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishFlashCardsWeb.Migrations
{
    public partial class migration_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SetFolderMatches",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    setID = table.Column<int>(type: "int", nullable: false),
                    folderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetFolderMatches", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SetFolderMatches");
        }
    }
}
