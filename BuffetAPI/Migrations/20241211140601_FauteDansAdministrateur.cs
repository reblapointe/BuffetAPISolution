using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuffetAPI.Migrations
{
    /// <inheritdoc />
    public partial class FauteDansAdministrateur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "af3ac565-20c8-4cfe-b6dd-4edd7b6399d1", null, "Cuisinier", "CUISINIER" },
                    { "ce4e3585-840b-4a17-944b-10b55b6ec83e", null, "Administrateur", "ADMINISTRATEUR" },
                    { "f6a6d8b7-c8dd-4df5-9f4a-38bc3c244df9", null, "Ogre", "OGRE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af3ac565-20c8-4cfe-b6dd-4edd7b6399d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce4e3585-840b-4a17-944b-10b55b6ec83e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6a6d8b7-c8dd-4df5-9f4a-38bc3c244df9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ffa7240-5004-40eb-aa9e-f992ca9b9763", null, "Ogre", "OGRE" },
                    { "6a1bf8a7-f938-4b1e-bf35-244a8d67e0a4", null, "Cuisinier", "CUISINIER" },
                    { "b90fb4d6-4e2e-42ea-8e1f-e911a4805a44", null, "Administrateurr", "ADMINISTRATEURR" }
                });
        }
    }
}
