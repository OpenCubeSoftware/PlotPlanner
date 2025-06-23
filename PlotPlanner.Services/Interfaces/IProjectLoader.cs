using Microsoft.CodeAnalysis;

namespace PlotPlanner.Services.Interfaces;

public interface IProjectLoader {
    Task LoadProjectAsync(string filePath);
    Task SaveProjectAsync(string filePath);
    Task CreateNewProjectAsync(string filePath);
}