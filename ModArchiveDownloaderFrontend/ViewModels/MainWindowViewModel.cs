using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ModArchiveDownloaderFrontend.Models;
using ModArchiveDownloaderFrontend.Repository;

namespace ModArchiveDownloaderFrontend.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public IAsyncRelayCommand SearchCommand { get; }
    public MainWindowViewModel()
    {
        SearchCommand = new AsyncRelayCommand(FetchModules);
    }
    public string Greeting { get; } = "Welcome to Avalonia!";
    
    [ObservableProperty]
    private string _searchText = string.Empty;

    [ObservableProperty] 
    private ObservableCollection<Module> _items = new();
    public string ErrorMessage { get; } = "Unable to find";
    public string SearchBeginning { get; } = "Get Started by searching at the top left";
    public bool HasNoItems => Items.Count == 0;

    private async Task FetchModules()
    {
        var modules = await new ApiRepository().GetModules(SearchText ?? string.Empty);

        Items = modules;
    }
}