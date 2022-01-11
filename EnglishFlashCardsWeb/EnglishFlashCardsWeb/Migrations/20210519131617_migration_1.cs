using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishFlashCardsWeb.Migrations
{
    public partial class migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardSets",
                columns: table => new
                {
                    setID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardSets", x => x.setID);
                });

            migrationBuilder.CreateTable(
                name: "FlashCards",
                columns: table => new
                {
                    cardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    word = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    meaning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wordType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senaryo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlashCards", x => x.cardID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardSets");

            migrationBuilder.DropTable(
                name: "FlashCards");
        }
    }
}
