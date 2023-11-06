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

namespace TezAPI.Persistence.Contexts
{
    public class TezAPIDbContext: DbContext
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

        }



    }
}
