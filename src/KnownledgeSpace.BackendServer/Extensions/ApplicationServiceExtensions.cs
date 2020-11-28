using KnowledgeSpace.BackendServer.Data;
using Microsoft.Extensions.DependencyInjection;

namespace KnownledgeSpace.BackendServer.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<DbInitializer>();
            return services;
        }
    }
}