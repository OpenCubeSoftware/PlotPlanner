using PlotPlanner.Core.Models;
using PlotPlanner.Data.Repositories.Interfaces;

namespace PlotPlanner.Data.Repositories;

public class CharacterRepository : ICharacterRepository {
    private List<Character> _data = new();
    public void SetData(List<Character> items) => _data = items;
    public List<Character> GetData() => _data;
}
