using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TezAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class boncuk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5065));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 9, 17, 39, 6, 158, DateTimeKind.Utc).AddTicks(9818));
        }
    }
}
