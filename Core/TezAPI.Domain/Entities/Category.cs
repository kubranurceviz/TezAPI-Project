using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}