using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using PlotPlanner.UI.ViewModels;
using PlotPlanner.UI.Views;

namespace PlotPlanner.UI.Services.Interfaces;

public class NavigationService : INavigationService {
    private readonly Window _currentWindow;

    public NavigationService(Window currentWindow) {
        _currentWindow = currentWindow;
    }
    
    public async Task NavigateToMainWindowAsync() {
        MainWindowViewModel mainViewModel = new MainWindowViewModel();
        MainWindow mainWindow = new MainWindow {
            DataContext = mainViewModel
        };

        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            desktop.MainWindow = mainWindow;
            mainWindow.Show();
            _currentWindow.Close();
        }
    }

    public void Exit() {
        _currentWindow.Close();
    }
}