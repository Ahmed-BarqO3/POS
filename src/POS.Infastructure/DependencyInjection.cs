using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Application.Interface;
using POS.Infastructure.Data;
using POS.Infastructure.Repositories;

namespace POS.Infastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<AppDbcontext>(context =>
        {
            context.UseSqlServer("Server=.;Database=POS;Trusted_Connection=True;TrustServerCertificate=True;");
        });
        services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        services.AddTransient<IUnitOfWork,UnitOfWork>();
        return services;
    }
}
