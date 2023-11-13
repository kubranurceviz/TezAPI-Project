using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities
{
    public class ShoppingList: BaseEntity
    {
        public Guid UserId { get; set; }
        public User user{ get; set; }
        public string Title { get; set; }
        public string ShoppingListText { get; set; }

        
    }
}
