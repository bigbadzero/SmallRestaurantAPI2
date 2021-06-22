using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class refactoredTablesAndAddedSides : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SideBaseIngredient_Ingredients_IngredientID",
                table: "SideBaseIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_SideBaseIngredient_Sides_SideID",
                table: "SideBaseIngredient");

            migrationBuilder.DropTable(
                name: "SelectedIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SideBaseIngredient",
                table: "SideBaseIngredient");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83acd732-4f3b-4383-bc66-824ce0c0cec4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4f764aa-3f73-488f-8b3f-78139fbd038f");

            migrationBuilder.RenameTable(
                name: "SideBaseIngredient",
                newName: "SideBaseIngredients");

            migrationBuilder.RenameIndex(
                name: "IX_SideBaseIngredient_SideID",
                table: "SideBaseIngredients",
                newName: "IX_SideBaseIngredients_SideID");

            migrationBuilder.RenameIndex(
                name: "IX_SideBaseIngredient_IngredientID",
                table: "SideBaseIngredients",
                newName: "IX_SideBaseIngredients_IngredientID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SideBaseIngredients",
                table: "SideBaseIngredients",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "SelectedSides",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SideID = table.Column<int>(type: "int", nullable: false),
                    CartItemID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedSides", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SelectedSides_CartItems_CartItemID",
                        column: x => x.CartItemID,
                        principalTable: "CartItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedSides_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedSides_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SideSizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SideID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideSizes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SideSizes_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SideSizes_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectedEntreeIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectedEntreeID = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    SelectedSideID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedEntreeIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedEntreeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedEntreeIngredients_SelectedEntrees_SelectedEntreeID",
                        column: x => x.SelectedEntreeID,
                        principalTable: "SelectedEntrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedEntreeIngredients_SelectedSides_SelectedSideID",
                        column: x => x.SelectedSideID,
                        principalTable: "SelectedSides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SelectedSideIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectedSideID = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedSideIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedSideIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedSideIngredients_SelectedSides_SelectedSideID",
                        column: x => x.SelectedSideID,
                        principalTable: "SelectedSides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5754f19-7bd3-47b5-8810-0498156666d6", "f4675455-409f-4a6b-b627-4ac52b6237f4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d0a6dd1-c067-4332-b270-c53a138a0f77", "ce545013-6147-40f5-9c2e-495006dcf9fd", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntrees_SizeID",
                table: "SelectedEntrees",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntreeIngredients_IngredientId",
                table: "SelectedEntreeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntreeIngredients_SelectedEntreeID",
                table: "SelectedEntreeIngredients",
                column: "SelectedEntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntreeIngredients_SelectedSideID",
                table: "SelectedEntreeIngredients",
                column: "SelectedSideID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSideIngredients_IngredientId",
                table: "SelectedSideIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSideIngredients_SelectedSideID",
                table: "SelectedSideIngredients",
                column: "SelectedSideID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSides_CartItemID",
                table: "SelectedSides",
                column: "CartItemID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSides_SideID",
                table: "SelectedSides",
                column: "SideID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedSides_SizeID",
                table: "SelectedSides",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_SideSizes_SideID",
                table: "SideSizes",
                column: "SideID");

            migrationBuilder.CreateIndex(
                name: "IX_SideSizes_SizeID",
                table: "SideSizes",
                column: "SizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_SelectedEntrees_Sizes_SizeID",
                table: "SelectedEntrees",
                column: "SizeID",
                principalTable: "Sizes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SideBaseIngredients_Ingredients_IngredientID",
                table: "SideBaseIngredients",
                column: "IngredientID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SideBaseIngredients_Sides_SideID",
                table: "SideBaseIngredients",
                column: "SideID",
                principalTable: "Sides",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SelectedEntrees_Sizes_SizeID",
                table: "SelectedEntrees");

            migrationBuilder.DropForeignKey(
                name: "FK_SideBaseIngredients_Ingredients_IngredientID",
                table: "SideBaseIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_SideBaseIngredients_Sides_SideID",
                table: "SideBaseIngredients");

            migrationBuilder.DropTable(
                name: "SelectedEntreeIngredients");

            migrationBuilder.DropTable(
                name: "SelectedSideIngredients");

            migrationBuilder.DropTable(
                name: "SideSizes");

            migrationBuilder.DropTable(
                name: "SelectedSides");

            migrationBuilder.DropIndex(
                name: "IX_SelectedEntrees_SizeID",
                table: "SelectedEntrees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SideBaseIngredients",
                table: "SideBaseIngredients");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d0a6dd1-c067-4332-b270-c53a138a0f77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5754f19-7bd3-47b5-8810-0498156666d6");

            migrationBuilder.RenameTable(
                name: "SideBaseIngredients",
                newName: "SideBaseIngredient");

            migrationBuilder.RenameIndex(
                name: "IX_SideBaseIngredients_SideID",
                table: "SideBaseIngredient",
                newName: "IX_SideBaseIngredient_SideID");

            migrationBuilder.RenameIndex(
                name: "IX_SideBaseIngredients_IngredientID",
                table: "SideBaseIngredient",
                newName: "IX_SideBaseIngredient_IngredientID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SideBaseIngredient",
                table: "SideBaseIngredient",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "SelectedIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    SelectedEntreeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedIngredients_SelectedEntrees_SelectedEntreeID",
                        column: x => x.SelectedEntreeID,
                        principalTable: "SelectedEntrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83acd732-4f3b-4383-bc66-824ce0c0cec4", "484e06b2-4666-46c4-8702-ac8d41e05b71", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4f764aa-3f73-488f-8b3f-78139fbd038f", "d826a54b-6ee3-476d-801c-defac5b0e84a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_SelectedIngredients_IngredientId",
                table: "SelectedIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedIngredients_SelectedEntreeID",
                table: "SelectedIngredients",
                column: "SelectedEntreeID");

            migrationBuilder.AddForeignKey(
                name: "FK_SideBaseIngredient_Ingredients_IngredientID",
                table: "SideBaseIngredient",
                column: "IngredientID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SideBaseIngredient_Sides_SideID",
                table: "SideBaseIngredient",
                column: "SideID",
                principalTable: "Sides",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
