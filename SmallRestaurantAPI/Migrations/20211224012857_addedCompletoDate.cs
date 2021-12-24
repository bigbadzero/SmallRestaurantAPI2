using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addedCompletoDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "684f84c8-a448-4f46-95dd-a76218913705");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a83bf280-c5df-4d19-bbfc-1f92b56c8eea");

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletionDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee6dbcbb-0926-4567-ae0e-bf32dd70686d", "a2fd1111-f881-426b-ac9e-db56d14fe17c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39a34cd1-e587-42fa-b557-031d6a977a17", "a956f4dd-a911-4c23-a1db-77da5046f14b", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39a34cd1-e587-42fa-b557-031d6a977a17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee6dbcbb-0926-4567-ae0e-bf32dd70686d");

            migrationBuilder.DropColumn(
                name: "CompletionDate",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "684f84c8-a448-4f46-95dd-a76218913705", "81af6149-5cd8-447f-b817-71973fd6b92a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a83bf280-c5df-4d19-bbfc-1f92b56c8eea", "e52bfb0a-64e5-4b76-b925-fd7e1ec1362d", "Administrator", "ADMINISTRATOR" });
        }
    }
}
