using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addingDrinkItemConfigAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22fe09dd-3166-45e7-951c-0daef0850bb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c839bc2a-580c-4bbd-836a-80ee65fcc870");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1fe466a2-b747-44e7-b0df-bd1f23dac257", "c054dbaa-2e9d-45a2-aec5-2af7282fde15", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b64310f3-f60d-443e-a0d3-6616e74006bc", "34990e20-e6a3-4599-88df-022bd3b474c5", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "ComboDrinkItems",
                columns: new[] { "ID", "ComboID", "ItemID", "TypeID" },
                values: new object[] { 1, 1, 4, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fe466a2-b747-44e7-b0df-bd1f23dac257");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b64310f3-f60d-443e-a0d3-6616e74006bc");

            migrationBuilder.DeleteData(
                table: "ComboDrinkItems",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c839bc2a-580c-4bbd-836a-80ee65fcc870", "979608e6-5171-4682-be40-368a16fb3ed8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22fe09dd-3166-45e7-951c-0daef0850bb8", "d8cb8f72-cabb-4f9b-b1f7-f501fb29421b", "Administrator", "ADMINISTRATOR" });
        }
    }
}
