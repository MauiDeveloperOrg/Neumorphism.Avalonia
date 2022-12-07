using Avalonia;
using Neumorphism.Avalonia.Demo.Shared;
using ShowMeTheXaml;

namespace Neumorphism.Avalonia.Demo.Desktop
{
    internal class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
        {
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
        {
            return AppBuilder.Configure<App>()
                             
                             .UsePlatformDetect()
                             .With(new X11PlatformOptions
                             {
                                 EnableMultiTouch = true,
                                 UseDBusMenu = true,
                                 EnableIme = true
                             })
                             .With(new Win32PlatformOptions
                             {
                                 UseCompositor = false
                             })
                             .With(new X11PlatformOptions
                             {
                                 UseCompositor = false
                             })
                             .With(new AvaloniaNativePlatformOptions
                             {
                                 UseCompositor = false
                             })
                             .UseXamlDisplay()
                             .LogToTrace();
        }
    }
}