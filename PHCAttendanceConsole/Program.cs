using System.Net.Http.Json;
using System.Text.Json;
using Domain.AttendanceServiceRespDTO;
using PHCAttendanceConsole;

const string successCode = "001";
const string dataNotFoundCode = "003";

var logDirectory = Path.Combine(AppContext.BaseDirectory, "Logs");
var updatedLogCount = 0;
var fetchedLogCount = 0;
var jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
{
    PropertyNameCaseInsensitive = true
};

try
{
    var options = await LoadOptionsAsync();
    var configuredBaseUrl = Environment.GetEnvironmentVariable("PHC_ATTENDANCE_API_BASE_URL")
        ?? options.ApiBaseUrl;
    if (!Uri.TryCreate(configuredBaseUrl, UriKind.Absolute, out var baseUri))
    {
        throw new InvalidOperationException("ApiBaseUrl must be a valid absolute URL.");
    }

    using var httpClient = new HttpClient
    {
        BaseAddress = new Uri(baseUri.AbsoluteUri.TrimEnd('/') + "/")
    };
    if (!string.IsNullOrWhiteSpace(options.ApiKey))
    {
        httpClient.DefaultRequestHeaders.Add("x-api-key", options.ApiKey);
    }

    var getRequest = new HikProAccessLogRequestDTO
    {
        IsProcessed = 0,
        RecordCount = options.RecordCount
    };
    using var getResponse = await httpClient.PostAsJsonAsync("api/AccessLog/hikpro", getRequest);
    getResponse.EnsureSuccessStatusCode();
    var hikProResponse = await getResponse.Content.ReadFromJsonAsync<HikProAccessLogRespDTO>(jsonOptions)
        ?? throw new InvalidOperationException("GetHikProAccessLogs returned an empty response.");

    if (hikProResponse.RESPONSE_CODE == dataNotFoundCode)
    {
        await WriteCompletionLogAsync("Completed", fetchedLogCount, updatedLogCount,
            "No unprocessed HikPro access logs were available.");
        Console.WriteLine("No unprocessed HikPro access logs were available.");
        return 0;
    }

    if (hikProResponse.RESPONSE_CODE != successCode)
    {
        throw new InvalidOperationException(
            $"GetHikProAccessLogs failed: {hikProResponse.RESPONSE_DESCRPTION ?? "Unknown API error"}");
    }

    if (hikProResponse.lstData is not { Count: > 0 })
    {
        await WriteCompletionLogAsync("Completed", fetchedLogCount, updatedLogCount,
            "No unprocessed HikPro access logs were available.");
        Console.WriteLine("No unprocessed HikPro access logs were available.");
        return 0;
    }

    var accessLogs = hikProResponse.lstData;
    fetchedLogCount = accessLogs.Count;
    using var processResponse = await httpClient.PostAsJsonAsync("api/AccessLog/hikpro/process", accessLogs);
    processResponse.EnsureSuccessStatusCode();
    var processResult = await processResponse.Content
        .ReadFromJsonAsync<HikProAccessLogProcessResultDTO>(jsonOptions)
        ?? throw new InvalidOperationException("SaveAndProcessHikProAccessLogs returned an empty response.");

    updatedLogCount = processResult.RowsMarkedProcessed;
    var message = $"Fetched {fetchedLogCount}, inserted {processResult.RowsInserted}, "
        + $"and updated {updatedLogCount} HikPro access log(s).";
    await WriteCompletionLogAsync("Completed", fetchedLogCount, updatedLogCount, message);
    Console.WriteLine(message);
    return 0;
}
catch (Exception ex)
{
    await WriteCompletionLogAsync("Failed", fetchedLogCount, updatedLogCount, ex.Message);
    Console.Error.WriteLine($"HikPro access log integration failed: {ex.Message}");
    return 1;
}

async Task<AppOptions> LoadOptionsAsync()
{
    var settingsPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
    if (!File.Exists(settingsPath))
    {
        throw new FileNotFoundException("Console application settings were not found.", settingsPath);
    }

    await using var settingsStream = File.OpenRead(settingsPath);
    var options = await JsonSerializer.DeserializeAsync<AppOptions>(settingsStream, jsonOptions)
        ?? throw new InvalidOperationException("Console application settings are invalid.");
    if (options.RecordCount <= 0)
    {
        throw new InvalidOperationException("RecordCount must be greater than zero.");
    }

    return options;
}

async Task WriteCompletionLogAsync(string status, int fetched, int updated, string message)
{
    Directory.CreateDirectory(logDirectory);
    var completedAt = DateTime.Now;
    var logPath = Path.Combine(logDirectory, $"{completedAt:yyyyMMdd_HHmmss_fff}.log");
    var lines = new[]
    {
        $"CompletedAt={completedAt:O}",
        $"Status={status}",
        $"FetchedLogs={fetched}",
        $"UpdatedLogs={updated}",
        $"Message={message}"
    };
    await File.WriteAllLinesAsync(logPath, lines);
}
