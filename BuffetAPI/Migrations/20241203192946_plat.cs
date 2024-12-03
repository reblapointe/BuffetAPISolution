using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuffetAPI.Migrations
{
    /// <inheritdoc />
    public partial class plat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plat", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Plat",
                columns: new[] { "Id", "Nom" },
                values: new object[,]
                {
                    { 1, "Biscuit Double gingembre" },
                    { 2, "Biscuit Brisures de chocolat" },
                    { 3, "Biscuit Amaretti" },
                    { 4, "Biscuit S'mores au beurre noisette" },
                    { 5, "Biscuit Canneberges" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plat");
        }
    }
}
