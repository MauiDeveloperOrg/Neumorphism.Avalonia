using Android.Content;
using Avalonia;
using Avalonia.Android;
using Avalonia.ReactiveUI;
using ShowMeTheXaml;
using Application = Android.App.Application;

namespace Material.Demo.Android;

[Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
public class SplashActivity : AvaloniaSplashActivity<Neumorphism.Avalonia.Demo.Shared.App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
                   .UseReactiveUI()
                   .UseXamlDisplay();
    }

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
    }

    protected override void OnResume()
    {
        base.OnResume();

        StartActivity(new Intent(Application.Context, typeof(MainActivity)));
    }
}