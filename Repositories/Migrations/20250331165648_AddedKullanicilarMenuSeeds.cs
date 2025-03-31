using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedKullanicilarMenuSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AppClaims",
                columns: new[] { "Id", "ClaimDescription", "ClaimName", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName" },
                values: new object[,]
                {
                    { 4, "Admin yönetimi - Roller - User - claim - menü yönetimi ve daha fazlası için sistem yönetici yetkisi", "Admin.AdminModule", new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8507), null, "SeedData", true, new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8508), null, "SeedData" },
                    { 5, "Admin yönetimi Kullanici yönetimi ", "Admin.AdminModule.Kullanicilar", new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8509), null, "SeedData", true, new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8509), null, "SeedData" },
                    { 6, "Admin yönetimi Kullanici Görüntüleme", "Admin.AdminModule.Kullanicilar.Index", new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8513), null, "SeedData", true, new DateTime(2025, 3, 31, 16, 56, 47, 23, DateTimeKind.Utc).AddTicks(8513), null, "SeedData" }
                });

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
                columns: new[] { "CreatedDate", "MenuDescription", "MenuName", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3160), "Sınav Kartlarını Görüntüle ", "Sınav Kartları", new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3162) });

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

            migrationBuilder.InsertData(
                table: "AppMenus",
                columns: new[] { "Id", "AppApplicationTypeId", "AppClaimId", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "MenuDescription", "MenuName", "ModifiedDate", "ModifiedUserId", "ModifiedUserName" },
                values: new object[,]
                {
                    { 3, 1, 4, new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3166), null, "Seed Data", true, "Admin Modül Root menü", "Admin Modül", new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3167), null, null },
                    { 4, 1, 5, new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3169), null, "Seed Data", true, "Kullanıcılar", "Admin Modül - Kullanıcı", new DateTime(2025, 3, 31, 19, 56, 47, 25, DateTimeKind.Local).AddTicks(3170), null, null }
                });

            migrationBuilder.InsertData(
                table: "AppRoleClaims",
                columns: new[] { "Id", "ClaimId", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RoleId" },
                values: new object[,]
                {
                    { 4, 4, new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7801), null, "SeedData", true, new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7802), null, "SeedData", 1 },
                    { 5, 5, new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7803), null, "SeedData", true, new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7804), null, "SeedData", 1 },
                    { 6, 6, new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7807), null, "SeedData", true, new DateTime(2025, 3, 31, 16, 56, 47, 25, DateTimeKind.Utc).AddTicks(7807), null, "SeedData", 1 }
                });

            migrationBuilder.InsertData(
                table: "AppMVCMenus",
                columns: new[] { "Id", "ActionName", "AreaName", "ControllerName", "IsNewTab", "MenuIcon", "MenuOrderNumber", "Parameter", "RootId" },
                values: new object[,]
                {
                    { 3, "", "", "", false, "nav-icon fas fa-copy", 0, "", null },
                    { 4, "", "", "", false, "nav-icon fas fa-copy", 0, "", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppMVCMenus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppMVCMenus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AppApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 14, 50, 46, 782, DateTimeKind.Utc).AddTicks(4758), new DateTime(2025, 3, 31, 14, 50, 46, 782, DateTimeKind.Utc).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3025), new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3342), new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3345), new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 17, 50, 46, 783, DateTimeKind.Local).AddTicks(6866), new DateTime(2025, 3, 31, 17, 50, 46, 784, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MenuDescription", "MenuName", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 17, 50, 46, 784, DateTimeKind.Local).AddTicks(6392), "Sınav Kartları", "Sınav Kartlarını görüntüle", new DateTime(2025, 3, 31, 17, 50, 46, 784, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 14, 50, 46, 784, DateTimeKind.Utc).AddTicks(9740), new DateTime(2025, 3, 31, 14, 50, 46, 784, DateTimeKind.Utc).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 14, 50, 46, 785, DateTimeKind.Utc).AddTicks(35), new DateTime(2025, 3, 31, 14, 50, 46, 785, DateTimeKind.Utc).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 14, 50, 46, 785, DateTimeKind.Utc).AddTicks(38), new DateTime(2025, 3, 31, 14, 50, 46, 785, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(2473), new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(5043), new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(8262), new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(8265) });
        }
    }
}
