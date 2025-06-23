using System.Threading.Tasks;

namespace PlotPlanner.UI.Services;

public interface INavigationService {
    Task NavigateToMainWindowAsync();
    void Exit();
}