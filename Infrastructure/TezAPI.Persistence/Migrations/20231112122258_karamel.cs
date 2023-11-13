using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TezAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class karamel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Recipes_RecipeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "FavoriteRecipes");

            migrationBuilder.DropIndex(
                name: "IX_Users_RecipeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_UserId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserFK",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "Recipes");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Recipes",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<bool>(
                name: "IsItFavorite",
                table: "Recipes",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.CreateTable(
                name: "RecipeUser",
                columns: table => new
                {
                    FavoriteRecipesId = table.Column<Guid>(type: "uuid", nullable: false),
                    UsersId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeUser", x => new { x.FavoriteRecipesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RecipeUser_Recipes_FavoriteRecipesId",
                        column: x => x.FavoriteRecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_UserId",
                table: "Stocks",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingLists_UserId",
                table: "ShoppingLists",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeUser_UsersId",
                table: "RecipeUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingLists_Users_UserId",
                table: "ShoppingLists",
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

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingLists_Users_UserId",
                table: "ShoppingLists");

            migrationBuilder.DropTable(
                name: "RecipeUser");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_UserId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingLists_UserId",
                table: "ShoppingLists");

            migrationBuilder.AddColumn<Guid>(
                name: "RecipeId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserFK",
                table: "Stocks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Recipes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsItFavorite",
                table: "Recipes",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Recipes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IngredientId",
                table: "Recipes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "FavoriteRecipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RecipeId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteRecipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteRecipes_Recipes_RecipeId1",
                        column: x => x.RecipeId1,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FavoriteRecipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteRecipes_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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
                columns: new[] { "CategoryId", "CreatedDate", "IngredientId" },
                values: new object[] { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5114), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"),
                columns: new[] { "CategoryId", "CreatedDate", "IngredientId" },
                values: new object[] { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5122), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1") });

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
                columns: new[] { "CreatedDate", "UserFK" },
                values: new object[] { new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5089), 0 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"),
                columns: new[] { "CreatedDate", "UserFK" },
                values: new object[] { new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5092), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"),
                columns: new[] { "CreatedDate", "RecipeId" },
                values: new object[] { new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5063), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"),
                columns: new[] { "CreatedDate", "RecipeId" },
                values: new object[] { new DateTime(2023, 11, 9, 18, 7, 53, 118, DateTimeKind.Utc).AddTicks(5065), null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RecipeId",
                table: "Users",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_UserId",
                table: "Stocks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRecipes_RecipeId",
                table: "FavoriteRecipes",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRecipes_RecipeId1",
                table: "FavoriteRecipes",
                column: "RecipeId1");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRecipes_UserId",
                table: "FavoriteRecipes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRecipes_UserId1",
                table: "FavoriteRecipes",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Recipes_RecipeId",
                table: "Users",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");
        }
    }
}
