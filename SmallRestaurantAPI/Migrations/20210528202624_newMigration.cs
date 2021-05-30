using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Condiments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condiments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MenuItemTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemTypeID = table.Column<int>(type: "int", nullable: false),
                    BaseIngredient1ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient2ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient3ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient4ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient5ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient6ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient7ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient8ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient9ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient10ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient11ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient12ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient13ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient14ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient15ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient16ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient17ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient18ID = table.Column<int>(type: "int", nullable: true),
                    BaseIngredient19ID = table.Column<int>(type: "int", nullable: true),
                    Condiment1ID = table.Column<int>(type: "int", nullable: true),
                    Condiment2ID = table.Column<int>(type: "int", nullable: true),
                    Condiment3ID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient10ID",
                        column: x => x.BaseIngredient10ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient11ID",
                        column: x => x.BaseIngredient11ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient12ID",
                        column: x => x.BaseIngredient12ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient13ID",
                        column: x => x.BaseIngredient13ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient14ID",
                        column: x => x.BaseIngredient14ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient15ID",
                        column: x => x.BaseIngredient15ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient16ID",
                        column: x => x.BaseIngredient16ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient17ID",
                        column: x => x.BaseIngredient17ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient18ID",
                        column: x => x.BaseIngredient18ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient19ID",
                        column: x => x.BaseIngredient19ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient1ID",
                        column: x => x.BaseIngredient1ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient2ID",
                        column: x => x.BaseIngredient2ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient3ID",
                        column: x => x.BaseIngredient3ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient4ID",
                        column: x => x.BaseIngredient4ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient5ID",
                        column: x => x.BaseIngredient5ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient6ID",
                        column: x => x.BaseIngredient6ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient7ID",
                        column: x => x.BaseIngredient7ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient8ID",
                        column: x => x.BaseIngredient8ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_BaseIngredient9ID",
                        column: x => x.BaseIngredient9ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_Condiment1ID",
                        column: x => x.Condiment1ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_Condiment2ID",
                        column: x => x.Condiment2ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_Ingredients_Condiment3ID",
                        column: x => x.Condiment3ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuItems_MenuItemTypes_MenuItemTypeID",
                        column: x => x.MenuItemTypeID,
                        principalTable: "MenuItemTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Combos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComboNumber = table.Column<int>(type: "int", nullable: false),
                    EntreeMenuItemID = table.Column<int>(type: "int", nullable: false),
                    DrinkID = table.Column<int>(type: "int", nullable: false),
                    Condiment1ID = table.Column<int>(type: "int", nullable: true),
                    Condiment2ID = table.Column<int>(type: "int", nullable: true),
                    Condiment3ID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Combos_Drinks_DrinkID",
                        column: x => x.DrinkID,
                        principalTable: "Drinks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Combos_Ingredients_Condiment1ID",
                        column: x => x.Condiment1ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Combos_Ingredients_Condiment2ID",
                        column: x => x.Condiment2ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Combos_Ingredients_Condiment3ID",
                        column: x => x.Condiment3ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Combos_MenuItems_EntreeMenuItemID",
                        column: x => x.EntreeMenuItemID,
                        principalTable: "MenuItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Combos_DrinkID",
                table: "Combos",
                column: "DrinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_EntreeMenuItemID",
                table: "Combos",
                column: "EntreeMenuItemID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient10ID",
                table: "MenuItems",
                column: "BaseIngredient10ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient11ID",
                table: "MenuItems",
                column: "BaseIngredient11ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient12ID",
                table: "MenuItems",
                column: "BaseIngredient12ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient13ID",
                table: "MenuItems",
                column: "BaseIngredient13ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient14ID",
                table: "MenuItems",
                column: "BaseIngredient14ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient15ID",
                table: "MenuItems",
                column: "BaseIngredient15ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient16ID",
                table: "MenuItems",
                column: "BaseIngredient16ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient17ID",
                table: "MenuItems",
                column: "BaseIngredient17ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient18ID",
                table: "MenuItems",
                column: "BaseIngredient18ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient19ID",
                table: "MenuItems",
                column: "BaseIngredient19ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient1ID",
                table: "MenuItems",
                column: "BaseIngredient1ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient2ID",
                table: "MenuItems",
                column: "BaseIngredient2ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient3ID",
                table: "MenuItems",
                column: "BaseIngredient3ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient4ID",
                table: "MenuItems",
                column: "BaseIngredient4ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient5ID",
                table: "MenuItems",
                column: "BaseIngredient5ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient6ID",
                table: "MenuItems",
                column: "BaseIngredient6ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient7ID",
                table: "MenuItems",
                column: "BaseIngredient7ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient8ID",
                table: "MenuItems",
                column: "BaseIngredient8ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_BaseIngredient9ID",
                table: "MenuItems",
                column: "BaseIngredient9ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_Condiment1ID",
                table: "MenuItems",
                column: "Condiment1ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_Condiment2ID",
                table: "MenuItems",
                column: "Condiment2ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_Condiment3ID",
                table: "MenuItems",
                column: "Condiment3ID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuItemTypeID",
                table: "MenuItems",
                column: "MenuItemTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Combos");

            migrationBuilder.DropTable(
                name: "Condiments");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "MenuItemTypes");
        }
    }
}
