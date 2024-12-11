using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuffetAPI.Migrations
{
    /// <inheritdoc />
    public partial class platCuisinier : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "CuisinierId",
                table: "Plat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ffa7240-5004-40eb-aa9e-f992ca9b9763", null, "Ogre", "OGRE" },
                    { "6a1bf8a7-f938-4b1e-bf35-244a8d67e0a4", null, "Cuisinier", "CUISINIER" },
                    { "b90fb4d6-4e2e-42ea-8e1f-e911a4805a44", null, "Administrateurr", "ADMINISTRATEURR" }
                });

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 1,
                column: "CuisinierId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 2,
                column: "CuisinierId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 3,
                column: "CuisinierId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 4,
                column: "CuisinierId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 5,
                column: "CuisinierId",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ffa7240-5004-40eb-aa9e-f992ca9b9763");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a1bf8a7-f938-4b1e-bf35-244a8d67e0a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b90fb4d6-4e2e-42ea-8e1f-e911a4805a44");

            migrationBuilder.DropColumn(
                name: "CuisinierId",
                table: "Plat");

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
