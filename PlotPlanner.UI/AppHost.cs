using System;
using Microsoft.Extensions.DependencyInjection;
using PlotPlanner.Data.Repositories;
using PlotPlanner.Data.Repositories.Interfaces;
using PlotPlanner.Services;
using PlotPlanner.Services.Interfaces;
using PlotPlanner.UI.Services;
using PlotPlanner.UI.Services.Interfaces;
using PlotPlanner.UI.ViewModels;

namespace PlotPlanner.UI;

public static class AppHost {
    public static IServiceProvider Services { get; private set; }

    public static void Configure() {
        ServiceCollection services = new ServiceCollection();
        
        // Register repos
        services.AddSingleton<ICharacterRepository, CharacterRepository>();
        
        services.AddSingleton<IFileDialogService, FileDialogService>();
        services.AddSingleton<IProjectLoader, ProjectLoader>();
        services.AddSingleton<INavigationService, NavigationService>();
        
        // Register ViewModels
        services.AddTransient<StartupWindowViewModel>();
        services.AddTransient<MainWindowViewModel>();
        
        Services = services.BuildServiceProvider();
    }
}