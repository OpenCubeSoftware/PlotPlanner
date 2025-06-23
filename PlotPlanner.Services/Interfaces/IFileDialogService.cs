using Avalonia.Controls;
using Avalonia.Platform.Storage;

namespace PlotPlanner.Services.Interfaces;

public interface IFileDialogService {
    public Task<IStorageFile?> ShowOpenFileDialogAsync(Window parent);
    public Task<IStorageFile?> ShowSaveFileDialogAsync(Window parent);
}