using AspNetMonsters.ApplicationInsights.TelemetryInitializers;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetMonsters.ApplicationInsights.AspNetCore
{
    public static class ServiceCollectionExtensions
    {
        
        public static IServiceCollection AddCloudRoleNameInitializer(this IServiceCollection serviceCollection, string cloudRoleName)
        {
            return serviceCollection
                    .AddSingleton<ITelemetryInitializer>(
                            (_) => new CloudRoleNameTelemetryInitializer(cloudRoleName));
        }
    }
}