using Avalonia.Controls;
using Avalonia.Interactivity;
using Neumorphism.Avalonia.Demo.Models;

namespace Neumorphism.Avalonia.Demo.Pages;

public partial class SideSheetDemo : UserControl
{
    public SideSheetDemo()
    {
        InitializeComponent();
    }

    private void CloseSideInfoButton_OnClick(object sender, RoutedEventArgs e)
    {
        var vm = DataContext as SideSheetDemoViewModel;
        if (vm == null)
            return;

        vm.SideInfoOpened = false;
    }

    private void OpenSideInfoButton_OnClick(object sender, RoutedEventArgs e)
    {
        var vm = DataContext as SideSheetDemoViewModel;
        if (vm == null)
            return;

        vm.SideInfoOpened = true;
    }
}
