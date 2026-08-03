using DataAccess.Repository;
using Domain.AttendanceServiceRespDTO;
using Domain.Core;

namespace PHCAttendanceService.Services.AttendanceService;

public class EmployeeService
{
    private readonly IDataRepository _repository;

    public EmployeeService(IDataRepository repository) => _repository = repository;

    public async Task<CostCenterEmployeeRespDTO> GetByCostCenter(string costCenter)
    {
        if (string.IsNullOrWhiteSpace(costCenter))
            return Error(ConfigClass.INVALID_REQUEST, ConfigClass.INVALID_REQUEST_MESSAGE);

        try
        {
            var employees = await _repository.GetEmployeesByCostCenter(costCenter.Trim());
            if (employees.Count == 0)
                return Error(ConfigClass.DATA_NOT_FOUND, ConfigClass.DATA_NOT_FOUND_MESSAGE);

            return new CostCenterEmployeeRespDTO
            {
                RESPONSE_CODE = ConfigClass.SUCCESS,
                RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE,
                CostCenter = costCenter.Trim(),
                lstData = employees
            };
        }
        catch (Exception)
        {
            return Error(ConfigClass.INTERNAL_ERROR, "An error occurred while retrieving employees.");
        }
    }

    private static CostCenterEmployeeRespDTO Error(string code, string description) => new()
    {
        RESPONSE_CODE = code,
        RESPONSE_DESCRPTION = description
    };
}
