using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishFlashCardsWeb.Migrations
{
    public partial class migration_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardsetID",
                table: "FlashCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cardUserID",
                table: "FlashCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cardSetUserID",
                table: "CardSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "folderID",
                table: "CardSets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardsetID",
                table: "FlashCards");

            migrationBuilder.DropColumn(
                name: "cardUserID",
                table: "FlashCards");

            migrationBuilder.DropColumn(
                name: "cardSetUserID",
                table: "CardSets");

            migrationBuilder.DropColumn(
                name: "folderID",
                table: "CardSets");
        }
    }
}
