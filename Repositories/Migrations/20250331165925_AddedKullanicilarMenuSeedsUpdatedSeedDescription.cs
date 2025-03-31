using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedKullanicilarMenuSeedsUpdatedSeedDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 640, DateTimeKind.Utc).AddTicks(8938), new DateTime(2025, 3, 31, 16, 59, 24, 640, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8165), new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8588), new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8590), new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8592), new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8594), new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8598), new DateTime(2025, 3, 31, 16, 59, 24, 641, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 59, 24, 642, DateTimeKind.Local).AddTicks(3633), new DateTime(2025, 3, 31, 19, 59, 24, 643, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 59, 24, 643, DateTimeKind.Local).AddTicks(3015), new DateTime(2025, 3, 31, 19, 59, 24, 643, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 59, 24, 643, DateTimeKind.Local).AddTicks(3021), new DateTime(2025, 3, 31, 19, 59, 24, 643, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MenuName", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 59, 24, 643, DateTimeKind.Local).AddTicks(3024), "Kullanıcı", new DateTime(2025, 3, 31, 19, 59, 24, 643, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7290), new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7589), new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7591), new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7593), new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7595), new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7598), new DateTime(2025, 3, 31, 16, 59, 24, 643, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 59, 24, 644, DateTimeKind.Local).AddTicks(20), new DateTime(2025, 3, 31, 19, 59, 24, 644, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 59, 24, 644, DateTimeKind.Local).AddTicks(2704), new DateTime(2025, 3, 31, 19, 59, 24, 644, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 59, 24, 644, DateTimeKind.Local).AddTicks(5820), new DateTime(2025, 3, 31, 19, 59, 24, 644, DateTimeKind.Local).AddTicks(5823) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 496, DateTimeKind.Utc).AddTicks(9021), new DateTime(2025, 3, 31, 16, 57, 55, 496, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(8663), new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(8996), new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(8999), new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(9001), new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(9003), new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(9007), new DateTime(2025, 3, 31, 16, 57, 55, 497, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 57, 55, 498, DateTimeKind.Local).AddTicks(3898), new DateTime(2025, 3, 31, 19, 57, 55, 499, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 57, 55, 499, DateTimeKind.Local).AddTicks(3431), new DateTime(2025, 3, 31, 19, 57, 55, 499, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 57, 55, 499, DateTimeKind.Local).AddTicks(3437), new DateTime(2025, 3, 31, 19, 57, 55, 499, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MenuName", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 57, 55, 499, DateTimeKind.Local).AddTicks(3441), "Admin Modül - Kullanıcı", new DateTime(2025, 3, 31, 19, 57, 55, 499, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7662), new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7960), new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7962), new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7964), new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7966), new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7969), new DateTime(2025, 3, 31, 16, 57, 55, 499, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 57, 55, 500, DateTimeKind.Local).AddTicks(496), new DateTime(2025, 3, 31, 19, 57, 55, 500, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 57, 55, 500, DateTimeKind.Local).AddTicks(3117), new DateTime(2025, 3, 31, 19, 57, 55, 500, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 57, 55, 500, DateTimeKind.Local).AddTicks(6197), new DateTime(2025, 3, 31, 19, 57, 55, 500, DateTimeKind.Local).AddTicks(6200) });
        }
    }
}
