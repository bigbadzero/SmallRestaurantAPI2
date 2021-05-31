using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addedSideAddons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SideAddons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SideID = table.Column<int>(type: "int", nullable: false),
                    Ingredient1ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient2ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient3ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient4ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient5ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideAddons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SideAddons_Ingredients_Ingredient1ID",
                        column: x => x.Ingredient1ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SideAddons_Ingredients_Ingredient2ID",
                        column: x => x.Ingredient2ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SideAddons_Ingredients_Ingredient3ID",
                        column: x => x.Ingredient3ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SideAddons_Ingredients_Ingredient4ID",
                        column: x => x.Ingredient4ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SideAddons_Ingredients_Ingredient5ID",
                        column: x => x.Ingredient5ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SideAddons_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SideAddons_Ingredient5ID",
                table: "SideAddons",
                column: "Ingredient5ID");

            migrationBuilder.CreateIndex(
                name: "IX_SideAddons_SideID",
                table: "SideAddons",
                column: "SideID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SideAddons");
        }
    }
}
