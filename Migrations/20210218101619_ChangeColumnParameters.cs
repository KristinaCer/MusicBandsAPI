using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicBandsAPI_Project.Migrations
{
    public partial class ChangeColumnParameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Memberships_BandRoles_BandRoleId",
                table: "Memberships");

            migrationBuilder.DropIndex(
                name: "IX_Memberships_BandRoleId",
                table: "Memberships");

            migrationBuilder.AlterColumn<Guid>(
                name: "BandRoleId",
                table: "Memberships",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_BandRoleId",
                table: "Memberships",
                column: "BandRoleId",
                unique: true,
                filter: "[BandRoleId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Memberships_BandRoles_BandRoleId",
                table: "Memberships",
                column: "BandRoleId",
                principalTable: "BandRoles",
                principalColumn: "BandRoleId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Memberships_BandRoles_BandRoleId",
                table: "Memberships");

            migrationBuilder.DropIndex(
                name: "IX_Memberships_BandRoleId",
                table: "Memberships");

            migrationBuilder.AlterColumn<Guid>(
                name: "BandRoleId",
                table: "Memberships",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_BandRoleId",
                table: "Memberships",
                column: "BandRoleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Memberships_BandRoles_BandRoleId",
                table: "Memberships",
                column: "BandRoleId",
                principalTable: "BandRoles",
                principalColumn: "BandRoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
