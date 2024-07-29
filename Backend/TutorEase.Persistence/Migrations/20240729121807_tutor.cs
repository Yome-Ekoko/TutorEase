using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutorEase.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class tutor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_CLAIMS_T_ROLE_ROLE_ID",
                table: "T_ROLE_CLAIMS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_CLAIMS_T_USER_USER_ID",
                table: "T_USER_CLAIMS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_LOGINS_T_USER_USER_ID",
                table: "T_USER_LOGINS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TOKENS_T_USER_USER_ID",
                table: "T_USER_TOKENS");

            migrationBuilder.RenameColumn(
                name: "WordIdUrl",
                table: "T_USER",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "TutorId",
                table: "T_USER",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TUTOR",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Languages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredCommunication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetedClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableTime1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourlyRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USER_ID = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TUTOR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TUTOR_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: "7cc5cd62-6240-44e5-b44f-bff0ae73342",
                column: "TutorId",
                value: "");

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: "9a6a928b-0e11-4d5d-8a29-b8f04445e72",
                column: "TutorId",
                value: "");

            migrationBuilder.CreateIndex(
                name: "IX_TUTOR_USER_ID",
                table: "TUTOR",
                column: "USER_ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_T_ROLE_CLAIMS_T_ROLE_ROLE_~",
                table: "T_ROLE_CLAIMS",
                column: "ROLE_ID",
                principalTable: "T_ROLE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_CLAIMS_T_USER_USER_~",
                table: "T_USER_CLAIMS",
                column: "USER_ID",
                principalTable: "T_USER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_LOGINS_T_USER_USER_~",
                table: "T_USER_LOGINS",
                column: "USER_ID",
                principalTable: "T_USER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TOKENS_T_USER_USER_~",
                table: "T_USER_TOKENS",
                column: "USER_ID",
                principalTable: "T_USER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_ROLE_CLAIMS_T_ROLE_ROLE_~",
                table: "T_ROLE_CLAIMS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_CLAIMS_T_USER_USER_~",
                table: "T_USER_CLAIMS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_LOGINS_T_USER_USER_~",
                table: "T_USER_LOGINS");

            migrationBuilder.DropForeignKey(
                name: "FK_T_USER_TOKENS_T_USER_USER_~",
                table: "T_USER_TOKENS");

            migrationBuilder.DropTable(
                name: "TUTOR");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "T_USER");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "T_USER",
                newName: "WordIdUrl");

            migrationBuilder.AddForeignKey(
                name: "FK_T_ROLE_CLAIMS_T_ROLE_ROLE_ID",
                table: "T_ROLE_CLAIMS",
                column: "ROLE_ID",
                principalTable: "T_ROLE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_CLAIMS_T_USER_USER_ID",
                table: "T_USER_CLAIMS",
                column: "USER_ID",
                principalTable: "T_USER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_LOGINS_T_USER_USER_ID",
                table: "T_USER_LOGINS",
                column: "USER_ID",
                principalTable: "T_USER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_USER_TOKENS_T_USER_USER_ID",
                table: "T_USER_TOKENS",
                column: "USER_ID",
                principalTable: "T_USER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
