using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListingAPI.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "048180ee-f9a7-4a6a-8996-0c02ce334dd7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45ebb10f-6e29-4204-986a-2f80aec10771");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3a3c974-d3e7-4640-8c1e-35a14bd28280", "7adcc702-f654-48cd-b5e2-7d6f917a3822", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a417adb8-5ef4-49b6-ae02-c78d0f50ea7b", "839f77b6-b334-4ba7-ab66-853d6e13932a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a417adb8-5ef4-49b6-ae02-c78d0f50ea7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3a3c974-d3e7-4640-8c1e-35a14bd28280");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45ebb10f-6e29-4204-986a-2f80aec10771", "6256cb39-6083-41cf-9554-c235ea0a3c0a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "048180ee-f9a7-4a6a-8996-0c02ce334dd7", "c9a1a99c-408d-43c7-aa20-5d1900107a7e", "Administrator", "ADMINISTRATOR" });
        }
    }
}
