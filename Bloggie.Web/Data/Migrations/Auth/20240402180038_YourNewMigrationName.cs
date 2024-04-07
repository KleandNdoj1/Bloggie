using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Data.Migrations.Auth
{
    /// <inheritdoc />
    public partial class YourNewMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168c5e44-d8d7-47ee-a798-6a79a6c38fb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b79a47be-8b24-42f2-b5c7-b79e934a7253", "AQAAAAIAAYagAAAAEFxdhSl/WWtgpeXCYBqzGpUh8D2Eyw4vpKAJxoenYDwQOY3w2PyK8mOiEMroyhqapw==", "a37b775f-39b5-4526-ab71-b838b9820ff0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168c5e44-d8d7-47ee-a798-6a79a6c38fb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b990634-0987-4e7f-8f79-f57ef986f341", "AQAAAAIAAYagAAAAEBrKRM6xxxhdTYzp5LZgxKT617oJiSdkJVRHdUWqZXA6RGbFeQVebt6k0QKc41cTNg==", "7f284115-aea1-48d4-ae5b-de16d75d4470" });
        }
    }
}
