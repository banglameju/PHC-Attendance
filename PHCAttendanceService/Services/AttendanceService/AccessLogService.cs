using DataAccess.Repository;
using Domain.AttendanceServiceRespDTO;
using Domain.Core;
using Domain.ITAACOracleModel;
using System.Globalization;

namespace PHCAttendanceService.Services.AttendanceService;

public class AccessLogService
{
    private readonly IDataRepository _repository;

    public AccessLogService(IDataRepository repository)
    {
        _repository = repository;
    }

    public async Task<AccessLogRespDTO> GetByCprs(AccessLogRequestDTO request)
    {
        var cprs = request.Cprs
            .Where(cpr => !string.IsNullOrWhiteSpace(cpr))
            .Select(cpr => cpr.Trim())
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();
        if (cprs.Count == 0)
        {
            return Error(ConfigClass.INVALID_REQUEST, ConfigClass.INVALID_REQUEST_MESSAGE);
        }

        try
        {
            var logs = await _repository.GetAccessLogsByCprs(cprs, request.FromDate, request.ToDate);
            if (logs.Count == 0)
            {
                return Error(ConfigClass.DATA_NOT_FOUND, ConfigClass.DATA_NOT_FOUND_MESSAGE);
            }

            return new AccessLogRespDTO
            {
                RESPONSE_CODE = ConfigClass.SUCCESS,
                RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE,
                Cprs = cprs,
                lstData = logs
            };
        }
        catch (Exception)
        {
            return Error(ConfigClass.INTERNAL_ERROR, "An error occurred while retrieving attendance logs.");
        }
    }

    public async Task<HikProAccessLogRespDTO> GetHikProAccessLogs(HikProAccessLogRequestDTO request)
    {
        if (request == null)
        {
            return HikProError(ConfigClass.INVALID_REQUEST, ConfigClass.INVALID_REQUEST_MESSAGE);
        }

        var cprs = request.Cprs?
            .Where(cpr => !string.IsNullOrWhiteSpace(cpr))
            .Select(cpr => cpr.Trim())
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList() ?? [];

        try
        {
            request.Cprs = cprs;
            request.RecordCount ??= 500;
            var logs = await _repository.GetHikProAccessLogs(request);
            if (logs.Count == 0)
            {
                return HikProError(ConfigClass.DATA_NOT_FOUND, ConfigClass.DATA_NOT_FOUND_MESSAGE);
            }

            return new HikProAccessLogRespDTO
            {
                RESPONSE_CODE = ConfigClass.SUCCESS,
                RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE,
                Cprs = cprs.Count > 0 ? cprs : null,
                IsProcessed = request.IsProcessed ?? 0,
                lstData = logs
            };
        }
        catch (ArgumentException ex)
        {
            return HikProError(ConfigClass.INVALID_REQUEST, ex.Message);
        }
        catch (Exception)
        {
            return HikProError(ConfigClass.INTERNAL_ERROR,
                "An error occurred while retrieving HikPro access logs.");
        }
    }

    public async Task<HikProAccessLogProcessResultDTO> SaveAndProcessHikProAccessLogs(
        List<HikProAccessLogDTO> accessLogs)
    {
        ArgumentNullException.ThrowIfNull(accessLogs);
        if (accessLogs.Count == 0)
        {
            throw new ArgumentException("At least one HikPro access log is required.", nameof(accessLogs));
        }

        if (accessLogs.Any(log => log == null || log.LogId <= 0))
        {
            throw new ArgumentException("Every HikPro access log must have a positive LogId.", nameof(accessLogs));
        }

        if (accessLogs.Select(log => log.LogId).Distinct().Count() != accessLogs.Count)
        {
            throw new ArgumentException("HikPro access log LogIds must be unique.", nameof(accessLogs));
        }

        return await _repository.SaveAndProcessHikProAccessLogs(accessLogs);
    }

    public async Task<ItaacTimeEventLogResponseDTO> GetItaacStatus(ItaacTimeEventLogRequestDTO request)
    {
        if (request?.Logs == null || request.Logs.Count == 0)
        {
            return ItaacError(ConfigClass.INVALID_REQUEST,
                "Supply at least one CPR, log date and log time combination.");
        }

        var lookups = request.Logs
            .Select(NormalizeLookup)
            .ToList();
        if (lookups.Any(log => log == null))
        {
            return ItaacError(ConfigClass.INVALID_REQUEST,
                "CPR is required and dates/times must use yyyy-MM-dd and HH:mm:ss formats.");
        }

        var validLookups = lookups.Cast<ItaacTimeEventLogLookupDTO>()
            .DistinctBy(LookupKey)
            .ToList();
        try
        {
            var matches = await _repository.GetItaacTimeEventLogs(validLookups);
            var matchedKeys = matches
                .Select(log => $"{log.EmpId.Trim()}|{log.LogDateTime:yyyy-MM-dd HH:mm:ss}")
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            return new ItaacTimeEventLogResponseDTO
            {
                RESPONSE_CODE = ConfigClass.SUCCESS,
                RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE,
                lstData = validLookups.Select(log => new ItaacTimeEventLogResultDTO
                {
                    Cpr = log.Cpr,
                    LogDate = log.LogDate,
                    LogTime = log.LogTime,
                    IsAvailable = matchedKeys.Contains(LookupKey(log))
                }).ToList()
            };
        }
        catch (Exception)
        {
            return ItaacError(ConfigClass.INTERNAL_ERROR,
                "An error occurred while checking ITAAC attendance logs.");
        }
    }

    private static ItaacTimeEventLogLookupDTO? NormalizeLookup(ItaacTimeEventLogLookupDTO log)
    {
        if (log == null || string.IsNullOrWhiteSpace(log.Cpr)
            || !DateOnly.TryParseExact(log.LogDate, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out var date)
            || !TimeOnly.TryParseExact(log.LogTime, "HH:mm:ss", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out var time))
        {
            return null;
        }

        return new ItaacTimeEventLogLookupDTO
        {
            Cpr = log.Cpr.Trim(),
            LogDate = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
            LogTime = time.ToString("HH:mm:ss", CultureInfo.InvariantCulture)
        };
    }

    private static string LookupKey(ItaacTimeEventLogLookupDTO log) =>
        $"{log.Cpr}|{log.LogDate} {log.LogTime}";

    private static ItaacTimeEventLogResponseDTO ItaacError(string code, string description) => new()
    {
        RESPONSE_CODE = code,
        RESPONSE_DESCRPTION = description,
        lstData = null
    };

    private static AccessLogRespDTO Error(string code, string description) => new()
    {
        RESPONSE_CODE = code,
        RESPONSE_DESCRPTION = description,
        Cprs = null,
        lstData = null
    };

    private static HikProAccessLogRespDTO HikProError(string code, string description) => new()
    {
        RESPONSE_CODE = code,
        RESPONSE_DESCRPTION = description,
        Cprs = null,
        IsProcessed = null,
        lstData = null
    };
}
