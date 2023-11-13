using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class User: BaseEntity
    {
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
         public ICollection<Recipe> FavoriteRecipes { get; set; } =new List<Recipe>();
        public ShoppingList shoppingList { get; set; }
        public Stock stock { get; set; }
    



    }
}
