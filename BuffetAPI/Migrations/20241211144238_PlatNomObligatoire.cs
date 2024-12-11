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
                keyValue: "af3ac565-20c8-4cfe-b6dd-4edd7b6399d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce4e3585-840b-4a17-944b-10b55b6ec83e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6a6d8b7-c8dd-4df5-9f4a-38bc3c244df9");

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
                    { "003f9d13-ce3b-434c-bad0-b9de43e8f9fd", null, "Cuisinier", "CUISINIER" },
                    { "378785fe-17d9-438b-8839-1b289a520718", null, "Administrateur", "ADMINISTRATEUR" },
                    { "409440de-81bf-49b5-98e1-4dda0c6f1143", null, "Ogre", "OGRE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "003f9d13-ce3b-434c-bad0-b9de43e8f9fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "378785fe-17d9-438b-8839-1b289a520718");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409440de-81bf-49b5-98e1-4dda0c6f1143");

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
                    { "af3ac565-20c8-4cfe-b6dd-4edd7b6399d1", null, "Cuisinier", "CUISINIER" },
                    { "ce4e3585-840b-4a17-944b-10b55b6ec83e", null, "Administrateur", "ADMINISTRATEUR" },
                    { "f6a6d8b7-c8dd-4df5-9f4a-38bc3c244df9", null, "Ogre", "OGRE" }
                });
        }
    }
}
