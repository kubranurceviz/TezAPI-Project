﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TezAPI.Persistence.Contexts;

#nullable disable

namespace TezAPI.Persistence.Migrations
{
    [DbContext(typeof(TezAPIDbContext))]
    [Migration("20231109173553_zehra")]
    partial class zehra
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CategoryRecipe", b =>
                {
                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecipesId")
                        .HasColumnType("uuid");

                    b.HasKey("CategoriesId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("CategoryRecipe");
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.Property<Guid>("IngredientsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecipesId")
                        .HasColumnType("uuid");

                    b.HasKey("IngredientsId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("IngredientRecipe");
                });

            modelBuilder.Entity("IngredientStock", b =>
                {
                    b.Property<Guid>("IngredientsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StocksId")
                        .HasColumnType("uuid");

                    b.HasKey("IngredientsId", "StocksId");

                    b.HasIndex("StocksId");

                    b.ToTable("IngredientStock");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                            CategoryName = "Deniz Ürünü",
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2019)
                        },
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                            CategoryName = "Hatay Mutfağı",
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2022)
                        });
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.FavoriteRecipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("RecipeId1")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserId1")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.HasIndex("RecipeId1");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("FavoriteRecipes");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IngredientType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StockAmount")
                        .HasColumnType("integer");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2331),
                            IngredientName = "domates",
                            IngredientType = "sebze",
                            StockAmount = 2,
                            Unit = "kilo"
                        },
                        new
                        {
                            Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2341),
                            IngredientName = "krema",
                            IngredientType = "süt ürünü",
                            StockAmount = 1,
                            Unit = "adet"
                        },
                        new
                        {
                            Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"),
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2345),
                            IngredientName = "un",
                            IngredientType = "tahıl ürünleri",
                            StockAmount = 500,
                            Unit = "gram"
                        });
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<int>("CookingTime")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsItFavorite")
                        .HasColumnType("boolean");

                    b.Property<int>("PreparationTime")
                        .HasColumnType("integer");

                    b.Property<string>("RecipeText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"),
                            CategoryId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                            CookingTime = 10,
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2482),
                            IngredientId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                            IsItFavorite = false,
                            PreparationTime = 10,
                            RecipeText = "a",
                            UserId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10")
                        },
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"),
                            CategoryId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                            CookingTime = 30,
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2492),
                            IngredientId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
                            IsItFavorite = false,
                            PreparationTime = 10,
                            RecipeText = "a",
                            UserId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10")
                        });
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.ShoppingList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ShoppingListText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("ShoppingLists");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"),
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2532),
                            ShoppingListText = "a",
                            Title = "a",
                            UserId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10")
                        },
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"),
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2539),
                            ShoppingListText = "b",
                            Title = "a",
                            UserId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11")
                        });
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Stock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("StockAmount")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"),
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2434),
                            StockAmount = 5,
                            UserId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10")
                        },
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"),
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2439),
                            StockAmount = 500,
                            UserId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11")
                        });
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("RecipeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"),
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2391)
                        },
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"),
                            CreatedDate = new DateTime(2023, 11, 9, 17, 35, 52, 701, DateTimeKind.Utc).AddTicks(2394)
                        });
                });

            modelBuilder.Entity("CategoryRecipe", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IngredientStock", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.Stock", null)
                        .WithMany()
                        .HasForeignKey("StocksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.FavoriteRecipe", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.Recipe", null)
                        .WithMany("favoriteRecipes")
                        .HasForeignKey("RecipeId1");

                    b.HasOne("TezAPI.Domain.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TezAPI.Domain.Entities.User", null)
                        .WithMany("FavoriteRecipes")
                        .HasForeignKey("UserId1");

                    b.Navigation("Recipe");

                    b.Navigation("user");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Recipe", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.User", "Writer")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.User", b =>
                {
                    b.HasOne("TezAPI.Domain.Entities.Recipe", null)
                        .WithMany("Users")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.Recipe", b =>
                {
                    b.Navigation("Users");

                    b.Navigation("favoriteRecipes");
                });

            modelBuilder.Entity("TezAPI.Domain.Entities.User", b =>
                {
                    b.Navigation("FavoriteRecipes");

                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
