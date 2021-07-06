using Microsoft.EntityFrameworkCore.Migrations;

namespace SmallRestaurantAPI.Migrations
{
    public partial class addingComboSideItemConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cb2de16-9371-4d66-9817-dd3ccb5def4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "980c81d8-c660-4042-a64f-ade192d02cf3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c839bc2a-580c-4bbd-836a-80ee65fcc870", "979608e6-5171-4682-be40-368a16fb3ed8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22fe09dd-3166-45e7-951c-0daef0850bb8", "d8cb8f72-cabb-4f9b-b1f7-f501fb29421b", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "ComboSideItems",
                columns: new[] { "ID", "ComboID", "ItemID", "TypeID" },
                values: new object[] { 1, 1, 3, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22fe09dd-3166-45e7-951c-0daef0850bb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c839bc2a-580c-4bbd-836a-80ee65fcc870");

            migrationBuilder.DeleteData(
                table: "ComboSideItems",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8cb2de16-9371-4d66-9817-dd3ccb5def4b", "65c4d55b-ca28-441b-9d73-bbdb8e36147a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "980c81d8-c660-4042-a64f-ade192d02cf3", "a5120976-9914-42a2-a4d0-3fba32f12889", "Administrator", "ADMINISTRATOR" });
        }
    }
}
