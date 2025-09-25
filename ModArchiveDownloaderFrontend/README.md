# ModArchive Avalonia Downloader
this is a frontend for the go webscraper that i built

see : https://github.com/med-taha-fourati/mod_browser_dl

# Configuration
there is a file under `\Services` called `ApiService.cs` that contains the url
```csharp
public static string ApiUrl { get; set; } = "http://localhost:3000";
```

set it accordingly if you're self hosting or something
