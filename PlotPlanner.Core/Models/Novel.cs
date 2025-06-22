namespace PlotPlanner.Core.Models;

public class Novel {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Summary { get; set; }
    public string Premise { get; set; }
    public string Setting { get; set; }
    public string Synopsis { get; set; }
    public IEnumerable<Chapter> Chapters { get; set; }
}