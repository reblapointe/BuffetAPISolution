using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuffetAPI.Migrations
{
    /// <inheritdoc />
    public partial class platPrix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Prix",
                table: "Plat",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 1,
                column: "Prix",
                value: 2.25);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 2,
                column: "Prix",
                value: 2.25);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 3,
                column: "Prix",
                value: 2.25);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 4,
                column: "Prix",
                value: 2.25);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 5,
                column: "Prix",
                value: 2.25);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prix",
                table: "Plat");
        }
    }
}
