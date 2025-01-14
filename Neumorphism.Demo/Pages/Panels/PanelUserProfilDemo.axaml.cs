﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Neumorphism.Avalonia.Demo.ViewModels.Panels;

namespace Neumorphism.Avalonia.Demo.Pages.Panels
{
    public class PanelUserProfilDemo : UserControl
    {
        public PanelUserProfilDemo()
        {
            this.InitializeComponent();

            this.DataContext = new PanelUserProfilDemoViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}