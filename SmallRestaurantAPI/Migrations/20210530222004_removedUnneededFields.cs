using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class removedUnneededFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Categories_CategoryID",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_CategoryID",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_CategoryID",
                table: "Ingredients",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Categories_CategoryID",
                table: "Ingredients",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
