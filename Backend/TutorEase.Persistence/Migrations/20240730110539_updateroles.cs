using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutorEase.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "T_ROLE",
                keyColumn: "ID",
                keyValue: "510057bf-a91a-4398-83e7-58a558ae5edd",
                columns: new[] { "NAME", "NORMALIZED_NAME" },
                values: new object[] { "Tutor", "TUTOR" });

            migrationBuilder.UpdateData(
                table: "T_ROLE",
                keyColumn: "ID",
                keyValue: "76cdb59e-48da-4651-b300-a20e9c08a750",
                columns: new[] { "NAME", "NORMALIZED_NAME" },
                values: new object[] { "Student", "STUDENT" });

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: "7cc5cd62-6240-44e5-b44f-bff0ae73342",
                column: "PoolRole",
                value: 2);

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: "9a6a928b-0e11-4d5d-8a29-b8f04445e72",
                column: "PoolRole",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "T_ROLE",
                keyColumn: "ID",
                keyValue: "510057bf-a91a-4398-83e7-58a558ae5edd",
                columns: new[] { "NAME", "NORMALIZED_NAME" },
                values: new object[] { "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "T_ROLE",
                keyColumn: "ID",
                keyValue: "76cdb59e-48da-4651-b300-a20e9c08a750",
                columns: new[] { "NAME", "NORMALIZED_NAME" },
                values: new object[] { "Log", "LOG" });

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: "7cc5cd62-6240-44e5-b44f-bff0ae73342",
                column: "PoolRole",
                value: 1);

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: "9a6a928b-0e11-4d5d-8a29-b8f04445e72",
                column: "PoolRole",
                value: 1);
        }
    }
}
