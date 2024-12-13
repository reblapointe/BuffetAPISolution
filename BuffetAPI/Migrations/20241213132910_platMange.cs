using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuffetAPI.Migrations
{
    /// <inheritdoc />
    public partial class PlatMange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Mange",
                table: "Plat",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 1,
                column: "Mange",
                value: false);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 2,
                column: "Mange",
                value: false);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 3,
                column: "Mange",
                value: false);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 4,
                column: "Mange",
                value: false);

            migrationBuilder.UpdateData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 5,
                column: "Mange",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mange",
                table: "Plat");
        }
    }
}
