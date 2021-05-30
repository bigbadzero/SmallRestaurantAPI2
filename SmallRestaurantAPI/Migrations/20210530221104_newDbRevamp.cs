using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class newDbRevamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
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
                name: "Ingredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    isRequired = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ingredients_Categories_CategoryID",
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
                    MyProperty = table.Column<int>(type: "int", nullable: false),
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
                name: "Entrees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
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
                    Ingredient19ID = table.Column<int>(type: "int", nullable: true),
                    Condiment1ID = table.Column<int>(type: "int", nullable: true),
                    Condiment2ID = table.Column<int>(type: "int", nullable: true),
                    Condiment3ID = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Entrees_Ingredients_Condiment1ID",
                        column: x => x.Condiment1ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Condiment2ID",
                        column: x => x.Condiment2ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Condiment3ID",
                        column: x => x.Condiment3ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient10ID",
                        column: x => x.Ingredient10ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient11ID",
                        column: x => x.Ingredient11ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient12ID",
                        column: x => x.Ingredient12ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient13ID",
                        column: x => x.Ingredient13ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient14ID",
                        column: x => x.Ingredient14ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient15ID",
                        column: x => x.Ingredient15ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient16ID",
                        column: x => x.Ingredient16ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient17ID",
                        column: x => x.Ingredient17ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient18ID",
                        column: x => x.Ingredient18ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient19ID",
                        column: x => x.Ingredient19ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient1ID",
                        column: x => x.Ingredient1ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient2ID",
                        column: x => x.Ingredient2ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient3ID",
                        column: x => x.Ingredient3ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient4ID",
                        column: x => x.Ingredient4ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient5ID",
                        column: x => x.Ingredient5ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient6ID",
                        column: x => x.Ingredient6ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient7ID",
                        column: x => x.Ingredient7ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient8ID",
                        column: x => x.Ingredient8ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Ingredients_Ingredient9ID",
                        column: x => x.Ingredient9ID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entrees_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
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
                name: "IX_Entrees_CategoryID",
                table: "Entrees",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Condiment1ID",
                table: "Entrees",
                column: "Condiment1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Condiment2ID",
                table: "Entrees",
                column: "Condiment2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Condiment3ID",
                table: "Entrees",
                column: "Condiment3ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient10ID",
                table: "Entrees",
                column: "Ingredient10ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient11ID",
                table: "Entrees",
                column: "Ingredient11ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient12ID",
                table: "Entrees",
                column: "Ingredient12ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient13ID",
                table: "Entrees",
                column: "Ingredient13ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient14ID",
                table: "Entrees",
                column: "Ingredient14ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient15ID",
                table: "Entrees",
                column: "Ingredient15ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient16ID",
                table: "Entrees",
                column: "Ingredient16ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient17ID",
                table: "Entrees",
                column: "Ingredient17ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient18ID",
                table: "Entrees",
                column: "Ingredient18ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient19ID",
                table: "Entrees",
                column: "Ingredient19ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient1ID",
                table: "Entrees",
                column: "Ingredient1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient2ID",
                table: "Entrees",
                column: "Ingredient2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient3ID",
                table: "Entrees",
                column: "Ingredient3ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient4ID",
                table: "Entrees",
                column: "Ingredient4ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient5ID",
                table: "Entrees",
                column: "Ingredient5ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient6ID",
                table: "Entrees",
                column: "Ingredient6ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient7ID",
                table: "Entrees",
                column: "Ingredient7ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient8ID",
                table: "Entrees",
                column: "Ingredient8ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_Ingredient9ID",
                table: "Entrees",
                column: "Ingredient9ID");

            migrationBuilder.CreateIndex(
                name: "IX_Entrees_SizeID",
                table: "Entrees",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_CategoryID",
                table: "Ingredients",
                column: "CategoryID");

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
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Entrees");

            migrationBuilder.DropTable(
                name: "Sides");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
