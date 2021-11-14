using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBMCShopApp.Migrations
{
    public partial class AppInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SaleDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    SalesPerson = table.Column<string>(type: "TEXT", nullable: true),
                    SubTotal = table.Column<decimal>(type: "TEXT", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "TEXT", nullable: false),
                    TypeOfSale = table.Column<int>(type: "INTEGER", nullable: false),
                    ModeOfPayment = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shelves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShelfNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ShelfDescription = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    RetailPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CostPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    SupplyDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Quantity = table.Column<float>(type: "REAL", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Comments = table.Column<string>(type: "TEXT", nullable: true),
                    UnitMeasure = table.Column<int>(type: "INTEGER", nullable: false),
                    ShelfId = table.Column<int>(type: "INTEGER", nullable: false),
                    SaleId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Shelves_ShelfId",
                        column: x => x.ShelfId,
                        principalTable: "Shelves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 5, DateTimeKind.Unspecified).AddTicks(1232), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "1", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 11, DateTimeKind.Unspecified).AddTicks(7819), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 24, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1623), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "24", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1628), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 25, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "25", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1640), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 26, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1645), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "26", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1650), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 27, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1656), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "27", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 28, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1667), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "28", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1672), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 29, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1678), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "29", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1683), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 30, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1689), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "30", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1693), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 31, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "31", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1704), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 32, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1710), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "32", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1715), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 33, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1721), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "33", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1725), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 34, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1834), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "34", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1840), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 35, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1847), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "35", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1852), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 36, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1858), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "36", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1863), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 37, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1869), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "37", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 38, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1880), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "38", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 39, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1890), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "39", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1895), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 40, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1901), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "40", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 23, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "23", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1618), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 22, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1602), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "22", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 21, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "21", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1592), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 20, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "20", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1582), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 2, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1344), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "2", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1373), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 3, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1388), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "3", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1394), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 4, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "4", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1405), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 5, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "5", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1416), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 6, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1422), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "6", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1427), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 7, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "7", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1438), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 8, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1444), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "8", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1449), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 9, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1456), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "9", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 41, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1912), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "41", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1917), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 10, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1467), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "10", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1471), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 12, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1489), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "12", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 13, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1500), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "13", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1505), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 14, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1510), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "14", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1515), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 15, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1523), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "15", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1528), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 16, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1534), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "16", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1539), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 17, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1545), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "17", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 18, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1556), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "18", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1560), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 19, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "19", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1571), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 11, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1478), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "11", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1483), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 42, new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "42", new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1927), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SaleId",
                table: "Products",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShelfId",
                table: "Products",
                column: "ShelfId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Shelves");
        }
    }
}
