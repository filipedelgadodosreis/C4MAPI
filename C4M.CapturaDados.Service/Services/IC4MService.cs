using System.Threading.Tasks;
using static C4M.BackgroundTasks.Settings.BackgroundTaskSettings;

namespace C4M.BackgroundTasks.Services
{
    public interface IC4MService
    {
        Task<string> ObterDadosCompletosTodosOsClientes(C4MSettings dados);
    }
}
