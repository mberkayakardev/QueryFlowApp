using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedKullanicilarMenuSeedsUpdatedSeedRootMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AppMVCMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "RootId",
                value: 3);

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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 57, 55, 499, DateTimeKind.Local).AddTicks(3441), new DateTime(2025, 3, 31, 19, 57, 55, 499, DateTimeKind.Local).AddTicks(3441) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 22, DateTimeKind.Utc).AddTicks(8752), new DateTime(2025, 3, 31, 16, 56, 47, 22, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8068), new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8503), new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8505), new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8507), new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8509), new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8513), new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "AppMVCMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "RootId",
                value: null);

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 56, 47, 24, DateTimeKind.Local).AddTicks(3505), new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3160), new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3166), new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3169), new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7497), new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7797), new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7800), new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7801), new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7803), new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7807), new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 56, 47, 26, DateTimeKind.Local).AddTicks(249), new DateTime(2025, 3, 31, 19, 56, 47, 26, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 56, 47, 26, DateTimeKind.Local).AddTicks(3024), new DateTime(2025, 3, 31, 19, 56, 47, 26, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 56, 47, 26, DateTimeKind.Local).AddTicks(6193), new DateTime(2025, 3, 31, 19, 56, 47, 26, DateTimeKind.Local).AddTicks(6195) });
        }
    }
}
