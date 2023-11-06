using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository
{
    public class FavRecipeWriteRepository : WriteRepository<FavoriteRecipe>, IFavRecipeWriteRepository

    {
        public FavRecipeWriteRepository(TezAPIDbContext context) : base(context)
        {
        }

       
    }
}
