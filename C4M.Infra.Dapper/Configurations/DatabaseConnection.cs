using Microsoft.Extensions.Configuration;
using System.IO;

namespace C4M.Infra.Dapper.Configurations
{
    public static class DatabaseConnection
    {
        public static IConfiguration ConnectionConfiguration
        {
            get
            {
                var path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).ToString()}\\Infrastructure";
                IConfigurationRoot Configuration = new ConfigurationBuilder()
                    .SetBasePath(path)
                    .AddJsonFile("appsettings.json")
                    .Build();
                return Configuration;
            }
        }
    }
}
