using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UILib.MigrationService.Migrations
{
    /// <inheritdoc />
    public partial class _20260315b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeRowTypeId",
                table: "HomeRows",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HomeRowTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeRowTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HomeRowTypes",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "Hello World" });

            migrationBuilder.UpdateData(
                table: "HomeRows",
                keyColumn: "Id",
                keyValue: 1,
                column: "HomeRowTypeId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_HomeRows_HomeRowTypeId",
                table: "HomeRows",
                column: "HomeRowTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeRows_HomeRowTypes_HomeRowTypeId",
                table: "HomeRows",
                column: "HomeRowTypeId",
                principalTable: "HomeRowTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeRows_HomeRowTypes_HomeRowTypeId",
                table: "HomeRows");

            migrationBuilder.DropTable(
                name: "HomeRowTypes");

            migrationBuilder.DropIndex(
                name: "IX_HomeRows_HomeRowTypeId",
                table: "HomeRows");

            migrationBuilder.DropColumn(
                name: "HomeRowTypeId",
                table: "HomeRows");
        }
    }
}
