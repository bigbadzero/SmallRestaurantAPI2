using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class creatingNewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SelectedEntreeIngredients_SelectedSides_SelectedSideID",
                table: "SelectedEntreeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_SelectedEntreeIngredients_SelectedSideID",
                table: "SelectedEntreeIngredients");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d0a6dd1-c067-4332-b270-c53a138a0f77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5754f19-7bd3-47b5-8810-0498156666d6");

            migrationBuilder.DropColumn(
                name: "SelectedSideID",
                table: "SelectedEntreeIngredients");

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Items_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemAvailableAddons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAvailableAddons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemAvailableAddons_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemAvailableAddons_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemBaseIngredients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    isRequired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemBaseIngredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemBaseIngredients_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemBaseIngredients_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCategories_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemSizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSizes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemSizes_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSizes_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ac00d236-f18d-47cf-a2c0-5548fd9965eb", "fcaefc6d-8e26-432e-8e89-701bd92e44f7", "User", "USER" },
                    { "b207b8a9-7770-472d-ae0d-3411a6025f66", "b0a3bb10-8e07-4372-91f8-9da5c25f78f2", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Entree" },
                    { 2, "Side" },
                    { 3, "Drink" },
                    { 4, "Combo" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "Description", "Name", "TypeID" },
                values: new object[] { 1, null, "CheeseBurger", 1 });

            migrationBuilder.InsertData(
                table: "ItemAvailableAddons",
                columns: new[] { "ID", "IngredientID", "ItemID" },
                values: new object[] { 1, 13, 1 });

            migrationBuilder.InsertData(
                table: "ItemBaseIngredients",
                columns: new[] { "ID", "IngredientID", "ItemID", "isRequired" },
                values: new object[,]
                {
                    { 1, 1, 1, true },
                    { 2, 2, 1, true },
                    { 3, 3, 1, false },
                    { 4, 4, 1, false },
                    { 5, 5, 1, false },
                    { 6, 6, 1, false },
                    { 7, 7, 1, false }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "ID", "CategoryID", "ItemID" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "ItemSizes",
                columns: new[] { "ID", "ItemID", "SizeID" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemAvailableAddons_IngredientID",
                table: "ItemAvailableAddons",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAvailableAddons_ItemID",
                table: "ItemAvailableAddons",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemBaseIngredients_IngredientID",
                table: "ItemBaseIngredients",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemBaseIngredients_ItemID",
                table: "ItemBaseIngredients",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategories_CategoryID",
                table: "ItemCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategories_ItemID",
                table: "ItemCategories",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_TypeID",
                table: "Items",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSizes_ItemID",
                table: "ItemSizes",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSizes_SizeID",
                table: "ItemSizes",
                column: "SizeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemAvailableAddons");

            migrationBuilder.DropTable(
                name: "ItemBaseIngredients");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "ItemSizes");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac00d236-f18d-47cf-a2c0-5548fd9965eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b207b8a9-7770-472d-ae0d-3411a6025f66");

            migrationBuilder.AddColumn<int>(
                name: "SelectedSideID",
                table: "SelectedEntreeIngredients",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5754f19-7bd3-47b5-8810-0498156666d6", "f4675455-409f-4a6b-b627-4ac52b6237f4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d0a6dd1-c067-4332-b270-c53a138a0f77", "ce545013-6147-40f5-9c2e-495006dcf9fd", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntreeIngredients_SelectedSideID",
                table: "SelectedEntreeIngredients",
                column: "SelectedSideID");

            migrationBuilder.AddForeignKey(
                name: "FK_SelectedEntreeIngredients_SelectedSides_SelectedSideID",
                table: "SelectedEntreeIngredients",
                column: "SelectedSideID",
                principalTable: "SelectedSides",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
