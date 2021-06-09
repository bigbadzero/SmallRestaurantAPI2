using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class changedFieds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_ApiUserID",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03059a28-4a8a-47c5-95ae-dc3040c05a2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8af070f-b6a7-4a44-bfe9-3d9f62136bd8");

            migrationBuilder.RenameColumn(
                name: "ApiUserID",
                table: "Carts",
                newName: "UserName");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_ApiUserID",
                table: "Carts",
                newName: "IX_Carts_UserName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e25dcd40-519d-4f37-9562-6fd547391775", "1e444c0e-e6f3-4ead-99a4-c9b5186e49e9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6400ef66-c7d0-48b7-a982-d9f2306bd1ed", "512382e1-667a-4b72-b46e-65f7201e498f", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserName",
                table: "Carts",
                column: "UserName",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserName",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6400ef66-c7d0-48b7-a982-d9f2306bd1ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e25dcd40-519d-4f37-9562-6fd547391775");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Carts",
                newName: "ApiUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserName",
                table: "Carts",
                newName: "IX_Carts_ApiUserID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03059a28-4a8a-47c5-95ae-dc3040c05a2d", "f8544e36-6421-49be-8626-d6966d8e2ff4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8af070f-b6a7-4a44-bfe9-3d9f62136bd8", "d78c0d20-80ba-4980-a3c5-dc7cd4be521e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_ApiUserID",
                table: "Carts",
                column: "ApiUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
