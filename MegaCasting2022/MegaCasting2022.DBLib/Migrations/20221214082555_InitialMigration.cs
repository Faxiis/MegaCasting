using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaCasting2022.DBLib.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Identifier = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Identifier);
                });

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Identifier = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Identifier);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Identifier = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressRoad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressZipCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressComplement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Identifier);
                });

            migrationBuilder.CreateTable(
                name: "ContractType",
                columns: table => new
                {
                    Identifier = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractType", x => x.Identifier);
                });

            migrationBuilder.CreateTable(
                name: "Partner",
                columns: table => new
                {
                    Identifier = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partner", x => x.Identifier);
                });

            migrationBuilder.CreateTable(
                name: "ActivityArtist",
                columns: table => new
                {
                    Identifier = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentifierArtist = table.Column<long>(type: "bigint", nullable: false),
                    IdentifierActivity = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityArtist", x => x.Identifier);
                    table.ForeignKey(
                        name: "FK_ActivityArtist_Activity",
                        column: x => x.IdentifierActivity,
                        principalTable: "Activity",
                        principalColumn: "Identifier");
                    table.ForeignKey(
                        name: "FK_ActivityArtist_Artist",
                        column: x => x.IdentifierArtist,
                        principalTable: "Artist",
                        principalColumn: "Identifier");
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    Identifier = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    ParutionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdentifierContractType = table.Column<long>(type: "bigint", nullable: false),
                    IdentifierClient = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.Identifier);
                    table.ForeignKey(
                        name: "FK_Offer_Client",
                        column: x => x.IdentifierClient,
                        principalTable: "Client",
                        principalColumn: "Identifier");
                    table.ForeignKey(
                        name: "FK_Offer_ContractType",
                        column: x => x.IdentifierContractType,
                        principalTable: "ContractType",
                        principalColumn: "Identifier");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityArtist_IdentifierActivity",
                table: "ActivityArtist",
                column: "IdentifierActivity");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityArtist_IdentifierArtist",
                table: "ActivityArtist",
                column: "IdentifierArtist");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_IdentifierClient",
                table: "Offer",
                column: "IdentifierClient");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_IdentifierContractType",
                table: "Offer",
                column: "IdentifierContractType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityArtist");

            migrationBuilder.DropTable(
                name: "Offer");

            migrationBuilder.DropTable(
                name: "Partner");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "ContractType");
        }
    }
}
