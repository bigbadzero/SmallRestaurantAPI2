using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addedCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05ff722a-c289-4331-8399-c739a1826386");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee34be4c-3900-4fb8-a361-a73963b7769c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab654a39-8d54-4144-b3ad-0f7b7acff6f0", "5bcb3f7f-5b2c-478e-a883-a307d0a4b823", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "260c178d-41a0-48be-a61e-334766658c98", "6401f980-38bb-44bf-b3d1-db0c1518c98e", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "260c178d-41a0-48be-a61e-334766658c98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab654a39-8d54-4144-b3ad-0f7b7acff6f0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05ff722a-c289-4331-8399-c739a1826386", "c37254d1-5920-44f0-b6ed-1a1734596791", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee34be4c-3900-4fb8-a361-a73963b7769c", "3caba356-d7c4-425c-9f05-80eb3352fa05", "Administrator", "ADMINISTRATOR" });
        }
    }
}
