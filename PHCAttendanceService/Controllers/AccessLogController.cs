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

    [HttpPost]
    public Task<AccessLogRespDTO> GetByCprs([FromBody] AccessLogRequestDTO request) =>
        _service.GetByCprs(request);
}
