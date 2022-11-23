using Avalonia.Controls;
using Avalonia.Interactivity;
using DialogHostAvalonia;
using Neumorphism.Avalonia.Demo.Models;
using Neumorphism.Avalonia.Demo.ViewModels;
using System.Diagnostics;

namespace Neumorphism.Avalonia.Demo.Pages
{
    public partial class DialogDemo : UserControl
    {
        public DialogDemo()
        {
            InitializeComponent();
            DataContext = new DialogDemoViewModel();
        }

        private async void OpenDialogWithView(object sender, RoutedEventArgs e)
        {
            await DialogHost.Show(this.Resources["Sample2View"]!, "MainDialogHost");
        }

        private async void OpenDialogWithModel(object sender, RoutedEventArgs e)
        {
            // View that associated with this model defined at DialogContentTemplate in DialogDemo.axaml
            await DialogHost.Show(new Sample2Model(new Random().Next(0, 100)), "MainDialogHost");
        }

        private void OpenMoreDialogHostExamples(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo() { FileName = "https://github.com/AvaloniaUtils/DialogHost.Avalonia", UseShellExecute = true });
        }
    }
}
