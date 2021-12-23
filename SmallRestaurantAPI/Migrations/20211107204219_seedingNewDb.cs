using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class seedingNewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fe466a2-b747-44e7-b0df-bd1f23dac257");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b64310f3-f60d-443e-a0d3-6616e74006bc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fea52c5-50cf-4813-bfab-9414b9ca75f3", "cf99ac69-9059-4efc-bcb0-21b996e85fa0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7f8bc03-8b28-40b7-83d8-e4026b5ffb61", "3afd12ad-835e-4701-9818-f014c242f119", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fea52c5-50cf-4813-bfab-9414b9ca75f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7f8bc03-8b28-40b7-83d8-e4026b5ffb61");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1fe466a2-b747-44e7-b0df-bd1f23dac257", "c054dbaa-2e9d-45a2-aec5-2af7282fde15", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b64310f3-f60d-443e-a0d3-6616e74006bc", "34990e20-e6a3-4599-88df-022bd3b474c5", "Administrator", "ADMINISTRATOR" });
        }
    }
}
