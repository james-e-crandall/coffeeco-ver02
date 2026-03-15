using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UILib.MigrationService.Migrations
{
    /// <inheritdoc />
    public partial class _20260314 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeRows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeRows_HomeLists_HomeListId",
                        column: x => x.HomeListId,
                        principalTable: "HomeLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuGroup_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeRowId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeItems_HomeRows_HomeRowId",
                        column: x => x.HomeRowId,
                        principalTable: "HomeRows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuSubGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuSubGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuSubGroup_MenuGroup_MenuGroupId",
                        column: x => x.MenuGroupId,
                        principalTable: "MenuGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MenuSubGroupId = table.Column<int>(type: "int", nullable: false),
                    CoffeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItem_MenuSubGroup_MenuSubGroupId",
                        column: x => x.MenuSubGroupId,
                        principalTable: "MenuSubGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HomeLists",
                columns: new[] { "Id", "Active", "Created", "StartDate", "Updated" },
                values: new object[] { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Menu Hello World" });

            migrationBuilder.InsertData(
                table: "HomeRows",
                columns: new[] { "Id", "HomeListId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "MenuGroup",
                columns: new[] { "Id", "MenuId", "Name" },
                values: new object[] { 1, 1, "MenuGroup Hello World" });

            migrationBuilder.InsertData(
                table: "HomeItems",
                columns: new[] { "Id", "HomeRowId", "Text" },
                values: new object[] { 1, 1, "Hello World" });

            migrationBuilder.InsertData(
                table: "MenuSubGroup",
                columns: new[] { "Id", "MenuGroupId", "Name" },
                values: new object[] { 1, 1, "MenuSubGroup" });

            migrationBuilder.CreateIndex(
                name: "IX_HomeItems_HomeRowId",
                table: "HomeItems",
                column: "HomeRowId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeRows_HomeListId",
                table: "HomeRows",
                column: "HomeListId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuGroup_MenuId",
                table: "MenuGroup",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_MenuSubGroupId",
                table: "MenuItem",
                column: "MenuSubGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuSubGroup_MenuGroupId",
                table: "MenuSubGroup",
                column: "MenuGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeItems");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "HomeRows");

            migrationBuilder.DropTable(
                name: "MenuSubGroup");

            migrationBuilder.DropTable(
                name: "HomeLists");

            migrationBuilder.DropTable(
                name: "MenuGroup");

            migrationBuilder.DropTable(
                name: "Menu");
        }
    }
}
