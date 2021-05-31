using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class modifiedCombo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Drinks_DrinkID",
                table: "Combos");

            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Ingredients_Condiment1ID",
                table: "Combos");

            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Ingredients_Condiment2ID",
                table: "Combos");

            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Ingredients_Condiment3ID",
                table: "Combos");

            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Sides_SideID",
                table: "Combos");

            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Sizes_SizeID",
                table: "Combos");

            migrationBuilder.DropIndex(
                name: "IX_Combos_Condiment1ID",
                table: "Combos");

            migrationBuilder.DropIndex(
                name: "IX_Combos_Condiment2ID",
                table: "Combos");

            migrationBuilder.DropIndex(
                name: "IX_Combos_Condiment3ID",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "Condiment1ID",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "Condiment2ID",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "Condiment3ID",
                table: "Combos");

            migrationBuilder.AlterColumn<int>(
                name: "SizeID",
                table: "Combos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SideID",
                table: "Combos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DrinkID",
                table: "Combos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Drinks_DrinkID",
                table: "Combos",
                column: "DrinkID",
                principalTable: "Drinks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Sides_SideID",
                table: "Combos",
                column: "SideID",
                principalTable: "Sides",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Sizes_SizeID",
                table: "Combos",
                column: "SizeID",
                principalTable: "Sizes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Drinks_DrinkID",
                table: "Combos");

            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Sides_SideID",
                table: "Combos");

            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Sizes_SizeID",
                table: "Combos");

            migrationBuilder.AlterColumn<int>(
                name: "SizeID",
                table: "Combos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SideID",
                table: "Combos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DrinkID",
                table: "Combos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Condiment1ID",
                table: "Combos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Condiment2ID",
                table: "Combos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Condiment3ID",
                table: "Combos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Combos_Condiment1ID",
                table: "Combos",
                column: "Condiment1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_Condiment2ID",
                table: "Combos",
                column: "Condiment2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_Condiment3ID",
                table: "Combos",
                column: "Condiment3ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Drinks_DrinkID",
                table: "Combos",
                column: "DrinkID",
                principalTable: "Drinks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Ingredients_Condiment1ID",
                table: "Combos",
                column: "Condiment1ID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Ingredients_Condiment2ID",
                table: "Combos",
                column: "Condiment2ID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Ingredients_Condiment3ID",
                table: "Combos",
                column: "Condiment3ID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Sides_SideID",
                table: "Combos",
                column: "SideID",
                principalTable: "Sides",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Sizes_SizeID",
                table: "Combos",
                column: "SizeID",
                principalTable: "Sizes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
