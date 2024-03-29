using LibraryManagementSystem.App.Configurations;
using LibraryManagementSystem.App.Configurations.Seeder;
using LibraryManagementSystem.Infrastructure.Database;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LibraryManagementSystem.App;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;
        host.MigrateDbContext<LibraryDbContext>((context, service) =>
        {
            LibraryContextSeed.SeedAsync(context).Wait();
        });
        Application.Run(ServiceProvider.GetRequiredService<LibraryManagementSystemUI>());
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<LibraryDbContext>();
                services.AddTransient<LibraryManagementSystemUI>();
                services.AddMediatR(typeof(Program).Assembly);
            });
    }
}