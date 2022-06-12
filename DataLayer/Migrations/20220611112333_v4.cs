using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_AspNetUsers_UserId1",
                table: "Forms");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2434ab00-136f-49d4-a467-bad65e2fa263");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9635b59-c7a1-461d-aba2-d3644df5a56f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b15666e7-a42a-427b-b00f-0c32372180bb");

            migrationBuilder.DropColumn(
                name: "Master",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Forms");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Forms",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Forms_UserId1",
                table: "Forms",
                newName: "IX_Forms_OwnerId");

            migrationBuilder.CreateTable(
                name: "FormElements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormElements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormUser",
                columns: table => new
                {
                    PassedFormsId = table.Column<int>(type: "int", nullable: false),
                    ResponersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormUser", x => new { x.PassedFormsId, x.ResponersId });
                    table.ForeignKey(
                        name: "FK_FormUser_AspNetUsers_ResponersId",
                        column: x => x.ResponersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormUser_Forms_PassedFormsId",
                        column: x => x.PassedFormsId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormFormElement",
                columns: table => new
                {
                    ElementsId = table.Column<int>(type: "int", nullable: false),
                    FormsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFormElement", x => new { x.ElementsId, x.FormsId });
                    table.ForeignKey(
                        name: "FK_FormFormElement_FormElements_ElementsId",
                        column: x => x.ElementsId,
                        principalTable: "FormElements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormFormElement_Forms_FormsId",
                        column: x => x.FormsId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "123b8a51-7c0f-4c39-a356-bda592459271", "c37386cf-92ad-46c5-80dc-c335fb637c36", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a5a0a69-7ec5-4d4c-bce8-6c3cfeeb9c4d", "7e249256-cca9-4740-9eb4-e1f6b8bafd58", "Servicer", "SERVICER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eedd9fb1-b7cc-41a2-a9a1-7534d9d7ad1a", "1fd0d856-2365-4b48-9f41-2109f00a6adb", "Client", "CLIENT" });

            migrationBuilder.CreateIndex(
                name: "IX_FormFormElement_FormsId",
                table: "FormFormElement",
                column: "FormsId");

            migrationBuilder.CreateIndex(
                name: "IX_FormUser_ResponersId",
                table: "FormUser",
                column: "ResponersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_AspNetUsers_OwnerId",
                table: "Forms",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_AspNetUsers_OwnerId",
                table: "Forms");

            migrationBuilder.DropTable(
                name: "FormFormElement");

            migrationBuilder.DropTable(
                name: "FormUser");

            migrationBuilder.DropTable(
                name: "FormElements");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "123b8a51-7c0f-4c39-a356-bda592459271");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a5a0a69-7ec5-4d4c-bce8-6c3cfeeb9c4d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eedd9fb1-b7cc-41a2-a9a1-7534d9d7ad1a");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Forms",
                newName: "UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Forms_OwnerId",
                table: "Forms",
                newName: "IX_Forms_UserId1");

            migrationBuilder.AddColumn<string>(
                name: "Master",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Forms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9635b59-c7a1-461d-aba2-d3644df5a56f", "7dbd08e2-b099-4e5e-88c7-f378f3926824", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2434ab00-136f-49d4-a467-bad65e2fa263", "e1522af2-fd1c-4b7f-9dcf-84dc0c1e0405", "Servicer", "SERVICER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b15666e7-a42a-427b-b00f-0c32372180bb", "0d9d3fe7-ce81-4247-8743-2684fca1988c", "Client", "CLIENT" });

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_AspNetUsers_UserId1",
                table: "Forms",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
