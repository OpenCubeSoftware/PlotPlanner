using PlotPlanner.Core.Models;

namespace PlotPlanner.Data.Repositories.Interfaces;

public interface ICharacterRepository {
    void SetData(List<Character> characters);
    List<Character> GetData();
}