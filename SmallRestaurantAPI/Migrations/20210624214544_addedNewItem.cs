using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addedNewItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25949db7-acaa-47c5-87b8-71e2577eee73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a87feef-b664-4adb-8f4a-67c58b4fd959");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a5e3a3f-35ce-4624-8a5a-0454515fcb19", "e6f458a6-3123-468e-922e-1b7a050d44b2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb2002f5-6aa8-4396-aa92-4a6e2f4a27a1", "3b6c6182-d5f9-4951-9f1f-0b816c077c48", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "Description", "Name", "TypeID" },
                values: new object[] { 2, null, "Hamburger", 1 });

            migrationBuilder.InsertData(
                table: "ItemAvailableAddons",
                columns: new[] { "ID", "IngredientID", "ItemID" },
                values: new object[] { 2, 13, 2 });

            migrationBuilder.InsertData(
                table: "ItemBaseIngredients",
                columns: new[] { "ID", "IngredientID", "ItemID", "isRequired" },
                values: new object[,]
                {
                    { 8, 1, 2, true },
                    { 9, 2, 2, true },
                    { 10, 4, 2, false },
                    { 11, 5, 2, false },
                    { 12, 6, 2, false },
                    { 13, 7, 2, false }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "ID", "CategoryID", "ItemID" },
                values: new object[] { 3, 1, 2 });

            migrationBuilder.InsertData(
                table: "ItemSizes",
                columns: new[] { "ID", "ItemID", "SizeID" },
                values: new object[,]
                {
                    { 3, 2, 2 },
                    { 4, 2, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a5e3a3f-35ce-4624-8a5a-0454515fcb19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb2002f5-6aa8-4396-aa92-4a6e2f4a27a1");

            migrationBuilder.DeleteData(
                table: "ItemAvailableAddons",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemBaseIngredients",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemBaseIngredients",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemBaseIngredients",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemBaseIngredients",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ItemBaseIngredients",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ItemBaseIngredients",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemSizes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemSizes",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a87feef-b664-4adb-8f4a-67c58b4fd959", "e3c0f844-c4f6-4aef-86d2-f0fad18be56a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25949db7-acaa-47c5-87b8-71e2577eee73", "486901fd-8639-4a7f-b73d-024c18e810d0", "Administrator", "ADMINISTRATOR" });
        }
    }
}
