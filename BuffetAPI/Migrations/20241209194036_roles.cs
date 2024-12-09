using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuffetAPI.Migrations
{
    /// <inheritdoc />
    public partial class roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
