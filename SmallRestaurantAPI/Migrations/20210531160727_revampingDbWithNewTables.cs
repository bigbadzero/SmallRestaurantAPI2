using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class revampingDbWithNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
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
                name: "Sizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Condiments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condiments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Condiments_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Drinks_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Drinks_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entrees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Entrees_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entrees_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sides",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sides", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sides_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sides_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntreeAddons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntreeID = table.Column<int>(type: "int", nullable: false),
                    IngredientID = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_EntreeAddons_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntreeBaseIngredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntreeID = table.Column<int>(type: "int", nullable: false),
                    IngredientID = table.Column<int>(type: "int", nullable: false),
                    isRequired = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntreeBaseIngredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EntreeBaseIngredients_Entrees_EntreeID",
                        column: x => x.EntreeID,
                        principalTable: "Entrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntreeBaseIngredients_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Combos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ComboNumber = table.Column<int>(type: "int", nullable: false),
                    ComboSizeOverride = table.Column<bool>(type: "bit", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    EntreeID = table.Column<int>(type: "int", nullable: false),
                    SideID = table.Column<int>(type: "int", nullable: false),
                    DrinkID = table.Column<int>(type: "int", nullable: false),
                    Condiment1ID = table.Column<int>(type: "int", nullable: true),
                    Condiment2ID = table.Column<int>(type: "int", nullable: true),
                    Condiment3ID = table.Column<int>(type: "int", nullable: true),
                    SizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Combos_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Combos_Drinks_DrinkID",
                        column: x => x.DrinkID,
                        principalTable: "Drinks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Combos_Entrees_EntreeID",
                        column: x => x.EntreeID,
                        principalTable: "Entrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_Combos_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Combos_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Combos_CategoryID",
                table: "Combos",
                column: "CategoryID");

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
                name: "IX_Combos_EntreeID",
                table: "Combos",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_SideID",
                table: "Combos",
                column: "SideID");

            migrationBuilder.CreateIndex(
                name: "IX_Combos_SizeID",
                table: "Combos",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_Condiments_CategoryID",
                table: "Condiments",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_CategoryID",
                table: "Drinks",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_SizeID",
                table: "Drinks",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_EntreeID",
                table: "EntreeAddons",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeAddons_IngredientID",
                table: "EntreeAddons",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeBaseIngredients_EntreeID",
                table: "EntreeBaseIngredients",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_EntreeBaseIngredients_IngredientID",
                table: "EntreeBaseIngredients",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_CategoryID",
                table: "Entrees",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_SizeID",
                table: "Entrees",
                column: "SizeID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Sides_CategoryID",
                table: "Sides",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Sides_SizeID",
                table: "Sides",
                column: "SizeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Combos");

            migrationBuilder.DropTable(
                name: "Condiments");

            migrationBuilder.DropTable(
                name: "EntreeAddons");

            migrationBuilder.DropTable(
                name: "EntreeBaseIngredients");

            migrationBuilder.DropTable(
                name: "SideAddons");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Entrees");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Sides");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
