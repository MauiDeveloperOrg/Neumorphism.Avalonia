using Avalonia;
using Avalonia.ReactiveUI;
using Avalonia.Web;
using Neumorphism.Avalonia.Demo.Shared;
using ShowMeTheXaml;
using System.Runtime.Versioning;

[assembly: SupportedOSPlatform("browser")]

internal partial class Program
{
    private static void Main(string[] args) => BuildAvaloniaApp()
        .UseReactiveUI()
        .UseXamlDisplay()
        .SetupBrowserApp("out");

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>();
}