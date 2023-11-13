using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class Stock: BaseEntity
    {

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User user { get; set; }
        public int StockAmount { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();



    }
}
