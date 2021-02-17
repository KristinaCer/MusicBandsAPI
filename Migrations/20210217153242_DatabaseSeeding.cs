using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicBandsAPI_Project.Migrations
{
    public partial class DatabaseSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BandRoles",
                columns: new[] { "BandRoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("48a9dd48-c698-458c-a72d-c5074d650bd1"), "Singer" },
                    { new Guid("689754e2-869a-4fe1-8572-73654810f27c"), "Guitarist" },
                    { new Guid("5d2cdf51-ef1c-4125-b1d8-1e5e11a27c5e"), "Drummer" }
                });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "BandId", "BandName", "BandWebsite" },
                values: new object[,]
                {
                    { new Guid("b2d87e36-3f69-486c-bd1d-38be2362f274"), "RHCP", "https://redhotchilipeppers.com/" },
                    { new Guid("32b0b796-17e6-41e5-9e63-209b421b328d"), "Oasis", "https://oasis.com/" }
                });

            migrationBuilder.InsertData(
                table: "Musicians",
                columns: new[] { "MusicianId", "Name", "PersonalPage" },
                values: new object[,]
                {
                    { new Guid("0a1188a5-97fd-4865-8b60-6a02c6e70115"), "Anthony Kiedis", "https://en.wikipedia.org/wiki/Anthony_Kiedis" },
                    { new Guid("0c79dfac-0fbe-4bd0-9d03-fc08d908917b"), "Flea", "https://en.wikipedia.org/wiki/Flea_(musician)" },
                    { new Guid("975589fc-066f-47ae-b3dd-100d6b422976"), "Chad Smith", "https://en.wikipedia.org/wiki/Chad_Smith" },
                    { new Guid("f0f7b8ee-b9b6-4790-8408-d6a374afb06a"), "John Frusciante", "https://en.wikipedia.org/wiki/John_Frusciante" }
                });

            migrationBuilder.InsertData(
                table: "ReleaseTypes",
                columns: new[] { "ReleaseTypeId", "Title" },
                values: new object[,]
                {
                    { new Guid("94f59e91-049b-4706-86db-e601c4264a2b"), "Album" },
                    { new Guid("eda1e6f8-edbd-4c49-8438-dba8da3e2859"), "Single" }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "MembershipId", "BandId", "BandRoleId", "EndYear", "MusicianId", "StartYear" },
                values: new object[] { new Guid("8976d0a7-a23e-450c-b9f8-47873eba701e"), new Guid("b2d87e36-3f69-486c-bd1d-38be2362f274"), new Guid("689754e2-869a-4fe1-8572-73654810f27c"), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), new Guid("0a1188a5-97fd-4865-8b60-6a02c6e70115"), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Releases",
                columns: new[] { "ReleaseId", "BandId", "Rating", "ReleaseTypeId", "ReleaseYear", "Title" },
                values: new object[] { new Guid("8c69defb-8efb-46da-ac92-50c9bd527bc3"), new Guid("b2d87e36-3f69-486c-bd1d-38be2362f274"), 10.0, new Guid("94f59e91-049b-4706-86db-e601c4264a2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Californication" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AwardReceived", "ReleaseId", "Title" },
                values: new object[] { new Guid("a15cddc8-8788-4c37-ad52-b59e12a54607"), true, new Guid("8c69defb-8efb-46da-ac92-50c9bd527bc3"), "Scar Tissue" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AwardReceived", "ReleaseId", "Title" },
                values: new object[] { new Guid("8b90681c-c647-474f-a56f-8fef8a88ec02"), true, new Guid("8c69defb-8efb-46da-ac92-50c9bd527bc3"), "Californication" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BandRoles",
                keyColumn: "BandRoleId",
                keyValue: new Guid("48a9dd48-c698-458c-a72d-c5074d650bd1"));

            migrationBuilder.DeleteData(
                table: "BandRoles",
                keyColumn: "BandRoleId",
                keyValue: new Guid("5d2cdf51-ef1c-4125-b1d8-1e5e11a27c5e"));

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: new Guid("32b0b796-17e6-41e5-9e63-209b421b328d"));

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "MembershipId",
                keyValue: new Guid("8976d0a7-a23e-450c-b9f8-47873eba701e"));

            migrationBuilder.DeleteData(
                table: "Musicians",
                keyColumn: "MusicianId",
                keyValue: new Guid("0c79dfac-0fbe-4bd0-9d03-fc08d908917b"));

            migrationBuilder.DeleteData(
                table: "Musicians",
                keyColumn: "MusicianId",
                keyValue: new Guid("975589fc-066f-47ae-b3dd-100d6b422976"));

            migrationBuilder.DeleteData(
                table: "Musicians",
                keyColumn: "MusicianId",
                keyValue: new Guid("f0f7b8ee-b9b6-4790-8408-d6a374afb06a"));

            migrationBuilder.DeleteData(
                table: "ReleaseTypes",
                keyColumn: "ReleaseTypeId",
                keyValue: new Guid("eda1e6f8-edbd-4c49-8438-dba8da3e2859"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: new Guid("8b90681c-c647-474f-a56f-8fef8a88ec02"));

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: new Guid("a15cddc8-8788-4c37-ad52-b59e12a54607"));

            migrationBuilder.DeleteData(
                table: "BandRoles",
                keyColumn: "BandRoleId",
                keyValue: new Guid("689754e2-869a-4fe1-8572-73654810f27c"));

            migrationBuilder.DeleteData(
                table: "Musicians",
                keyColumn: "MusicianId",
                keyValue: new Guid("0a1188a5-97fd-4865-8b60-6a02c6e70115"));

            migrationBuilder.DeleteData(
                table: "Releases",
                keyColumn: "ReleaseId",
                keyValue: new Guid("8c69defb-8efb-46da-ac92-50c9bd527bc3"));

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: new Guid("b2d87e36-3f69-486c-bd1d-38be2362f274"));

            migrationBuilder.DeleteData(
                table: "ReleaseTypes",
                keyColumn: "ReleaseTypeId",
                keyValue: new Guid("94f59e91-049b-4706-86db-e601c4264a2b"));
        }
    }
}
