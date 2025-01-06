using Microsoft.Extensions.DependencyInjection;
using POS.Application.Common;
using POS.Infastructure;
using POW.Winfom.Forms.Products;

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
        var MainForm = serviceProvider.GetRequiredService<frmAddProduct>();

        Application.Run(MainForm);
    }

    private static void ConfigureService(ServiceCollection services)
    {


        services.AddInfrastructure();
        services.AddApplication();
        var assembly = typeof(frmMain).Assembly;

        services.Scan(s =>
        {
            s.FromAssemblies(assembly)
             .AddClasses(c => c.AssignableTo<Form>()) // Register all classes that inherit from Form
             .AsSelf()
             .WithTransientLifetime();
        });
    }
}
