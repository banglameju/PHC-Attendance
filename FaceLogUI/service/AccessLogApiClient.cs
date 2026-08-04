using Domain.AttendanceServiceRespDTO;
using System.Net.Http.Json;
using Domain.ITAACOracleModel;

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

    public async Task<BiostarLogRespDTO> GetBiostarByCprsAsync(
        IEnumerable<string> cprs, DateTime fromDate, DateTime toDate)
    {
        try
        {
            var request = new BiostarLogRequestDTO
            {
                Cprs = cprs.ToList(),
                FromDate = fromDate.ToString("yyyy-MM-dd"),
                ToDate = toDate.ToString("yyyy-MM-dd")
            };
            using var response = await _httpClient.PostAsJsonAsync("api/AccessLog/biostar", request);
            if (!response.IsSuccessStatusCode)
            {
                return BiostarError($"Attendance service returned {response.StatusCode}.");
            }

            return await response.Content.ReadFromJsonAsync<BiostarLogRespDTO>()
                ?? BiostarError("Attendance service returned an empty response.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unable to load Biostar attendance logs.");
            return BiostarError("Unable to retrieve Biostar logs from the attendance service.");
        }
    }

    public async Task<ItaacTimeEventLogResponseDTO> GetItaacStatusAsync(IEnumerable<AccessLogDTO> logs)
    {
        try
        {
            var request = new ItaacTimeEventLogRequestDTO
            {
                Logs = logs.Where(log => !string.IsNullOrWhiteSpace(log.EmpId))
                    .Select(log => new ItaacTimeEventLogLookupDTO
                    {
                        Cpr = log.EmpId!,
                        LogDate = (log.AccessDate ?? DateOnly.FromDateTime(log.AccessDateTime)).ToString("yyyy-MM-dd"),
                        LogTime = (log.AccessTime ?? TimeOnly.FromDateTime(log.AccessDateTime)).ToString("HH:mm:ss")
                    }).ToList()
            };
            using var response = await _httpClient.PostAsJsonAsync("api/AccessLog/itaac-status", request);
            if (!response.IsSuccessStatusCode)
            {
                return ItaacError($"Attendance service returned {response.StatusCode}.");
            }

            return await response.Content.ReadFromJsonAsync<ItaacTimeEventLogResponseDTO>()
                ?? ItaacError("Attendance service returned an empty response.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unable to check ITAAC attendance status.");
            return ItaacError("Unable to check ITAAC attendance status.");
        }
    }

    public async Task<EventFaceLogProcessResult> PushToItaacAsync(IEnumerable<AccessLogDTO> logs)
    {
        try
        {
            var eventLogs = logs.Select(log => new TbEventFaceLog
            {
                EmpId = decimal.Parse(log.EmpId!, System.Globalization.CultureInfo.InvariantCulture),
                AccessDateTime = log.AccessDateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                AccessDate = (log.AccessDate ?? DateOnly.FromDateTime(log.AccessDateTime)).ToString("yyyy-MM-dd"),
                AccessTime = (log.AccessTime ?? TimeOnly.FromDateTime(log.AccessDateTime)).ToString("HH:mm:ss"),
                DevSn = log.DevSn ?? string.Empty,
                DevName = log.DevName ?? string.Empty,
                EmpFirstName = log.EmpFirstName ?? string.Empty,
                EmpLastName = log.EmpLastName
            }).ToList();

            using var response = await _httpClient.PostAsJsonAsync("api/ITAACEventFaceLog", eventLogs);
            if (!response.IsSuccessStatusCode)
            {
                var problem = await response.Content.ReadFromJsonAsync<Microsoft.AspNetCore.Mvc.ProblemDetails>();
                throw new HttpRequestException(problem?.Detail ?? $"ITAAC service returned {response.StatusCode}.");
            }

            return await response.Content.ReadFromJsonAsync<EventFaceLogProcessResult>()
                ?? throw new InvalidOperationException("ITAAC service returned an empty response.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unable to push face attendance logs to ITAAC.");
            throw;
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

    private static ItaacTimeEventLogResponseDTO ItaacError(string message) => new()
    {
        RESPONSE_CODE = "011",
        RESPONSE_DESCRPTION = message
    };

    private static BiostarLogRespDTO BiostarError(string message) => new()
    {
        RESPONSE_CODE = "011",
        RESPONSE_DESCRPTION = message
    };
}
