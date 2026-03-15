using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UILib.MigrationService.Migrations
{
    /// <inheritdoc />
    public partial class _2026015 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeItemTypeId",
                table: "HomeItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "HomeItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "HomeItemTypeId",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeItemTypeId",
                table: "HomeItems");
        }
    }
}
