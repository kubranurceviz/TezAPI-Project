using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TezAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class tekir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Recipes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 12, 14, 16, 22, 578, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Recipes",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
