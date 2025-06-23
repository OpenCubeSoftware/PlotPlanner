using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.Input;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
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
    }

    public async Task CreateNewFile(Window parentWindow) {
        IStorageFile file = await _fileDialogService.ShowSaveFileDialogAsync(parentWindow);
        if (file != null) {
            await _projectLoader.CreateNewProjectAsync(file.Path.AbsolutePath);
        }
    }


}