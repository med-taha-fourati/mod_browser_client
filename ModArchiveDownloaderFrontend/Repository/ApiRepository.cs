using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ModArchiveDownloaderFrontend.Models;

namespace ModArchiveDownloaderFrontend.Repository;

public class ModuleResult
{
    public string Code { get; set; }
    public string Name { get; set; }
}
public class ApiResponse
{
    public string Index { get; set; }
    public string Query { get; set; }
    public List<ModuleResult> Result { get; set; }
}

public class ApiRepository : IApiRepository
{
    public async Task<ObservableCollection<Module>> GetModules(string search)
    {
        var url = $"http://localhost:3000/browse?search={Uri.EscapeDataString(search)}";
        using var httpClient = new HttpClient();

        try
        {
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            var apiResponse = JsonSerializer.Deserialize<ApiResponse>(jsonString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            
            if (apiResponse?.Result != null)
            {
                var modules = apiResponse.Result.Select(r => new Module
                {
                    ModuleCode = r.Code,
                    FileName = r.Name
                });

                return new ObservableCollection<Module>(modules);
            }
            return new ObservableCollection<Module>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching modules: {ex.Message}");
            return new ObservableCollection<Module>();
        }
    }
}