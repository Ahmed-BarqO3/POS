using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common;
using POS.Infastructure;

namespace POW.Winfom;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var services = new ServiceCollection();
        ConfigureService(services);
        

        using ServiceProvider serviceProvider = services.BuildServiceProvider();
        var mainWindow = serviceProvider.GetRequiredService<frmSales>();

        Application.Run(mainWindow);
    }

    private static void ConfigureService(ServiceCollection services)
    {
        services.AddInfrastructure();
        services.AddApplication();
        services.AddTransient<frmSales>();
    }
}
