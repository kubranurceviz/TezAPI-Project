﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class Recipe: BaseEntity
    {

        //public Guid IngredientId { get; set; }
        //public Guid CategoryId { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public string RecipeText { get; set; }
        public bool? IsItFavorite { get; set; }
        public int CookingTime { get; set; }
        public int PreparationTime { get; set; }
        public User Writer { get; set; }
        public ICollection<Category> Categories { get; set; } = new List<Category>();
      
     
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
       // public ICollection<FavoriteRecipe> favoriteRecipes { get; set; } = new List<FavoriteRecipe>();
     
    }
}
