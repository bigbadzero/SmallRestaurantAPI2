using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class hopefullyResolvedError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SideMenuItemID",
                table: "Combos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Combos_SideMenuItemID",
                table: "Combos",
                column: "SideMenuItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_MenuItems_SideMenuItemID",
                table: "Combos",
                column: "SideMenuItemID",
                principalTable: "MenuItems",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Combos_MenuItems_SideMenuItemID",
                table: "Combos");

            migrationBuilder.DropIndex(
                name: "IX_Combos_SideMenuItemID",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "SideMenuItemID",
                table: "Combos");
        }
    }
}
