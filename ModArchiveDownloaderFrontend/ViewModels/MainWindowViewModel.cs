using ModArchiveDownloaderFrontend.Models;

namespace ModArchiveDownloaderFrontend.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
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
}