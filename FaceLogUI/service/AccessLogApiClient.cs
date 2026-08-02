using Domain.AttendanceServiceRespDTO;
using System.Net.Http.Json;

namespace FaceLogUI.Service;

public class AccessLogApiClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<AccessLogApiClient> _logger;

    public AccessLogApiClient(HttpClient httpClient, ILogger<AccessLogApiClient> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<AccessLogRespDTO> GetByCprAsync(string cpr, DateTime fromDate, DateTime toDate)
    {
        try
        {
            var url = $"api/AccessLog?cpr={Uri.EscapeDataString(cpr)}&fromDate={fromDate:yyyy-MM-dd}&toDate={toDate:yyyy-MM-dd}";
            using var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                _logger.LogWarning("Attendance API returned HTTP {StatusCode}.", response.StatusCode);
                return Error($"Attendance service returned {response.StatusCode}.");
            }

            return await response.Content.ReadFromJsonAsync<AccessLogRespDTO>()
                ?? Error("Attendance service returned an empty response.");
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Attendance API could not be reached.");
            return Error("Unable to connect to the attendance service.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error while loading attendance logs.");
            return Error("An unexpected error occurred while loading attendance logs.");
        }
    }

    private static AccessLogRespDTO Error(string message) => new()
    {
        RESPONSE_CODE = "011",
        RESPONSE_DESCRPTION = message
    };
}
