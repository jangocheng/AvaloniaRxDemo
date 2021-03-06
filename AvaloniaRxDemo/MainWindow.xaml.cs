﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaRxDemo.ViewModels;

namespace AvaloniaRxDemo
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.DataContext = ServiceLocator.Resolve<MainWindowVm>();
            this.AttachDevTools();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
