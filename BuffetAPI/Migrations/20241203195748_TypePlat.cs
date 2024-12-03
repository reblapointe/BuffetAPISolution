using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuffetAPI.Migrations
{
    /// <inheritdoc />
    public partial class TypePlat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypePlatId",
                table: "Plat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TypePlat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePlat", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 1,
                column: "TypePlatId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 2,
                column: "TypePlatId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 3,
                column: "TypePlatId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 4,
                column: "TypePlatId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 5,
                column: "TypePlatId",
                value: 3);

            migrationBuilder.InsertData(
                table: "TypePlat",
                columns: new[] { "Id", "Nom" },
                values: new object[,]
                {
                    { 1, "Végétarien" },
                    { 2, "Carnivore" },
                    { 3, "Sucrerie" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plat_TypePlatId",
                table: "Plat",
                column: "TypePlatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plat_TypePlat_TypePlatId",
                table: "Plat",
                column: "TypePlatId",
                principalTable: "TypePlat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plat_TypePlat_TypePlatId",
                table: "Plat");

            migrationBuilder.DropTable(
                name: "TypePlat");

            migrationBuilder.DropIndex(
                name: "IX_Plat_TypePlatId",
                table: "Plat");

            migrationBuilder.DropColumn(
                name: "TypePlatId",
                table: "Plat");
        }
    }
}
