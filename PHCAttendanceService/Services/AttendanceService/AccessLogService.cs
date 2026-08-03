using DataAccess.Repository;
using Domain.AttendanceServiceRespDTO;
using Domain.Core;

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

    private static AccessLogRespDTO Error(string code, string description) => new()
    {
        RESPONSE_CODE = code,
        RESPONSE_DESCRPTION = description,
        Cprs = null,
        lstData = null
    };
}
