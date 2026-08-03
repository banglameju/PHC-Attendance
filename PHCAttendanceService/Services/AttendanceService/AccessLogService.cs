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

    public async Task<AccessLogRespDTO> GetByCpr(string cpr, string fromDate, string toDate)
    {
        if (string.IsNullOrWhiteSpace(cpr))
        {
            return Error(ConfigClass.INVALID_REQUEST, ConfigClass.INVALID_REQUEST_MESSAGE);
        }

        try
        {
            var logs = await _repository.GetAccessLogsByCpr(cpr.Trim(), fromDate, toDate);
            if (logs.Count == 0)
            {
                return Error(ConfigClass.DATA_NOT_FOUND, ConfigClass.DATA_NOT_FOUND_MESSAGE);
            }

            return new AccessLogRespDTO
            {
                RESPONSE_CODE = ConfigClass.SUCCESS,
                RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE,
                Cpr = cpr.Trim(),
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
        Cpr = null,
        lstData = null
    };
}
