using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0656a9e6-7a7b-41e7-aa4e-087f064d0e15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb0c05fc-dcdd-498b-9b4b-a7e9a6ae9517");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdd5668f-bde2-4cd7-9029-48cb924132f2");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0656a9e6-7a7b-41e7-aa4e-087f064d0e15", "e72daa64-52a1-490c-939f-f5995d59e779", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdd5668f-bde2-4cd7-9029-48cb924132f2", "f0e37ee7-4c66-46d3-92ee-76415852801d", "Servicer", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb0c05fc-dcdd-498b-9b4b-a7e9a6ae9517", "6e209ddf-583a-4a07-ae9a-5e2e02f5ca29", "Client", null });
        }
    }
}
