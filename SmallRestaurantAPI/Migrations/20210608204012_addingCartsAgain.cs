using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addingCartsAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "260c178d-41a0-48be-a61e-334766658c98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab654a39-8d54-4144-b3ad-0f7b7acff6f0");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiUserID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    EntreeID = table.Column<int>(type: "int", nullable: true),
                    ComboID = table.Column<int>(type: "int", nullable: true),
                    DrinkID = table.Column<int>(type: "int", nullable: true),
                    SideID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_ApiUserID",
                        column: x => x.ApiUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carts_Combos_ComboID",
                        column: x => x.ComboID,
                        principalTable: "Combos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carts_Drinks_DrinkID",
                        column: x => x.DrinkID,
                        principalTable: "Drinks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carts_Entrees_EntreeID",
                        column: x => x.EntreeID,
                        principalTable: "Entrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carts_Sides_SideID",
                        column: x => x.SideID,
                        principalTable: "Sides",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03059a28-4a8a-47c5-95ae-dc3040c05a2d", "f8544e36-6421-49be-8626-d6966d8e2ff4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8af070f-b6a7-4a44-bfe9-3d9f62136bd8", "d78c0d20-80ba-4980-a3c5-dc7cd4be521e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ApiUserID",
                table: "Carts",
                column: "ApiUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ComboID",
                table: "Carts",
                column: "ComboID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_DrinkID",
                table: "Carts",
                column: "DrinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_EntreeID",
                table: "Carts",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_SideID",
                table: "Carts",
                column: "SideID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03059a28-4a8a-47c5-95ae-dc3040c05a2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8af070f-b6a7-4a44-bfe9-3d9f62136bd8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab654a39-8d54-4144-b3ad-0f7b7acff6f0", "5bcb3f7f-5b2c-478e-a883-a307d0a4b823", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "260c178d-41a0-48be-a61e-334766658c98", "6401f980-38bb-44bf-b3d1-db0c1518c98e", "Administrator", "ADMINISTRATOR" });
        }
    }
}
