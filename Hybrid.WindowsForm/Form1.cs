using Hybrid.BlazorClient;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Hybrid.WindowsForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        InitializeWebView();
    }

    void InitializeWebView()
    {
        HostApplicationBuilder builder = Host.CreateApplicationBuilder();
        builder.Services.AddWindowsFormsBlazorWebView();         
        blazorWebView1.HostPage = "wwwroot\\index.html";
        blazorWebView1.Services = builder.Services.BuildServiceProvider();
        blazorWebView1.RootComponents.Add<App>("#app");
        blazorWebView1.RootComponents.Add<HeadOutlet>("head::after");
    }
}
