using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class revampedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Entrees_EntreeID",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_EntreeID",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserID",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72fe20e0-4cbf-4b8c-9d1d-197228dfbb12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e87fa7e-d360-45dd-ab19-fb90265ecdf6");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "EntreeID",
                table: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Carts",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SelectedEntreeID",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "UserID");

            migrationBuilder.CreateTable(
                name: "SelectedEntrees",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntreeID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedEntrees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SelectedEntrees_Entrees_EntreeID",
                        column: x => x.EntreeID,
                        principalTable: "Entrees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectedIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectedEntreeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
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
                values: new object[] { "61ab3b0c-71a0-4088-a446-c9d6a6868795", "46637418-3b9b-4683-a8fd-74ee390c186f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f787b1c0-969a-4f30-a11d-bc4fbfbe58fd", "b32f13bd-bfb7-4818-be1d-1867f1b023bc", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_SelectedEntreeID",
                table: "Carts",
                column: "SelectedEntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntrees_EntreeID",
                table: "SelectedEntrees",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedIngredients_IngredientId",
                table: "SelectedIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedIngredients_SelectedEntreeID",
                table: "SelectedIngredients",
                column: "SelectedEntreeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserID",
                table: "Carts",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_SelectedEntrees_SelectedEntreeID",
                table: "Carts",
                column: "SelectedEntreeID",
                principalTable: "SelectedEntrees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_SelectedEntrees_SelectedEntreeID",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "SelectedIngredients");

            migrationBuilder.DropTable(
                name: "SelectedEntrees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_SelectedEntreeID",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61ab3b0c-71a0-4088-a446-c9d6a6868795");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f787b1c0-969a-4f30-a11d-bc4fbfbe58fd");

            migrationBuilder.DropColumn(
                name: "SelectedEntreeID",
                table: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Carts",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EntreeID",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72fe20e0-4cbf-4b8c-9d1d-197228dfbb12", "18c170cc-64e3-4132-8d1a-b06ee7b3ded9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e87fa7e-d360-45dd-ab19-fb90265ecdf6", "c1e74f68-485b-460d-b361-8bf95c8e5173", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_EntreeID",
                table: "Carts",
                column: "EntreeID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserID",
                table: "Carts",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserID",
                table: "Carts",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Entrees_EntreeID",
                table: "Carts",
                column: "EntreeID",
                principalTable: "Entrees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
