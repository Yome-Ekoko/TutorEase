using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutorEase.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_ROLE",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NORMALIZED_NAME = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CONCURRENCY_STAMP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ROLE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_USER",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bvn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Landmark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityOrTown = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    WordIdUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoolRole = table.Column<int>(type: "int", nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IS_LOGGED_IN = table.Column<bool>(type: "bit", nullable: false),
                    LAST_LOGIN_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    USER_NAME = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NORMALIZED_USER_NAME = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NORMALIZED_EMAIL = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EMAIL_CONFIRMED = table.Column<bool>(type: "bit", nullable: false),
                    PASSWORD_HASH = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SECURITY_STAMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONCURRENCY_STAMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHONE_NUMBER = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PHONE_NUMBER_CONFIRMED = table.Column<bool>(type: "bit", nullable: false),
                    TWO_FACTOR_ENABLED = table.Column<bool>(type: "bit", nullable: false),
                    LOCKOUT_END = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LOCKOUT_ENABLED = table.Column<bool>(type: "bit", nullable: false),
                    ACCESS_FAILED_COUNT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ROLE_CLAIMS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ROLE_ID = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    CLAIM_TYPE = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CLAIM_VALUE = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ROLE_CLAIMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_ROLE_CLAIMS_T_ROLE_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "T_ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_USER_CLAIMS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    CLAIM_TYPE = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CLAIM_VALUE = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_CLAIMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_USER_CLAIMS_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_USER_LOGINS",
                columns: table => new
                {
                    LOGIN_PROVIDER = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PROVIDER_KEY = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PROVIDER_DISPLAY_NAME = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    USER_ID = table.Column<string>(type: "nvarchar(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_LOGINS", x => new { x.LOGIN_PROVIDER, x.PROVIDER_KEY });
                    table.ForeignKey(
                        name: "FK_T_USER_LOGINS_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_USER_TOKENS",
                columns: table => new
                {
                    USER_ID = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    LOGIN_PROVIDER = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    VALUE = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_TOKENS", x => new { x.USER_ID, x.LOGIN_PROVIDER, x.NAME });
                    table.ForeignKey(
                        name: "FK_T_USER_TOKENS_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USER_ROLES",
                columns: table => new
                {
                    USER_ID = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ROLE_ID = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_ROLES", x => new { x.USER_ID, x.ROLE_ID });
                    table.ForeignKey(
                        name: "FK_USER_ROLES_T_ROLE_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "T_ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_ROLES_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "T_ROLE",
                columns: new[] { "ID", "CONCURRENCY_STAMP", "NAME", "NORMALIZED_NAME" },
                values: new object[,]
                {
                    { "510057bf-a91a-4398-83e7-58a558ae5edd", "71f781f7-e957-469b-96df-9f2035147a23", "Administrator", "ADMINISTRATOR" },
                    { "76cdb59e-48da-4651-b300-a20e9c08a750", "71f781f7-e957-469b-96df-9f2035147a56", "Log", "LOG" }
                });

            migrationBuilder.InsertData(
                table: "T_USER",
                columns: new[] { "ID", "ACCESS_FAILED_COUNT", "Bvn", "CityOrTown", "CONCURRENCY_STAMP", "CREATED_AT", "EMAIL", "EMAIL_CONFIRMED", "NAME", "HouseNumber", "IsActive", "IS_LOGGED_IN", "Landmark", "LAST_LOGIN_TIME", "LastName", "Lga", "LOCKOUT_ENABLED", "LOCKOUT_END", "Nin", "NORMALIZED_EMAIL", "NORMALIZED_USER_NAME", "PASSWORD_HASH", "PHONE_NUMBER", "PHONE_NUMBER_CONFIRMED", "PoolRole", "SECURITY_STAMP", "State", "STATUS", "StreetName", "TWO_FACTOR_ENABLED", "UPDATED_AT", "User", "USER_NAME", "WordIdUrl" },
                values: new object[,]
                {
                    { "7cc5cd62-6240-44e5-b44f-bff0ae73342", 0, "", "", "71f781f7-e957-469b-96df-9f2035147e45", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "yomeekoko25@gmail.com", true, "Yome Ekoko", "", true, false, "", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", false, null, "", "yomeekoko25@gmail.com", "YUMMY", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, 1, "71f781f7-e957-469b-96df-9f2035147e93", "", "Active", "", false, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "yummy", "" },
                    { "9a6a928b-0e11-4d5d-8a29-b8f04445e72", 0, "", "", "71f781f7-e957-469b-96df-9f2035147e98", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "yomeekoko25@gmail.com", true, "Ebube Tutor", "", true, false, "", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", false, null, "", "yomeekoko25@gmail.com", "EBUBE", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, 1, "71f781f7-e957-469b-96df-9f2035147e37", "", "Active", "", false, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "ebube", "" }
                });

            migrationBuilder.InsertData(
                table: "USER_ROLES",
                columns: new[] { "ROLE_ID", "USER_ID" },
                values: new object[,]
                {
                    { "510057bf-a91a-4398-83e7-58a558ae5edd", "7cc5cd62-6240-44e5-b44f-bff0ae73342" },
                    { "76cdb59e-48da-4651-b300-a20e9c08a750", "9a6a928b-0e11-4d5d-8a29-b8f04445e72" }
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "T_ROLE",
                column: "NORMALIZED_NAME",
                unique: true,
                filter: "[NORMALIZED_NAME] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_ROLE_CLAIMS_ROLE_ID",
                table: "T_ROLE_CLAIMS",
                column: "ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "T_USER",
                column: "NORMALIZED_EMAIL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "T_USER",
                column: "NORMALIZED_USER_NAME",
                unique: true,
                filter: "[NORMALIZED_USER_NAME] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_CLAIMS_USER_ID",
                table: "T_USER_CLAIMS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_LOGINS_USER_ID",
                table: "T_USER_LOGINS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_ROLES_ROLE_ID",
                table: "USER_ROLES",
                column: "ROLE_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_ROLE_CLAIMS");

            migrationBuilder.DropTable(
                name: "T_USER_CLAIMS");

            migrationBuilder.DropTable(
                name: "T_USER_LOGINS");

            migrationBuilder.DropTable(
                name: "T_USER_TOKENS");

            migrationBuilder.DropTable(
                name: "USER_ROLES");

            migrationBuilder.DropTable(
                name: "T_ROLE");

            migrationBuilder.DropTable(
                name: "T_USER");
        }
    }
}
