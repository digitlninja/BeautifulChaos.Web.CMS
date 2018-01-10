using System;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Infrastructure.Bootstrap
{
    public static class EntityFrameworkServices
    {
        public static IServiceCollection AddEntityFrameworkServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            var connectionString = @"Server=(LocalDb)\MSSQLLocalDB;Database=BeautifulChaos;Integrated Security=true";

            services.AddEntityFrameworkSqlServer();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            return services;
        }
    }
}
