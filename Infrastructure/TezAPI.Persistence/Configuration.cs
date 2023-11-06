using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
             
                    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/TezAPI.Presentation"));
                    configurationManager.AddJsonFile("appsettings.json");
                

                return configurationManager.GetConnectionString("PostgreSQL");
            }





        }

    }
}
