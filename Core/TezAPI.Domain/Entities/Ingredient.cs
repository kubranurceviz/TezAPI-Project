using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class Ingredient: BaseEntity
    {

        public string IngredientName { get; set; }
        public string IngredientType { get; set; }

        public int StockAmount { get; set; }
        public string Unit { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
        public ICollection<Stock> Stocks { get; set; }
       

    }
}
