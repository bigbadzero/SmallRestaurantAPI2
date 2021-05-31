using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class modifiedSideAddon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SideAddons_Ingredients_Ingredient1ID",
                table: "SideAddons");

            migrationBuilder.DropForeignKey(
                name: "FK_SideAddons_Ingredients_Ingredient2ID",
                table: "SideAddons");

            migrationBuilder.DropForeignKey(
                name: "FK_SideAddons_Ingredients_Ingredient3ID",
                table: "SideAddons");

            migrationBuilder.DropForeignKey(
                name: "FK_SideAddons_Ingredients_Ingredient4ID",
                table: "SideAddons");

            migrationBuilder.DropForeignKey(
                name: "FK_SideAddons_Ingredients_Ingredient5ID",
                table: "SideAddons");

            migrationBuilder.DropIndex(
                name: "IX_SideAddons_Ingredient1ID",
                table: "SideAddons");

            migrationBuilder.DropIndex(
                name: "IX_SideAddons_Ingredient2ID",
                table: "SideAddons");

            migrationBuilder.DropIndex(
                name: "IX_SideAddons_Ingredient3ID",
                table: "SideAddons");

            migrationBuilder.DropIndex(
                name: "IX_SideAddons_Ingredient4ID",
                table: "SideAddons");

            migrationBuilder.DropColumn(
                name: "Ingredient1ID",
                table: "SideAddons");

            migrationBuilder.DropColumn(
                name: "Ingredient2ID",
                table: "SideAddons");

            migrationBuilder.DropColumn(
                name: "Ingredient3ID",
                table: "SideAddons");

            migrationBuilder.DropColumn(
                name: "Ingredient4ID",
                table: "SideAddons");

            migrationBuilder.RenameColumn(
                name: "Ingredient5ID",
                table: "SideAddons",
                newName: "IngredientID");

            migrationBuilder.RenameIndex(
                name: "IX_SideAddons_Ingredient5ID",
                table: "SideAddons",
                newName: "IX_SideAddons_IngredientID");

            migrationBuilder.AddForeignKey(
                name: "FK_SideAddons_Ingredients_IngredientID",
                table: "SideAddons",
                column: "IngredientID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SideAddons_Ingredients_IngredientID",
                table: "SideAddons");

            migrationBuilder.RenameColumn(
                name: "IngredientID",
                table: "SideAddons",
                newName: "Ingredient5ID");

            migrationBuilder.RenameIndex(
                name: "IX_SideAddons_IngredientID",
                table: "SideAddons",
                newName: "IX_SideAddons_Ingredient5ID");

            migrationBuilder.AddColumn<int>(
                name: "Ingredient1ID",
                table: "SideAddons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ingredient2ID",
                table: "SideAddons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ingredient3ID",
                table: "SideAddons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ingredient4ID",
                table: "SideAddons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SideAddons_Ingredient1ID",
                table: "SideAddons",
                column: "Ingredient1ID");

            migrationBuilder.CreateIndex(
                name: "IX_SideAddons_Ingredient2ID",
                table: "SideAddons",
                column: "Ingredient2ID");

            migrationBuilder.CreateIndex(
                name: "IX_SideAddons_Ingredient3ID",
                table: "SideAddons",
                column: "Ingredient3ID");

            migrationBuilder.CreateIndex(
                name: "IX_SideAddons_Ingredient4ID",
                table: "SideAddons",
                column: "Ingredient4ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SideAddons_Ingredients_Ingredient1ID",
                table: "SideAddons",
                column: "Ingredient1ID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SideAddons_Ingredients_Ingredient2ID",
                table: "SideAddons",
                column: "Ingredient2ID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SideAddons_Ingredients_Ingredient3ID",
                table: "SideAddons",
                column: "Ingredient3ID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SideAddons_Ingredients_Ingredient4ID",
                table: "SideAddons",
                column: "Ingredient4ID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SideAddons_Ingredients_Ingredient5ID",
                table: "SideAddons",
                column: "Ingredient5ID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
