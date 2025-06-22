namespace PlotPlanner.Core.Models;

public class Chapter {
    public int Id { get; set; }
    public string Title { get; set; }
    public Character PovCharacter { get; set; }
    public IEnumerable<Scene> Scenes { get; set; }
    public string Notes { get; set; }
}