namespace PlotPlanner.Core.Models;

public class Location {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public string CityOrRegion { get; set; }
    public string Description { get; set; }
    public Faction? Faction { get; set; }
    public string Notes { get; set; }
}