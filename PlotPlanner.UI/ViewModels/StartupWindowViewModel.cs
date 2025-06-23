using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using PlotPlanner.Services.Interfaces;

namespace PlotPlanner.UI.ViewModels;

public partial class StartupWindowViewModel : ViewModelBase {
    
    private readonly IFileDialogService _fileDialogService;
    private readonly IProjectLoader _projectLoader;
    
    public StartupWindowViewModel(IFileDialogService fileDialogService, IProjectLoader projectLoader) {
        _fileDialogService = fileDialogService;
        _projectLoader = projectLoader;
    }
    
    public async Task OpenFile(Window parentWindow) {
        IStorageFile file = await _fileDialogService.ShowOpenFileDialogAsync(parentWindow);
        Console.Write("Big purrs");
    }

    public async Task CreateNewFile(Window parentWindow) {
        IStorageFile file = await _fileDialogService.ShowSaveFileDialogAsync(parentWindow);
        if (file != null) {
            await _projectLoader.CreateNewProjectAsync(file.Path.AbsolutePath);
        }
    }

    // [RelayCommand]
    // private async void New(Window parentWindow) {
    //     
    // }
}