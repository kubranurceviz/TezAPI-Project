using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TezAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;
using TezAPI.Persistence.Repository;


namespace TezAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<TezAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);
            services.AddSingleton<ICategoryReadRepository, CategoryReadRepository>();
            services.AddSingleton<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddSingleton<IIngredientReadRepository, IngredientReadRepository>();
            services.AddSingleton<IIngredientWriteRepository, IngredientWriteRepository>();
            services.AddSingleton<IRecipeReadRepository, RecipeReadRepository>();
            services.AddSingleton<IRecipeWriteRepository, RecipeWriteRepository>();
            services.AddSingleton<IShoppingListReadRepository, ShoppingListReadRepository>();
            services.AddSingleton<IShoppingListWriteRepository, ShoppingListWriteRepository>();
            services.AddSingleton<IStockReadRepository, StockReadRepository>();
            services.AddSingleton<IStockWriteRepository, StockWriteRepository>();
            services.AddSingleton<IUserReadRepository, UserReadRepository>();
            services.AddSingleton<IUserWriteRepository, UserWriteRepository>();




        }
    }
}
