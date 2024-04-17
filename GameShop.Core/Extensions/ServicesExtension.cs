using GameShop.Core.Services;
using GameShop.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GameShop.Core.Extensions
{
    public static class ServicesExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IDeveloperService, DeveloperService>();
            services.AddScoped<IDeveloperRepository, DeveloperRepository>();
        }
    }
}
