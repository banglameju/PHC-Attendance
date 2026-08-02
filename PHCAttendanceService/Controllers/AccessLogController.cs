using Domain.AttendanceServiceRespDTO;
using Microsoft.AspNetCore.Mvc;
using PHCAttendanceService.Services.AttendanceService;

namespace PHCAttendanceService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccessLogController : ControllerBase
{
    private readonly AccessLogService _service;

    public AccessLogController(AccessLogService service)
    {
        _service = service;
    }

    [HttpGet]
    public Task<AccessLogRespDTO> GetByCpr(
        [FromQuery] string cpr,
        [FromQuery] DateTime fromDate,
        [FromQuery] DateTime toDate) => _service.GetByCpr(cpr, fromDate, toDate);
}
