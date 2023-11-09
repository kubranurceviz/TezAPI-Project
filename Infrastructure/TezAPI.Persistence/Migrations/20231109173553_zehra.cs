using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TezAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class zehra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2394));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2142));
        }
    }
}
