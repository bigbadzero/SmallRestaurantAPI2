using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addedEntreeAndSideAddons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntreeAddons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntreeID = table.Column<int>(type: "int", nullable: false),
                    Ingredient1ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient2ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient3ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient4ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient5ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient6ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient7ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient8ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient9ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient10ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient11ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient12ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient13ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient14ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient15ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient16ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient17ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient18ID = table.Column<int>(type: "int", nullable: true),
                    Ingredient19ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntreeAddons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Entrees_EntreeID",
                        column: x => x.EntreeID,
                        principalTable: "Entrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient10ID",
                        column: x => x.Ingredient10ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient11ID",
                        column: x => x.Ingredient11ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient12ID",
                        column: x => x.Ingredient12ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient13ID",
                        column: x => x.Ingredient13ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient14ID",
                        column: x => x.Ingredient14ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient15ID",
                        column: x => x.Ingredient15ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient16ID",
                        column: x => x.Ingredient16ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient17ID",
                        column: x => x.Ingredient17ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient18ID",
                        column: x => x.Ingredient18ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient19ID",
                        column: x => x.Ingredient19ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient1ID",
                        column: x => x.Ingredient1ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient2ID",
                        column: x => x.Ingredient2ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient3ID",
                        column: x => x.Ingredient3ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient4ID",
                        column: x => x.Ingredient4ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient5ID",
                        column: x => x.Ingredient5ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient6ID",
                        column: x => x.Ingredient6ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient7ID",
                        column: x => x.Ingredient7ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient8ID",
                        column: x => x.Ingredient8ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntreeAddons_Ingredients_Ingredient9ID",
                        column: x => x.Ingredient9ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_EntreeID",
                table: "EntreeAddons",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient10ID",
                table: "EntreeAddons",
                column: "Ingredient10ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient11ID",
                table: "EntreeAddons",
                column: "Ingredient11ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient12ID",
                table: "EntreeAddons",
                column: "Ingredient12ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient13ID",
                table: "EntreeAddons",
                column: "Ingredient13ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient14ID",
                table: "EntreeAddons",
                column: "Ingredient14ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient15ID",
                table: "EntreeAddons",
                column: "Ingredient15ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient16ID",
                table: "EntreeAddons",
                column: "Ingredient16ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient17ID",
                table: "EntreeAddons",
                column: "Ingredient17ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient18ID",
                table: "EntreeAddons",
                column: "Ingredient18ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient19ID",
                table: "EntreeAddons",
                column: "Ingredient19ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient1ID",
                table: "EntreeAddons",
                column: "Ingredient1ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient2ID",
                table: "EntreeAddons",
                column: "Ingredient2ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient3ID",
                table: "EntreeAddons",
                column: "Ingredient3ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient4ID",
                table: "EntreeAddons",
                column: "Ingredient4ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient5ID",
                table: "EntreeAddons",
                column: "Ingredient5ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient6ID",
                table: "EntreeAddons",
                column: "Ingredient6ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient7ID",
                table: "EntreeAddons",
                column: "Ingredient7ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient8ID",
                table: "EntreeAddons",
                column: "Ingredient8ID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_Ingredient9ID",
                table: "EntreeAddons",
                column: "Ingredient9ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntreeAddons");
        }
    }
}
