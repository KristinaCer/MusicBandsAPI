using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicBandsAPI_Project.Migrations
{
    public partial class MusicianMemberships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BandRoles",
                columns: table => new
                {
                    BandRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandRoles", x => x.BandRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    MusicianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PersonalPage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.MusicianId);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    MembershipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MusicianId = table.Column<int>(type: "int", nullable: false),
                    BandId = table.Column<int>(type: "int", nullable: false),
                    BandRoleId = table.Column<int>(type: "int", nullable: false)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memberships");

            migrationBuilder.DropTable(
                name: "BandRoles");

            migrationBuilder.DropTable(
                name: "Musicians");
        }
    }
}
