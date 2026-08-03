using Domain.AttendanceServiceRespDTO;
using Microsoft.AspNetCore.Mvc;
using PHCAttendanceService.Services.AttendanceService;

namespace PHCAttendanceService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly EmployeeService _service;

    public EmployeeController(EmployeeService service) => _service = service;

    [HttpGet("by-cost-center")]
    public Task<CostCenterEmployeeRespDTO> GetByCostCenter([FromQuery] string costCenter) =>
        _service.GetByCostCenter(costCenter);
}
