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
    public class ShoppingListReadRepository : ReadRepository<ShoppingList>, IShoppingListReadRepository

    {
        public ShoppingListReadRepository(TezAPIDbContext context) : base(context)
        {
        }
    }
}
