using Avalonia.Controls;
using Avalonia.Platform.Storage;
using PlotPlanner.Services.Interfaces;

namespace PlotPlanner.Services;

public class FileDialogService : IFileDialogService {
    /*private readonly Window _target;

    public FileDialogService(Window target) {
        _target = target;
    }*/
    
    public async Task<IStorageFile?> ShowOpenFileDialogAsync(Window parent) {
        var files = await parent.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions {
            Title = "Select project file",
            FileTypeFilter = [
                new FilePickerFileType("PlotPlanner Project Files") {
                    Patterns = ["*.ppproj"]
                }
            ],
            AllowMultiple = false,
        });
        
        if (files.Any()) {
            return files[0];
        }

        return null;
    }
    public async Task<IStorageFile?> ShowSaveFileDialogAsync(Window parent) {
        var file = await parent.StorageProvider.SaveFilePickerAsync(new FilePickerSaveOptions {
            Title = "Save project file",
            FileTypeChoices = [
                new FilePickerFileType("PlotPlanner Project Files") {
                    Patterns = ["*.ppproj"]
                }
            ],
            DefaultExtension = "ppproj",
            
        });
        return file;
    }
}