using System.Text.Json;
using System.Text.Json.Serialization;
using WalletManager.Service;

public class JsonDataService
{
    private readonly string _dataFilePath;

    public JsonDataService()
    {
        // Use a suitable path for your MAUI Hybrid application
        _dataFilePath = Path.Combine(FileSystem.AppDataDirectory, "data.json");
    }

    // Load data from JSON file
    public async Task<DataStore> LoadDataAsync()
    {
        if (!File.Exists(_dataFilePath))
        {
            var initialData = new DataStore();
            await SaveDataAsync(initialData);
            return initialData;
        }

        var json = await File.ReadAllTextAsync(_dataFilePath);
        return JsonSerializer.Deserialize<DataStore>(json) ?? new DataStore();
    }

    // Save data to JSON file
    public async Task SaveDataAsync(DataStore data)
    {
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        await File.WriteAllTextAsync(_dataFilePath, json);
    }
}
