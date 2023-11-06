using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class FavoriteRecipe: BaseEntity
    {
        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public User  user { get; set; }
        public Guid UserId { get; set; }
    }
}
