using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBMCShopApp.Migrations
{
    public partial class ShelfSeedAndSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 65, DateTimeKind.Unspecified).AddTicks(3227), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "1", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 71, DateTimeKind.Unspecified).AddTicks(8648), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 24, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2320), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "24", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2325), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 25, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2332), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "25", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2337), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 26, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2343), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "26", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2348), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 27, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2354), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "27", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2359), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 28, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2365), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "28", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 29, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2376), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "29", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2381), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 30, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2388), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "30", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2392), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 31, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2398), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "31", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2403), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 32, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2409), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "32", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2413), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 33, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2419), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "33", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2424), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 34, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2430), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "34", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2435), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 35, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2441), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "35", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2445), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 36, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2451), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "36", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2456), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 37, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2462), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "37", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2467), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 38, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "38", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2478), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 39, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2485), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "39", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2489), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 40, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2496), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "40", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2501), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 23, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2309), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "23", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2314), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 22, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2298), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "22", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 21, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2286), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "21", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2291), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 20, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2275), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "20", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2280), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 2, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(1931), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "2", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(1957), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 3, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(1972), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "3", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(1978), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 4, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(1984), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "4", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(1989), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 5, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(1995), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "5", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2000), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 6, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2006), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "6", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2011), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 7, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2017), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "7", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2022), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 8, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2028), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "8", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2033), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 9, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2040), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "9", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2045), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 41, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2508), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "41", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2512), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 10, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2161), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "10", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2167), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 12, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2186), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "12", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2191), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 13, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2197), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "13", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 14, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2208), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "14", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2212), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 15, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2218), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "15", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2223), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 16, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2229), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "16", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2234), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 17, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "17", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2245), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 18, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2252), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "18", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2257), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 19, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "19", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2268), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 11, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2175), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "11", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2180), new TimeSpan(0, 1, 0, 0, 0)), null });

            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ShelfDescription", "ShelfNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 42, new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2519), new TimeSpan(0, 1, 0, 0, 0)), null, false, "Has the following products", "42", new DateTimeOffset(new DateTime(2021, 10, 20, 12, 3, 58, 72, DateTimeKind.Unspecified).AddTicks(2523), new TimeSpan(0, 1, 0, 0, 0)), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "Id",
                keyValue: 42);
        }
    }
}
