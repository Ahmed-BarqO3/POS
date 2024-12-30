using Microsoft.Extensions.DependencyInjection;

namespace POS.Application.Common;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        
        services.AddMediator(options =>
        {
            options.Namespace = "LMS.Application";
            options.ServiceLifetime = ServiceLifetime.Transient;
        });

        return services;
    }
}
