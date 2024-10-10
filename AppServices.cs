using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleCalculator;

public static class AppServices
{
    private static ServiceProvider _serviceProvider;   
    static AppServices()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)!.FullName)
            .AddJsonFile("appsettings.json")
            .Build();

        var serviceCollection = new ServiceCollection();

        serviceCollection.AddSingleton<IConfiguration>(configuration);
        serviceCollection.AddSingleton<ConsoleMenu>();

        _serviceProvider = serviceCollection.BuildServiceProvider();
    }

    public static ServiceProvider Provider()
    {
        return _serviceProvider;
    }
}
