using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.Extensions.DependencyInjection;
using PlotPlanner.UI.ViewModels;

namespace PlotPlanner.UI.Views;

public partial class StartupWindow : Window {
    public StartupWindow() {
        InitializeComponent();
        DataContext = AppHost.Services.GetRequiredService<StartupWindowViewModel>();
    }
    
    private async void OpenFileButton_Click(object sender, RoutedEventArgs e)
    {
        if (DataContext is StartupWindowViewModel vm) {
            await vm.OpenFile(this);
        }
    }

    private async void NewFileButton_Click(object sender, RoutedEventArgs e) {
        if (DataContext is StartupWindowViewModel vm) {
            await vm.CreateNewFile(this);
        }
    }
}