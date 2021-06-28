using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicFlags.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LogoImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SportId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "i", "Indoor" },
                    { "o", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name" },
                values: new object[,]
                {
                    { "s", "Summer Olympics" },
                    { "w", "Winter Olympics" },
                    { "p", "Paralympics" },
                    { "y", "Youth Olympics" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportId", "Name" },
                values: new object[,]
                {
                    { "a", "Archery" },
                    { "b", "Bobsleigh" },
                    { "bd", "Breakdancing" },
                    { "cs", "Canoe Sprint" },
                    { "c", "Curling" },
                    { "d", "Diving" },
                    { "r", "Road Cycling" },
                    { "s", "Skateboarding" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CategoryId", "GameId", "LogoImage", "Name", "SportId" },
                values: new object[,]
                {
                    { 20, "i", "p", "Thailand.png", "Thailand", "a" },
                    { 6, "o", "y", "Finland.png", "Finland", "s" },
                    { 23, "o", "s", "USA.png", "USA", "r" },
                    { 14, "o", "s", "Netherlands.png", "Netherlands", "r" },
                    { 2, "o", "s", "Brazil.png", "Brazil", "r" },
                    { 13, "i", "s", "Mexico.png", "Mexico", "d" },
                    { 8, "i", "s", "Germany.png", "Germany", "d" },
                    { 4, "i", "s", "China.png", "China", "d" },
                    { 19, "i", "w", "Sweden.png", "Sweden", "c" },
                    { 9, "i", "w", "Great Britain.png", "Great Britian", "c" },
                    { 3, "i", "w", "Canada.png", "Canada", "c" },
                    { 24, "o", "s", "Zimbabwe.png", "Zimbabwe", "cs" },
                    { 15, "o", "p", "Pakistan.png", "Pakistan", "cs" },
                    { 1, "o", "p", "Austria.png", "Austria", "cs" },
                    { 17, "i", "y", "Russia.png", "Russia", "bd" },
                    { 7, "i", "y", "France.png", "France", "bd" },
                    { 5, "i", "y", "Cyprus.png", "Cyrpus", "bd" },
                    { 12, "o", "w", "Japan.png", "Japan", "b" },
                    { 11, "o", "w", "Jamaica.png", "Jamaica", "b" },
                    { 10, "o", "w", "Italy.png", "Italy", "b" },
                    { 22, "i", "p", "Uruguay.png", "Uruguay", "a" },
                    { 21, "i", "p", "Ukraine.png", "Ukraine", "a" },
                    { 16, "o", "y", "Portugal.png", "Portugal", "s" },
                    { 18, "o", "y", "Slovakia.png", "Slovakia", "s" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryId",
                table: "Countries",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameId",
                table: "Countries",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportId",
                table: "Countries",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
