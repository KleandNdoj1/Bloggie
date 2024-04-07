using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Data.Migrations.Auth
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168c5e44-d8d7-47ee-a798-6a79a6c38fb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1683ba4d-324b-4abc-a1d4-f641b05def15", "AQAAAAIAAYagAAAAEDHHPZa1uVEyV0FfWIuHYWK5Qpbx692rbB94d4MbplDGJxwlBTufj/nYDSkeFdi6Ag==", "08a4c2c0-e54f-4941-b8d7-adedcba07a76" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168c5e44-d8d7-47ee-a798-6a79a6c38fb2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65e0f66c-3a63-4c97-8733-e417948af7d0", "AQAAAAIAAYagAAAAECdAErK4Mj7qBoYcoCceVkZg4Dk+NCW+LewCPwRLtgELwZIbGlqTAzgMebpjnoahzQ==", "d04e6e0d-b314-471a-8f55-b203020cf9f2" });
        }
    }
}
