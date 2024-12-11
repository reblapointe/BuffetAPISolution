using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuffetAPI.Migrations
{
    /// <inheritdoc />
    public partial class PlatNomObligatoire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68139d9a-da24-4876-b441-c2788ee16d48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fb41309-af83-4723-a3f3-9620769561ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db6bbf2e-5a54-433b-8b1a-c3a68f0a4ded");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Plat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33f424c9-0b9c-4b9e-b908-22df70be66e7", null, "Ogre", "OGRE" },
                    { "d1f7021a-5e02-4454-9a1f-7dfb9505461e", null, "Cuisinier", "CUISINIER" },
                    { "e0b324de-6978-4d75-833f-abf5758b21ae", null, "Administrateurr", "ADMINISTRATEURR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33f424c9-0b9c-4b9e-b908-22df70be66e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f7021a-5e02-4454-9a1f-7dfb9505461e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0b324de-6978-4d75-833f-abf5758b21ae");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Plat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "68139d9a-da24-4876-b441-c2788ee16d48", null, "Cuisinier", "CUISINIER" },
                    { "8fb41309-af83-4723-a3f3-9620769561ef", null, "Ogre", "OGRE" },
                    { "db6bbf2e-5a54-433b-8b1a-c3a68f0a4ded", null, "Administrateurr", "ADMINISTRATEURR" }
                });
        }
    }
}
