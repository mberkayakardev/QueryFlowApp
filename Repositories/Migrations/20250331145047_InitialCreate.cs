using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppApplicationType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppApplicationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaimDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    UserFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    FalseEntryCount = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionsMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppRoverId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppClaimId = table.Column<int>(type: "int", nullable: false),
                    AppApplicationTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppMenus_AppApplicationType_AppApplicationTypeId",
                        column: x => x.AppApplicationTypeId,
                        principalTable: "AppApplicationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppMenus_AppClaims_AppClaimId",
                        column: x => x.AppClaimId,
                        principalTable: "AppClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppRoleClaims_AppClaims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "AppClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRoleClaims_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppTokens_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserClaims_AppClaims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "AppClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserClaims_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyId = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutomaticCalculation = table.Column<bool>(type: "bit", nullable: false),
                    QuestionType = table.Column<int>(type: "int", nullable: false),
                    QuestionPoints = table.Column<int>(type: "int", nullable: false),
                    SurveyCardId = table.Column<int>(type: "int", nullable: false),
                    QuestionTypesId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyQuestions_QuestionTypes_QuestionTypesId",
                        column: x => x.QuestionTypesId,
                        principalTable: "QuestionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyQuestions_SurveyCards_SurveyCardId",
                        column: x => x.SurveyCardId,
                        principalTable: "SurveyCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveysForUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SurveysCard = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSolved = table.Column<bool>(type: "bit", nullable: false),
                    LastQuestionId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    SurveyCardsId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveysForUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveysForUser_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveysForUser_SurveyCards_SurveyCardsId",
                        column: x => x.SurveyCardsId,
                        principalTable: "SurveyCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppMVCMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RootId = table.Column<int>(type: "int", nullable: true),
                    MenuOrderNumber = table.Column<int>(type: "int", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNewTab = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMVCMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppMVCMenus_AppMVCMenus_RootId",
                        column: x => x.RootId,
                        principalTable: "AppMVCMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppMVCMenus_AppMenus_Id",
                        column: x => x.Id,
                        principalTable: "AppMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyQuestionsId = table.Column<int>(type: "int", nullable: false),
                    OptionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    QuestionPoint = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsTrue = table.Column<bool>(type: "bit", nullable: false),
                    QuestionTypesId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAnswers_QuestionTypes_QuestionTypesId",
                        column: x => x.QuestionTypesId,
                        principalTable: "QuestionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionAnswers_SurveyQuestions_SurveyQuestionsId",
                        column: x => x.SurveyQuestionsId,
                        principalTable: "SurveyQuestions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AppApplicationType",
                columns: new[] { "Id", "ApplicationDescription", "ApplicationName", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName" },
                values: new object[] { 1, "MVC", "MVC", new DateTime(2025, 3, 31, 14, 50, 46, 782, DateTimeKind.Utc).AddTicks(4758), null, "SeedData", true, new DateTime(2025, 3, 31, 14, 50, 46, 782, DateTimeKind.Utc).AddTicks(5028), null, "SeedData" });

            migrationBuilder.InsertData(
                table: "AppClaims",
                columns: new[] { "Id", "ClaimDescription", "ClaimName", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName" },
                values: new object[,]
                {
                    { 1, "Admin Layout içerisindeki Dashboard ın görülebilmesi için eklenmiş olan bir cliam dir.", "Admin.Dashboard", new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3025), null, "SeedData", true, new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3026), null, "SeedData" },
                    { 2, "Anket / Sınavlar için base modülün claim kaydıdır. ", "Admin.Survey.BaseMenu", new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3342), null, "SeedData", true, new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3343), null, "SeedData" },
                    { 3, "Anket / Sınavlar için Kullanıcının Kendi kartlarını görüntüleyebileceği bir claimdir.  ", "Admin.Survey.Index", new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3345), null, "SeedData", true, new DateTime(2025, 3, 31, 14, 50, 46, 783, DateTimeKind.Utc).AddTicks(3345), null, "SeedData" }
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RoleDescription", "RoleName" },
                values: new object[] { 1, new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(2473), null, "Seed Data", true, new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(2476), null, null, "En yetkili kullanıcı", "Sistem Admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "CreatedUserName", "EmailConfirmed", "FalseEntryCount", "IsActive", "IsBlocked", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "UserEmail", "UserFullName", "UserName", "UserPassword" },
                values: new object[] { 1, new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(8262), null, "Seed Data", true, 0, true, false, new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(8265), null, "Seed Data", "berkayakar@gmail.com", "Berkay AKAR", "berkayakar", "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3" });

            migrationBuilder.InsertData(
                table: "AppMenus",
                columns: new[] { "Id", "AppApplicationTypeId", "AppClaimId", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "MenuDescription", "MenuName", "ModifiedDate", "ModifiedUserId", "ModifiedUserName" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2025, 3, 31, 17, 50, 46, 783, DateTimeKind.Local).AddTicks(6866), null, "Seed Data", true, "Sınav Base menü", "Sınav", new DateTime(2025, 3, 31, 17, 50, 46, 784, DateTimeKind.Local).AddTicks(4706), null, null },
                    { 2, 1, 3, new DateTime(2025, 3, 31, 17, 50, 46, 784, DateTimeKind.Local).AddTicks(6392), null, "Seed Data", true, "Sınav Kartları", "Sınav Kartlarını görüntüle", new DateTime(2025, 3, 31, 17, 50, 46, 784, DateTimeKind.Local).AddTicks(6395), null, null }
                });

            migrationBuilder.InsertData(
                table: "AppRoleClaims",
                columns: new[] { "Id", "ClaimId", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RoleId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 3, 31, 14, 50, 46, 784, DateTimeKind.Utc).AddTicks(9740), null, "SeedData", true, new DateTime(2025, 3, 31, 14, 50, 46, 784, DateTimeKind.Utc).AddTicks(9741), null, "SeedData", 1 },
                    { 2, 2, new DateTime(2025, 3, 31, 14, 50, 46, 785, DateTimeKind.Utc).AddTicks(35), null, "SeedData", true, new DateTime(2025, 3, 31, 14, 50, 46, 785, DateTimeKind.Utc).AddTicks(36), null, "SeedData", 1 },
                    { 3, 3, new DateTime(2025, 3, 31, 14, 50, 46, 785, DateTimeKind.Utc).AddTicks(38), null, "SeedData", true, new DateTime(2025, 3, 31, 14, 50, 46, 785, DateTimeKind.Utc).AddTicks(38), null, "SeedData", 1 }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RoleId", "UserId" },
                values: new object[] { 1, new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(5043), null, "Seed Data", true, new DateTime(2025, 3, 31, 17, 50, 46, 785, DateTimeKind.Local).AddTicks(5046), null, null, 1, 1 });

            migrationBuilder.InsertData(
                table: "AppMVCMenus",
                columns: new[] { "Id", "ActionName", "AreaName", "ControllerName", "IsNewTab", "MenuIcon", "MenuOrderNumber", "Parameter", "RootId" },
                values: new object[,]
                {
                    { 1, "", "", "", false, "nav-icon fas fa-copy", 0, "", null },
                    { 2, "Index", "Admin", "Survey", false, "nav-icon fas fa-copy", 0, "", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppMenus_AppApplicationTypeId",
                table: "AppMenus",
                column: "AppApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMenus_AppClaimId",
                table: "AppMenus",
                column: "AppClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMVCMenus_RootId",
                table: "AppMVCMenus",
                column: "RootId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleClaims_ClaimId",
                table: "AppRoleClaims",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleClaims_RoleId",
                table: "AppRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppTokens_AppUserId",
                table: "AppTokens",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUserClaims_ClaimId",
                table: "AppUserClaims",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserClaims_UserId",
                table: "AppUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_RoleId",
                table: "AppUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_UserId",
                table: "AppUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_QuestionTypesId",
                table: "QuestionAnswers",
                column: "QuestionTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_SurveyQuestionsId",
                table: "QuestionAnswers",
                column: "SurveyQuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestions_QuestionTypesId",
                table: "SurveyQuestions",
                column: "QuestionTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestions_SurveyCardId",
                table: "SurveyQuestions",
                column: "SurveyCardId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveysForUser_AppUserId",
                table: "SurveysForUser",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveysForUser_SurveyCardsId",
                table: "SurveysForUser",
                column: "SurveyCardsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppMVCMenus");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppTokens");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "QuestionAnswers");

            migrationBuilder.DropTable(
                name: "QuestionsMedias");

            migrationBuilder.DropTable(
                name: "SurveysForUser");

            migrationBuilder.DropTable(
                name: "AppMenus");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "SurveyQuestions");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppApplicationType");

            migrationBuilder.DropTable(
                name: "AppClaims");

            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DropTable(
                name: "SurveyCards");
        }
    }
}
