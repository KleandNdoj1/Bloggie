using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Data.Migrations.Auth
{
    /// <inheritdoc />
    public partial class CreatingAuthDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168c5e44-d8d7-47ee-a798-6a79a6c38fb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b990634-0987-4e7f-8f79-f57ef986f341", "AQAAAAIAAYagAAAAEBrKRM6xxxhdTYzp5LZgxKT617oJiSdkJVRHdUWqZXA6RGbFeQVebt6k0QKc41cTNg==", "7f284115-aea1-48d4-ae5b-de16d75d4470" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168c5e44-d8d7-47ee-a798-6a79a6c38fb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1683ba4d-324b-4abc-a1d4-f641b05def15", "AQAAAAIAAYagAAAAEDHHPZa1uVEyV0FfWIuHYWK5Qpbx692rbB94d4MbplDGJxwlBTufj/nYDSkeFdi6Ag==", "08a4c2c0-e54f-4941-b8d7-adedcba07a76" });
        }
    }
}
