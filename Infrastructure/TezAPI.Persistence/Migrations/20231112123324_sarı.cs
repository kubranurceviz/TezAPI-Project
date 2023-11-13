using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TezAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class sarı : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 33, 24, 317, DateTimeKind.Utc).AddTicks(1436));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 12, 22, 57, 437, DateTimeKind.Utc).AddTicks(5640));
        }
    }
}
