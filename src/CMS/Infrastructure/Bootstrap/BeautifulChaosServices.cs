using System;
using CMS.Interfaces;
using CMS.Repositories;
using CMS.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CMS.Infrastructure.Bootstrap
{
    public static class BeautifulChaosServices
    {
        public static IServiceCollection AddBeautifulChaosServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));
            
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<IServicesPageRepository, ServicesPageRepository>();
            services.AddScoped<IWorkRepository, WorkRepository>();

            return services;
        }
    }
}
