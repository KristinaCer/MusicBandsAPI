using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicBandsAPI_Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BandRoles",
                columns: table => new
                {
                    BandRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandRoles", x => x.BandRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    BandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BandName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    BandWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.BandId);
                });

            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    MusicianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PersonalPage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.MusicianId);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseTypes",
                columns: table => new
                {
                    ReleaseTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseTypes", x => x.ReleaseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    MembershipId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MusicianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BandRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.MembershipId);
                    table.ForeignKey(
                        name: "FK_Memberships_BandRoles_BandRoleId",
                        column: x => x.BandRoleId,
                        principalTable: "BandRoles",
                        principalColumn: "BandRoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "BandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_Musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "Musicians",
                        principalColumn: "MusicianId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Releases",
                columns: table => new
                {
                    ReleaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    ReleaseYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReleaseTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Releases", x => x.ReleaseId);
                    table.ForeignKey(
                        name: "FK_Releases_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "BandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Releases_ReleaseTypes_ReleaseTypeId",
                        column: x => x.ReleaseTypeId,
                        principalTable: "ReleaseTypes",
                        principalColumn: "ReleaseTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AwardReceived = table.Column<bool>(type: "bit", nullable: false),
                    ReleaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Releases_ReleaseId",
                        column: x => x.ReleaseId,
                        principalTable: "Releases",
                        principalColumn: "ReleaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_BandId",
                table: "Memberships",
                column: "BandId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_BandRoleId",
                table: "Memberships",
                column: "BandRoleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_MusicianId",
                table: "Memberships",
                column: "MusicianId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Releases_BandId",
                table: "Releases",
                column: "BandId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Releases_ReleaseTypeId",
                table: "Releases",
                column: "ReleaseTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_ReleaseId",
                table: "Songs",
                column: "ReleaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memberships");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "BandRoles");

            migrationBuilder.DropTable(
                name: "Musicians");

            migrationBuilder.DropTable(
                name: "Releases");

            migrationBuilder.DropTable(
                name: "Bands");

            migrationBuilder.DropTable(
                name: "ReleaseTypes");
        }
    }
}
