using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class ChangingRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Combos_ComboID",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Drinks_DrinkID",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_SelectedEntrees_SelectedEntreeID",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Sides_SideID",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_ComboID",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_DrinkID",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_SelectedEntreeID",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_SideID",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e0770f8-158b-43ac-a5a1-1074c40d5e09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "951de9ef-ad46-4620-a510-54e7122f1131");

            migrationBuilder.DropColumn(
                name: "ComboID",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "DrinkID",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "SelectedEntreeID",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "SideID",
                table: "CartItems");

            migrationBuilder.AddColumn<int>(
                name: "CartItemID",
                table: "SelectedEntrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bff0598-5794-4d33-ac96-9d19db4b96af", "abb4ea63-0bc6-47c1-9504-d999ee8dff6d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44557437-f1d9-46cc-8554-44776e5b7be6", "73448004-1396-4abf-858c-b7108cead68d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntrees_CartItemID",
                table: "SelectedEntrees",
                column: "CartItemID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_UserID",
                table: "CartItems",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_AspNetUsers_UserID",
                table: "CartItems",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SelectedEntrees_CartItems_CartItemID",
                table: "SelectedEntrees",
                column: "CartItemID",
                principalTable: "CartItems",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_AspNetUsers_UserID",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SelectedEntrees_CartItems_CartItemID",
                table: "SelectedEntrees");

            migrationBuilder.DropIndex(
                name: "IX_SelectedEntrees_CartItemID",
                table: "SelectedEntrees");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_UserID",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44557437-f1d9-46cc-8554-44776e5b7be6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bff0598-5794-4d33-ac96-9d19db4b96af");

            migrationBuilder.DropColumn(
                name: "CartItemID",
                table: "SelectedEntrees");

            migrationBuilder.AddColumn<int>(
                name: "ComboID",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DrinkID",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SelectedEntreeID",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SideID",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e0770f8-158b-43ac-a5a1-1074c40d5e09", "d9981068-74af-4384-8a34-83329141e4b1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "951de9ef-ad46-4620-a510-54e7122f1131", "5cf2949e-16db-4b9e-b3c0-cfa7cc70a448", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ComboID",
                table: "CartItems",
                column: "ComboID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_DrinkID",
                table: "CartItems",
                column: "DrinkID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_SelectedEntreeID",
                table: "CartItems",
                column: "SelectedEntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_SideID",
                table: "CartItems",
                column: "SideID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Combos_ComboID",
                table: "CartItems",
                column: "ComboID",
                principalTable: "Combos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Drinks_DrinkID",
                table: "CartItems",
                column: "DrinkID",
                principalTable: "Drinks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_SelectedEntrees_SelectedEntreeID",
                table: "CartItems",
                column: "SelectedEntreeID",
                principalTable: "SelectedEntrees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Sides_SideID",
                table: "CartItems",
                column: "SideID",
                principalTable: "Sides",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
