using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OBMCShopApp.Migrations
{
    public partial class InitialAppDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SalesPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TypeOfSale = table.Column<int>(type: "int", nullable: false),
                    ModeOfPayment = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shelves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShelfNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShelfDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    ShelfNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RetailPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    CostPrice = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    SupplyDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitMeasure = table.Column<int>(type: "int", nullable: false),
                    ShelfId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    { 1, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6611), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "1", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6648), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 2, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6656), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "2", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6657), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 3, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6659), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "3", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6659), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 4, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6661), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "4", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6662), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 5, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6663), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "5", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 6, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6665), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "6", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6666), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 7, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "7", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6668), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 8, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6669), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "8", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 9, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "9", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 10, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6674), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "10", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6674), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 11, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6676), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "11", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 12, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "12", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6679), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 13, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6680), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "13", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6681), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 14, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6963), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "14", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6965), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 15, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "15", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6967), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 16, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6969), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "16", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6969), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 17, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6971), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "17", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6972), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 18, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "18", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6974), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 19, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "19", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6976), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 20, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6977), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "20", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6978), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 21, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "21", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 22, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6982), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "22", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 23, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6984), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "23", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 24, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6986), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "24", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6987), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 25, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6990), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "25", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6991), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 26, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "26", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6993), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 27, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6995), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "27", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6996), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 28, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6998), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "28", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(6999), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 29, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7000), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "29", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7001), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 30, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7002), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "30", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7003), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 31, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7006), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "31", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7007), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 32, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7008), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "32", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7009), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 33, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7011), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "33", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7011), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 34, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7013), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "34", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7014), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 35, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7015), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "35", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7016), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 36, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7017), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "36", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7018), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 37, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "37", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7020), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 38, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "38", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7022), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 39, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "39", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7024), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 40, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7025), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "40", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 41, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7027), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "41", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7028), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 42, new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "42", new DateTimeOffset(new DateTime(2021, 11, 14, 20, 9, 6, 811, DateTimeKind.Unspecified).AddTicks(7031), new TimeSpan(0, 1, 0, 0, 0)), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
