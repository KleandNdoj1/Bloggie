using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Data.Migrations.Auth
{
    /// <inheritdoc />
    public partial class AuthDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168c5e44-d8d7-47ee-a798-6a79a6c38fb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7faca83-3df3-4c1a-bdce-17feacc20634", "AQAAAAIAAYagAAAAEDzim/rQmVLlNBlsNiiSZ9UPF3fagT8vUvPUMGuBtblic0vbQuWwDteWtRNcW34xOw==", "e77fc5da-58ac-4276-9d0c-685f58308fe6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168c5e44-d8d7-47ee-a798-6a79a6c38fb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b79a47be-8b24-42f2-b5c7-b79e934a7253", "AQAAAAIAAYagAAAAEFxdhSl/WWtgpeXCYBqzGpUh8D2Eyw4vpKAJxoenYDwQOY3w2PyK8mOiEMroyhqapw==", "a37b775f-39b5-4526-ab71-b838b9820ff0" });
        }
    }
}
