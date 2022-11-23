using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace Neumorphism.Avalonia.Demo.Shared;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.AttachDevTools(KeyGesture.Parse("Shift+F12"));
    }
}