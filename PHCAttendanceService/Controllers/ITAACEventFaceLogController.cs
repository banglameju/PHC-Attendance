using Domain.ITAACOracleModel;
using Microsoft.AspNetCore.Mvc;
using PHCAttendanceService.Services.AttendanceService;

namespace PHCAttendanceService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ITAACEventFaceLogController : ControllerBase
{
    private readonly HealthEmpAttendanceService _service;

    public ITAACEventFaceLogController(HealthEmpAttendanceService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(List<TbEventFaceLog> eventFaceLogs)
    {
        if (eventFaceLogs == null || eventFaceLogs.Count == 0)
        {
            return BadRequest("At least one event face log is required.");
        }

        var rowsInserted = await _service.SaveEventFaceLogs(eventFaceLogs);
        return Ok(rowsInserted);
    }
}
