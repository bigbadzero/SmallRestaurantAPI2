using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addingSideConfigs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aa636b4-4c37-40da-ba31-00119296d9c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8508c1ea-3251-4222-ae84-ba6497d7c809");

            migrationBuilder.CreateTable(
                name: "SideBaseIngredient",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SideID = table.Column<int>(type: "int", nullable: false),
                    IngredientID = table.Column<int>(type: "int", nullable: false),
                    isRequired = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideBaseIngredient", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SideBaseIngredient_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SideBaseIngredient_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83acd732-4f3b-4383-bc66-824ce0c0cec4", "484e06b2-4666-46c4-8702-ac8d41e05b71", "User", "USER" },
                    { "b4f764aa-3f73-488f-8b3f-78139fbd038f", "d826a54b-6ee3-476d-801c-defac5b0e84a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 16, null, "French Fries" },
                    { 17, null, "Onion Rings" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SideBaseIngredient_IngredientID",
                table: "SideBaseIngredient",
                column: "IngredientID");

            migrationBuilder.CreateIndex(
                name: "IX_SideBaseIngredient_SideID",
                table: "SideBaseIngredient",
                column: "SideID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SideBaseIngredient");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83acd732-4f3b-4383-bc66-824ce0c0cec4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4f764aa-3f73-488f-8b3f-78139fbd038f");

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8508c1ea-3251-4222-ae84-ba6497d7c809", "c97a1793-5855-4cbe-85a2-658b89c4ff0f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4aa636b4-4c37-40da-ba31-00119296d9c9", "92b632eb-f9ff-4878-ac8c-5b8b7b5b4dfb", "Administrator", "ADMINISTRATOR" });
        }
    }
}
