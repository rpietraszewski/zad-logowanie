using Years.Interfaces;
using Years.Repositories;
using Years.Services;

namespace Years
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this
        IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
    }
}
