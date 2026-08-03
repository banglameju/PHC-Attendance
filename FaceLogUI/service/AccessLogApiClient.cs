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

    public async Task<CostCenterEmployeeRespDTO> GetEmployeesAsync(string? costCenter, string? cpr)
    {
        try
        {
            var parameters = new List<string>();
            if (!string.IsNullOrWhiteSpace(costCenter))
                parameters.Add($"costCenter={Uri.EscapeDataString(costCenter)}");
            if (!string.IsNullOrWhiteSpace(cpr))
                parameters.Add($"cpr={Uri.EscapeDataString(cpr)}");
            var url = $"api/Employee?{string.Join('&', parameters)}";
            return await _httpClient.GetFromJsonAsync<CostCenterEmployeeRespDTO>(url)
                ?? EmployeeError("Attendance service returned an empty response.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unable to load employees for cost center {CostCenter} and CPR {Cpr}.", costCenter, cpr);
            return EmployeeError("Unable to retrieve employees from the attendance service.");
        }
    }

    public async Task<AccessLogRespDTO> GetByCprsAsync(IEnumerable<string> cprs, DateTime fromDate, DateTime toDate)
    {
        try
        {
            var request = new AccessLogRequestDTO
            {
                Cprs = cprs.ToList(),
                FromDate = fromDate.ToString("yyyy-MM-dd"),
                ToDate = toDate.ToString("yyyy-MM-dd")
            };
            using var response = await _httpClient.PostAsJsonAsync("api/AccessLog", request);
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

    private static CostCenterEmployeeRespDTO EmployeeError(string message) => new()
    {
        RESPONSE_CODE = "011",
        RESPONSE_DESCRPTION = message
    };
}
