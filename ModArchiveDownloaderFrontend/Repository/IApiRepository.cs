using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ModArchiveDownloaderFrontend.Models;

namespace ModArchiveDownloaderFrontend.Repository;

public interface IApiRepository
{
    Task<ObservableCollection<Module>> GetModules(string search);
}