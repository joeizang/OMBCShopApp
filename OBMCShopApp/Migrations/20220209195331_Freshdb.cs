using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace OBMCShopApp.Migrations
{
    public partial class Freshdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SaleDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SalesPerson = table.Column<string>(type: "text", nullable: true),
                    SubTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    TypeOfSale = table.Column<int>(type: "integer", nullable: false),
                    ModeOfPayment = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shelves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShelfNumber = table.Column<string>(type: "text", nullable: true),
                    ShelfDescription = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                name: "ProductsSold",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    ShelfNumber = table.Column<string>(type: "text", nullable: true),
                    SaleId = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSold", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsSold_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    RetailPrice = table.Column<decimal>(type: "numeric(12,2)", nullable: false),
                    CostPrice = table.Column<decimal>(type: "numeric(12,2)", nullable: false),
                    SupplyDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Comments = table.Column<string>(type: "text", nullable: true),
                    UnitMeasure = table.Column<int>(type: "integer", nullable: false),
                    ShelfId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
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
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "1", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 2, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "2", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 3, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "3", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 4, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "4", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 5, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "5", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 6, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "6", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 7, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "7", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 8, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "8", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 9, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "9", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 10, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "10", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 11, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "11", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 12, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "12", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 13, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "13", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 14, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "14", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 15, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "15", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 16, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "16", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 17, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "17", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 18, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "18", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 19, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "19", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 20, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "20", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 21, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "21", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 22, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "22", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 23, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "23", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 24, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "24", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 25, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "25", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 26, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "26", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 27, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "27", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 28, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "28", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 29, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "29", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 30, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "30", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 31, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "31", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 32, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "32", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 33, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "33", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 34, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "34", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 35, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "35", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 36, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "36", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 37, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "37", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 38, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "38", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 39, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "39", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 40, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "40", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 41, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "41", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null },
                    { 42, new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Has the following products", "42", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), null }
                });

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
                name: "IX_Products_ShelfId",
                table: "Products",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSold_SaleId",
                table: "ProductsSold",
                column: "SaleId");
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
                name: "ProductsSold");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Shelves");

            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
