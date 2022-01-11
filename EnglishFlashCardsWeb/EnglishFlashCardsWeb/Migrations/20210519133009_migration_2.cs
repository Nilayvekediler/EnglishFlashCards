using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishFlashCardsWeb.Migrations
{
    public partial class migration_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "setName",
                table: "CardSets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "setName",
                table: "CardSets");
        }
    }
}
