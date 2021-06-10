using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "214d702a-a0ac-467a-9f5a-c66c6dcd4da1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21777d84-625c-49cf-a610-1facff1f55d5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e0770f8-158b-43ac-a5a1-1074c40d5e09", "d9981068-74af-4384-8a34-83329141e4b1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "951de9ef-ad46-4620-a510-54e7122f1131", "5cf2949e-16db-4b9e-b3c0-cfa7cc70a448", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e0770f8-158b-43ac-a5a1-1074c40d5e09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "951de9ef-ad46-4620-a510-54e7122f1131");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "214d702a-a0ac-467a-9f5a-c66c6dcd4da1", "30448616-fe3d-41a4-893b-367cdb11584c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "21777d84-625c-49cf-a610-1facff1f55d5", "fc6bc6bf-0789-4292-9f8f-d667f7ce98f5", "Administrator", "ADMINISTRATOR" });
        }
    }
}
