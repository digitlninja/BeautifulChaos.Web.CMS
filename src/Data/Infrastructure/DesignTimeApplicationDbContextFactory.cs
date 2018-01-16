using System.IO;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Data.Infrastructure
{
    public class DesignTimeBeautifulChaosContextFactory : IDesignTimeDbContextFactory<BeautifulChaosContext>
    {
        public BeautifulChaosContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BeautifulChaosContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new BeautifulChaosContext(builder.Options);
        }
    }



}
