using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addedCartItemStatusWithKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a41e4665-c1a2-4b41-abb3-db99e0c13e4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0a6baab-48e8-4f5f-84c2-6d4a39a7bf15");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8508c1ea-3251-4222-ae84-ba6497d7c809", "c97a1793-5855-4cbe-85a2-658b89c4ff0f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4aa636b4-4c37-40da-ba31-00119296d9c9", "92b632eb-f9ff-4878-ac8c-5b8b7b5b4dfb", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aa636b4-4c37-40da-ba31-00119296d9c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8508c1ea-3251-4222-ae84-ba6497d7c809");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0a6baab-48e8-4f5f-84c2-6d4a39a7bf15", "27d5abf9-484b-4506-9590-140149d91664", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a41e4665-c1a2-4b41-abb3-db99e0c13e4a", "9870279c-9cae-40e8-a705-fe4e75ccd68b", "Administrator", "ADMINISTRATOR" });
        }
    }
}
