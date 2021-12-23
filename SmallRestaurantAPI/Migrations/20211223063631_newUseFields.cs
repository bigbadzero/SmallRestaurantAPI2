using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class newUseFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fea52c5-50cf-4813-bfab-9414b9ca75f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7f8bc03-8b28-40b7-83d8-e4026b5ffb61");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Question1",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Question2",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Question3",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "684f84c8-a448-4f46-95dd-a76218913705", "81af6149-5cd8-447f-b817-71973fd6b92a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a83bf280-c5df-4d19-bbfc-1f92b56c8eea", "e52bfb0a-64e5-4b76-b925-fd7e1ec1362d", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "684f84c8-a448-4f46-95dd-a76218913705");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a83bf280-c5df-4d19-bbfc-1f92b56c8eea");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Question1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Question2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Question3",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fea52c5-50cf-4813-bfab-9414b9ca75f3", "cf99ac69-9059-4efc-bcb0-21b996e85fa0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7f8bc03-8b28-40b7-83d8-e4026b5ffb61", "3afd12ad-835e-4701-9818-f014c242f119", "Administrator", "ADMINISTRATOR" });
        }
    }
}
