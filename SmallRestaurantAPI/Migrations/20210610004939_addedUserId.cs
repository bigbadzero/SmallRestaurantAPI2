using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addedUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61ab3b0c-71a0-4088-a446-c9d6a6868795");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f787b1c0-969a-4f30-a11d-bc4fbfbe58fd");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "SelectedEntrees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a86fdec-877e-487b-8c39-86d9cb8fb328", "574105b3-cf87-4615-9bbb-6c86e51f7141", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1411b65b-e2ba-459a-86c3-d2129b4bcf64", "9e4c10d4-fb93-4072-99b3-1c91e46cc6da", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_SelectedEntrees_UserId",
                table: "SelectedEntrees",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SelectedEntrees_AspNetUsers_UserId",
                table: "SelectedEntrees",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SelectedEntrees_AspNetUsers_UserId",
                table: "SelectedEntrees");

            migrationBuilder.DropIndex(
                name: "IX_SelectedEntrees_UserId",
                table: "SelectedEntrees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1411b65b-e2ba-459a-86c3-d2129b4bcf64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a86fdec-877e-487b-8c39-86d9cb8fb328");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SelectedEntrees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61ab3b0c-71a0-4088-a446-c9d6a6868795", "46637418-3b9b-4683-a8fd-74ee390c186f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f787b1c0-969a-4f30-a11d-bc4fbfbe58fd", "b32f13bd-bfb7-4818-be1d-1867f1b023bc", "Administrator", "ADMINISTRATOR" });
        }
    }
}
