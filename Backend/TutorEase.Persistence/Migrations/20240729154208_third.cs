using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutorEase.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bvn",
                table: "T_USER");

            migrationBuilder.DropColumn(
                name: "CityOrTown",
                table: "T_USER");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "T_USER");

            migrationBuilder.DropColumn(
                name: "Landmark",
                table: "T_USER");

            migrationBuilder.DropColumn(
                name: "Lga",
                table: "T_USER");

            migrationBuilder.DropColumn(
                name: "Nin",
                table: "T_USER");

            migrationBuilder.RenameColumn(
                name: "StreetName",
                table: "T_USER",
                newName: "ContactAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactAddress",
                table: "T_USER",
                newName: "StreetName");

            migrationBuilder.AddColumn<string>(
                name: "Bvn",
                table: "T_USER",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CityOrTown",
                table: "T_USER",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HouseNumber",
                table: "T_USER",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Landmark",
                table: "T_USER",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lga",
                table: "T_USER",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nin",
                table: "T_USER",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: "7cc5cd62-6240-44e5-b44f-bff0ae73342",
                columns: new[] { "Bvn", "CityOrTown", "HouseNumber", "Landmark", "Lga", "Nin" },
                values: new object[] { "", "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: "9a6a928b-0e11-4d5d-8a29-b8f04445e72",
                columns: new[] { "Bvn", "CityOrTown", "HouseNumber", "Landmark", "Lga", "Nin" },
                values: new object[] { "", "", "", "", "", "" });
        }
    }
}
