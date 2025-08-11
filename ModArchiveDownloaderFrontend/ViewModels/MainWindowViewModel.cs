using ModArchiveDownloaderFrontend.Models;

namespace ModArchiveDownloaderFrontend.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";
    public Module[] Items { get; set; } = new[]
    {
        new Module { FileName = "test.txt", ModuleCode = "test" },
        new Module { FileName = "thunder_the_secret.symmod", ModuleCode = "thunder_the_secret" },
        new Module { FileName = "test.txt", ModuleCode = "test" },
        new Module { FileName = "thunder_the_secret.symmod", ModuleCode = "thunder_the_secret" },
        new Module { FileName = "test.txt", ModuleCode = "test" },
        new Module { FileName = "thunder_the_secret.symmod", ModuleCode = "thunder_the_secret" },
        new Module { FileName = "test.txt", ModuleCode = "test" },
        new Module { FileName = "thunder_the_secret.symmod", ModuleCode = "thunder_the_secret" },
        new Module { FileName = "test.txt", ModuleCode = "test" },
        new Module { FileName = "thunder_the_secret.symmod", ModuleCode = "thunder_the_secret" },
        new Module { FileName = "test.txt", ModuleCode = "test" },
        new Module { FileName = "thunder_the_secret.symmod", ModuleCode = "thunder_the_secret" }
    };
    public string ErrorMessage { get; } = "Unable to find";
    public string SearchBeginning { get; } = "Get Started by searching at the top left";
    
    public bool HasNoItems => Items.Length == 0 || Items == null;
}