using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "750df7ed-eadb-4e68-8c44-8938b58ba352");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c339b5d3-d052-47c7-b1ed-b938141d4903");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d252013b-12c2-40a1-acc3-7e1a1003c743");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d252013b-12c2-40a1-acc3-7e1a1003c743", "574711d6-13d1-4280-943c-ccb04dea7856", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "750df7ed-eadb-4e68-8c44-8938b58ba352", "031daf1c-7485-44a5-9c12-580df34e0f78", "Servicer", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c339b5d3-d052-47c7-b1ed-b938141d4903", "525f6cfa-feef-42c2-bbaa-c3cb41a9437a", "Client", null });
        }
    }
}
