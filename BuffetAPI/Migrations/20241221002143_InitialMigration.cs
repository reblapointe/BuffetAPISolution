using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuffetAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypePlats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePlats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: true),
                    Mange = table.Column<bool>(type: "bit", nullable: false),
                    TypePlatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plats_TypePlats_TypePlatId",
                        column: x => x.TypePlatId,
                        principalTable: "TypePlats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TypePlats",
                columns: new[] { "Id", "Nom" },
                values: new object[,]
                {
                    { 1, "Végétarien" },
                    { 2, "Carnivore" },
                    { 3, "Sucrerie" }
                });

            migrationBuilder.InsertData(
                table: "Plats",
                columns: new[] { "Id", "Mange", "Nom", "Prix", "TypePlatId" },
                values: new object[,]
                {
                    { 1, false, "Biscuit Double gingembre", 2.25, 3 },
                    { 2, false, "Biscuit Brisures de chocolat", 2.25, 3 },
                    { 3, false, "Biscuit Amaretti", 2.25, 3 },
                    { 4, false, "Biscuit S'mores au beurre noisette", 2.25, 3 },
                    { 5, false, "Biscuit Canneberges", 2.25, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plats_TypePlatId",
                table: "Plats",
                column: "TypePlatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plats");

            migrationBuilder.DropTable(
                name: "TypePlats");
        }
    }
}
