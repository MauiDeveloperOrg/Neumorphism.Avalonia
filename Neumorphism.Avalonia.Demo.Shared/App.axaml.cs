﻿using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace Neumorphism.Avalonia.Demo.Shared;

/// <summary>
/// Inpiration examples :
/// https://bashooka.com/inspiration/neumorphism-ui-design-examples/
/// </summary>
public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    // Your application's entry point. Here you can initialize your MVVM framework, DI container, etc.
    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();

            desktop.Startup += Desktop_Startup;
            desktop.Exit += Desktop_Exit;
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView();
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void Desktop_Startup(object sender, ControlledApplicationLifetimeStartupEventArgs e)
    {

    }

    private void Desktop_Exit(object sender, ControlledApplicationLifetimeExitEventArgs e)
    {

    }
}