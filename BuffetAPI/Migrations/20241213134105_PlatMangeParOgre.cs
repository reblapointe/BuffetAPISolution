using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuffetAPI.Migrations
{
    /// <inheritdoc />
    public partial class PlatMangeParOgre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Mange",
                table: "Plat",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OgreId",
                table: "Plat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ff40d0f-2cc2-4c0c-8176-08ac29fb4148", null, "Cuisinier", "CUISINIER" },
                    { "b188aca5-b612-4521-8ec0-3e5be97ba604", null, "Administrateur", "ADMINISTRATEUR" },
                    { "f0d3a57f-c330-48b1-9941-6d791e5eb12e", null, "Ogre", "OGRE" }
                });

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Mange", "OgreId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Mange", "OgreId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Mange", "OgreId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Mange", "OgreId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Mange", "OgreId" },
                values: new object[] { false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ff40d0f-2cc2-4c0c-8176-08ac29fb4148");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b188aca5-b612-4521-8ec0-3e5be97ba604");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0d3a57f-c330-48b1-9941-6d791e5eb12e");

            migrationBuilder.DropColumn(
                name: "Mange",
                table: "Plat");

            migrationBuilder.DropColumn(
                name: "OgreId",
                table: "Plat");

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
    }
}
