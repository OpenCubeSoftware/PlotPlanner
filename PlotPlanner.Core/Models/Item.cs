namespace PlotPlanner.Core.Models;

public class Item {
    public int Id { get; set; }
    public string Name { get; set; }
    public Character? BelongsTo { get; set; }
    public Faction? Faction { get; set; }
    public string Description { get; set; }
    public string Importance { get; set; }
    public string Notes { get; set; }
    
}