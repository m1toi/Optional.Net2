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

            services.AddScoped<IAuthenticationService, AuthenticationService>();

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRoleRepository, RoleRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}
