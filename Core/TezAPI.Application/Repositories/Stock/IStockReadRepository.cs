using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities;

namespace TezAPI.Application.Repositories
{
    public interface IStockReadRepository: IReadRepository<Stock>
    {
    }
}
