using System.IO.Compression;
using System.Text.Json;
using Microsoft.CodeAnalysis;
using PlotPlanner.Core.Models;
using PlotPlanner.Data.Repositories.Interfaces;
using PlotPlanner.Services.Interfaces;

namespace PlotPlanner.Services;

public class ProjectLoader : IProjectLoader {
    private readonly ICharacterRepository _characterRepo;

    public ProjectLoader(ICharacterRepository characterRepo) {
        _characterRepo = characterRepo;
    }

    public async Task LoadProjectAsync(string filePath) {
        using var zip = ZipFile.OpenRead(filePath);
        _characterRepo.SetData(await LoadJson<List<Character>>(zip, "characters.json"));
    }

    public async Task LoadProjectAsync(Project project) {
        throw new NotImplementedException();
    }

    public async Task SaveProjectAsync(string filePath) {
        if (File.Exists(filePath)) File.Delete(filePath); // todo: change to rename and only delete after saving
        using var zip = ZipFile.Open(filePath, ZipArchiveMode.Create);
        AddJson(zip, "characters.json", _characterRepo.GetData());
    }

    public async Task CreateNewProjectAsync(string filePath) {
        if (File.Exists(filePath)) 
            Console.WriteLine("File already exists"); // Todo: show warning
        using var zip = ZipFile.OpenRead(filePath);
        AddJson(zip, "characters.json", new { Characters = new List<Character>() });
    }

    private async Task<T> LoadJson<T>(ZipArchive zip, string name) {
        var entry = zip.GetEntry(name) ?? throw new FileNotFoundException(name);
        using var stream = entry.Open();
        return await JsonSerializer.DeserializeAsync<T>(stream) ?? throw new InvalidDataException(name);
    }

    private void AddJson<T>(ZipArchive zip, string name, T data) {
        var entry = zip.CreateEntry(name);
        using var stream = new StreamWriter(entry.Open());
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true});
        stream.Write(json);
    }
}