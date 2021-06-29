using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlags.Migrations
{
    public partial class ne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 24,
                column: "GameId",
                value: "p");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 24,
                column: "GameId",
                value: "s");
        }
    }
}
