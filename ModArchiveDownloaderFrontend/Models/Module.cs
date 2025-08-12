using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using ModArchiveDownloaderFrontend.Repository;

namespace ModArchiveDownloaderFrontend.Models;

public class Module
{
    public IAsyncRelayCommand DownloadCommand { get; }
    public String FileName { get; set; }
    public String ModuleCode { get; set; }

    public Module()
    {
        DownloadCommand = new AsyncRelayCommand(DownloadModule);
    }
    
    private async Task DownloadModule()
    {
        if (string.IsNullOrEmpty(ModuleCode)) return;
        await new ApiRepository().DownloadModule(int.Parse(ModuleCode));
    }
}