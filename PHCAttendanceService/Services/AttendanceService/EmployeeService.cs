using DataAccess.Repository;
using Domain.AttendanceServiceRespDTO;
using Domain.Core;

namespace PHCAttendanceService.Services.AttendanceService;

public class EmployeeService
{
    private readonly IDataRepository _repository;

    public EmployeeService(IDataRepository repository) => _repository = repository;

    public async Task<CostCenterEmployeeRespDTO> GetEmployees(EmployeeFilterRequestDTO request)
    {
        var costCenter = Normalize(request.CostCenter);
        var cpr = Normalize(request.Cpr);
        if (costCenter is null && cpr is null)
            return Error(ConfigClass.INVALID_REQUEST, ConfigClass.INVALID_REQUEST_MESSAGE);

        try
        {
            var employees = await _repository.GetEmployees(costCenter, cpr);
            if (employees.Count == 0)
                return Error(ConfigClass.DATA_NOT_FOUND, ConfigClass.DATA_NOT_FOUND_MESSAGE);

            return new CostCenterEmployeeRespDTO
            {
                RESPONSE_CODE = ConfigClass.SUCCESS,
                RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE,
                CostCenter = costCenter,
                Cpr = cpr,
                lstData = employees
            };
        }
        catch (Exception)
        {
            return Error(ConfigClass.INTERNAL_ERROR, "An error occurred while retrieving employees.");
        }
    }

    private static string? Normalize(string? value) =>
        string.IsNullOrWhiteSpace(value) ? null : value.Trim();

    private static CostCenterEmployeeRespDTO Error(string code, string description) => new()
    {
        RESPONSE_CODE = code,
        RESPONSE_DESCRPTION = description
    };
}
