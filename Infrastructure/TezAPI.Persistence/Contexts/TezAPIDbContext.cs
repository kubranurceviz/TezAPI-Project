using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TezAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;

namespace TezAPI.Persistence.Contexts
{
    public class TezAPIDbContext : DbContext
    {
        public TezAPIDbContext(DbContextOptions options) : base(options)
        {
        }


        //public TezAPIDbContext CreateDbContex(string[] args)
        //{
        //    ConfigurationManager configurationManager = new();
        //    configurationManager.SetBasePath("");
        //    configurationManager.AddJsonFile("appsettings.json");

        //    DbContextOptionsBuilder<TezAPIDbContext> dbContextOptionsBuilder = new();
        //    dbContextOptionsBuilder.UseNpgsql("PostgreSQL");
        //    return new(dbContextOptionsBuilder.Options);

        //}


        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<FavoriteRecipe> FavoriteRecipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
            .HasOne(r => r.Writer)
            .WithMany(u => u.Recipes)
            .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<FavoriteRecipe>()
              .HasOne(fr => fr.Recipe)
              .WithMany()
              .HasForeignKey(fr => fr.RecipeId);


            modelBuilder.Entity<FavoriteRecipe>()
              .HasOne(fr => fr.user)
              .WithMany()
              .HasForeignKey(fr => fr.UserId);

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), CreatedDate = DateTime.UtcNow, CategoryName = "Deniz Ürünü" },
                 new Category() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), CreatedDate = DateTime.UtcNow, CategoryName = "Hatay Mutfağı" });

            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient() { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), CreatedDate = DateTime.UtcNow,StockAmount=2,IngredientName="domates", IngredientType="sebze",Unit="kilo"},
                 new Ingredient() { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"), CreatedDate = DateTime.UtcNow, StockAmount = 1, IngredientName = "krema", IngredientType = "süt ürünü", Unit = "adet" },
                  new Ingredient() { Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), CreatedDate = DateTime.UtcNow, StockAmount = 500, IngredientName = "un", IngredientType = "tahıl ürünleri", Unit = "gram" }
                );

            modelBuilder.Entity<User>().HasData(
               new User() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"), CreatedDate = DateTime.UtcNow },
                new User() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"), CreatedDate = DateTime.UtcNow  });

            modelBuilder.Entity<Stock>().HasData(
                           new Stock() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa20"), CreatedDate = DateTime.UtcNow,StockAmount=5,UserId= Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") },
                            new Stock() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa21"), CreatedDate = DateTime.UtcNow,StockAmount=500,UserId=Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11") });
          
            
            modelBuilder.Entity<Recipe>().HasData(
            new Recipe() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa100"), CreatedDate = DateTime.UtcNow, CategoryId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),CookingTime=10,    IngredientId = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),IsItFavorite=false,PreparationTime=10,RecipeText="a",UserId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") },
             new Recipe() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa101"), CreatedDate = DateTime.UtcNow, CategoryId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa1"), CookingTime=30 , IngredientId=  Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1") ,IsItFavorite=false,PreparationTime=10 ,RecipeText="a",UserId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") });

            modelBuilder.Entity<ShoppingList>().HasData(
                           new ShoppingList() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa202"), CreatedDate = DateTime.UtcNow, ShoppingListText="a", UserId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") ,Title="a"},
                            new ShoppingList() { Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaa203"), CreatedDate = DateTime.UtcNow,ShoppingListText="b", UserId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11") ,Title = "a" });


        }



    }
}
