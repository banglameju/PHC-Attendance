namespace PHCAttendanceConsole;

internal sealed class AppOptions
{
    public string ApiBaseUrl { get; set; } = "http://localhost:5012/";
    public string? ApiKey { get; set; }
    public int RecordCount { get; set; } = 200;
}
