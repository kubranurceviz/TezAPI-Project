using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Persistence.Contexts;
using Microsoft.Extensions.Configuration;


namespace TezAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TezAPIDbContext>
    {
        public TezAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TezAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
};
