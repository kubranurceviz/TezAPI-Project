using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TezAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class kubi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), "Hatay Mutfağı", new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(1933) },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Deniz Ürünü", new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(1931) }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "IngredientName", "IngredientType", "StockAmount", "Unit" },
                values: new object[,]
                {
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"), new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2113), "krema", "süt ürünü", 1, "adet" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2116), "un", "tahıl ürünleri", 500, "gram" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2110), "domates", "sebze", 2, "kilo" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingLists",
                columns: new[] { "Id", "CreatedDate", "ShoppingListText", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"), new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2268), "a", "a", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"), new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2272), "b", "a", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11") }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CreatedDate", "StockAmount", "UserId" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"), new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2162), 5, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"), new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2166), 500, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"), new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2140), null },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"), new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2142), null }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CookingTime", "CreatedDate", "IngredientId", "IsItFavorite", "PreparationTime", "RecipeText", "UserId" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 10, new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2184), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), false, 10, "a", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), 30, new DateTime(2023, 11, 9, 17, 11, 5, 715, DateTimeKind.Utc).AddTicks(2191), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"), false, 10, "a", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"));

            migrationBuilder.DeleteData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"));

            migrationBuilder.DeleteData(
                table: "ShoppingLists",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"));

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"));
        }
    }
}
