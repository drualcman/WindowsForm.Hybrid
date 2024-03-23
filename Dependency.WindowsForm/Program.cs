using Microsoft.Extensions.DependencyInjection;

namespace Dependency.WindowsForm;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationHost.Services.AddSingleton<ProdcutRepository>();
        ApplicationHost.Build();

        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}