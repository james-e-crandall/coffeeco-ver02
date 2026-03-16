using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UILib.MigrationService.Migrations
{
    /// <inheritdoc />
    public partial class _2003155a2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HomeItemTypeId",
                table: "HomeItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "HomeItemTypes",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "Hello World" });

            migrationBuilder.UpdateData(
                table: "HomeItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "HomeItemTypeId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_HomeItems_HomeItemTypeId",
                table: "HomeItems",
                column: "HomeItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeItems_HomeItemTypes_HomeItemTypeId",
                table: "HomeItems",
                column: "HomeItemTypeId",
                principalTable: "HomeItemTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeItems_HomeItemTypes_HomeItemTypeId",
                table: "HomeItems");

            migrationBuilder.DropIndex(
                name: "IX_HomeItems_HomeItemTypeId",
                table: "HomeItems");

            migrationBuilder.DeleteData(
                table: "HomeItemTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "HomeItemTypeId",
                table: "HomeItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "HomeItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "HomeItemTypeId",
                value: 0);
        }
    }
}
