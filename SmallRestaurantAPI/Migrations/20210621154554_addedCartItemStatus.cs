using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addedCartItemStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44557437-f1d9-46cc-8554-44776e5b7be6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bff0598-5794-4d33-ac96-9d19db4b96af");

            migrationBuilder.AddColumn<int>(
                name: "CartItemStatusID",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CartItemStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItemStatuses", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e0a6baab-48e8-4f5f-84c2-6d4a39a7bf15", "27d5abf9-484b-4506-9590-140149d91664", "User", "USER" },
                    { "a41e4665-c1a2-4b41-abb3-db99e0c13e4a", "9870279c-9cae-40e8-a705-fe4e75ccd68b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "CartItemStatuses",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Ordering" },
                    { 2, "Order Processing" },
                    { 3, "Order Ready" },
                    { 4, "Order Complete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartItemStatusID",
                table: "CartItems",
                column: "CartItemStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_CartItemStatuses_CartItemStatusID",
                table: "CartItems",
                column: "CartItemStatusID",
                principalTable: "CartItemStatuses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_CartItemStatuses_CartItemStatusID",
                table: "CartItems");

            migrationBuilder.DropTable(
                name: "CartItemStatuses");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_CartItemStatusID",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a41e4665-c1a2-4b41-abb3-db99e0c13e4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0a6baab-48e8-4f5f-84c2-6d4a39a7bf15");

            migrationBuilder.DropColumn(
                name: "CartItemStatusID",
                table: "CartItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bff0598-5794-4d33-ac96-9d19db4b96af", "abb4ea63-0bc6-47c1-9504-d999ee8dff6d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44557437-f1d9-46cc-8554-44776e5b7be6", "73448004-1396-4abf-858c-b7108cead68d", "Administrator", "ADMINISTRATOR" });
        }
    }
}
