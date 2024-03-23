using Microsoft.Extensions.DependencyInjection;

namespace Dependency.WindowsForm;
internal static class ApplicationHost
{
    static ServiceCollection RegisteredServices = new();

    public static IServiceCollection Services => RegisteredServices;

    static IServiceProvider Provider;

    public static void Build()
    {
        Provider = Services.BuildServiceProvider();
    }

    public static T GetRequiredService<T>() => Provider.GetRequiredService<T>();
    public static T GetService<T>() => Provider.GetService<T>();

}
