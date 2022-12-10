using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Data.EF
{
    public class MonoleakDbContextFactory : IDesignTimeDbContextFactory<MonoleakDbContext>
    {
        public MonoleakDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();
            var connectionString = configuration.GetConnectionString("MonoleakDb");

            var optionsBuilder = new DbContextOptionsBuilder<MonoleakDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MonoleakDbContext(optionsBuilder.Options);
        }
    }
}
