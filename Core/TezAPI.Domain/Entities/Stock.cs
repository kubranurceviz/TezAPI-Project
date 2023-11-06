using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class Stock: BaseEntity
    {
        public Guid UserId { get; set; }
        public int StockAmount { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }



    }
}
