using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBMCShopApp.Migrations
{
    public partial class AddProductsSoldEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sales_SaleId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SaleId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductsSold",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<float>(type: "REAL", nullable: false),
                    ShelfNumber = table.Column<string>(type: "TEXT", nullable: true),
                    SaleId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSold", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsSold_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 262, DateTimeKind.Unspecified).AddTicks(6173), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(2992), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6365), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6414), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6425), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6431), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6436), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6443), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6448), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6454), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6459), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6465), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6471), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6483), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6489), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6494), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6500), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6505), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6511), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6516), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6522), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6527), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6533), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6539), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6545), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6550), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6555), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6561), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6567), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6572), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6579), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6584), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6601), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6606), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6617), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6623), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6628), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6634), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6640), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6646), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6651), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6656), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6662), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6689), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6694), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6706), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6712), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6717), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6839), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6846), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6854), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6859), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6866), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6871), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6877), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6882), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6894), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6906), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6912), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6917), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6929), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6936), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6942), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6949), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6954), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6960), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 23, 53, 43, 269, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSold_SaleId",
                table: "ProductsSold",
                column: "SaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsSold");

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 5, DateTimeKind.Unspecified).AddTicks(1232), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 11, DateTimeKind.Unspecified).AddTicks(7819), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1344), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1373), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1388), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1394), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1405), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1416), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1422), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1427), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1438), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1444), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1449), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1456), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1467), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1471), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1478), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1483), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1489), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1494), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1500), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1505), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1510), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1515), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1523), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1528), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1534), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1539), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1545), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1556), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1560), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1571), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1582), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1587), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1592), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1602), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1618), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1623), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1628), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1640), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1645), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1650), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1656), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1661), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1667), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1672), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1678), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1683), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1689), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1693), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1704), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1710), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1715), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1721), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1725), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1834), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1840), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1847), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1852), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1858), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1863), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1869), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1880), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1884), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1890), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1895), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1901), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1912), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1917), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 22, 17, 24, 12, 12, DateTimeKind.Unspecified).AddTicks(1927), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SaleId",
                table: "Products",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sales_SaleId",
                table: "Products",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
