using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addedTestCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac00d236-f18d-47cf-a2c0-5548fd9965eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b207b8a9-7770-472d-ae0d-3411a6025f66");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a87feef-b664-4adb-8f4a-67c58b4fd959", "e3c0f844-c4f6-4aef-86d2-f0fad18be56a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25949db7-acaa-47c5-87b8-71e2577eee73", "486901fd-8639-4a7f-b73d-024c18e810d0", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[] { 4, "Test" });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "ID", "CategoryID", "ItemID" },
                values: new object[] { 2, 4, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25949db7-acaa-47c5-87b8-71e2577eee73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a87feef-b664-4adb-8f4a-67c58b4fd959");

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac00d236-f18d-47cf-a2c0-5548fd9965eb", "fcaefc6d-8e26-432e-8e89-701bd92e44f7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b207b8a9-7770-472d-ae0d-3411a6025f66", "b0a3bb10-8e07-4372-91f8-9da5c25f78f2", "Administrator", "ADMINISTRATOR" });
        }
    }
}
