using System.Collections.Generic;

namespace PlotPlanner.Core.Models;

public enum SceneType {
    Active,
    Reactive
}

public class Scene {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Synopsis { get; set; }
    public Location Location { get; set; }
    public IEnumerable<Character> Characters { get; set; }
    public Character? PovCharacter { get; set; }
    public string? Goal { get; set; }
    public string? Conflict { get; set; }
    public string? Outcome { get; set; }
    public SceneType? SceneType { get; set; }
    public int Relevance { get; set; }
    public int Humour { get; set; }
    public int Tension { get; set; }
    public int SexualTension { get; set; }
}