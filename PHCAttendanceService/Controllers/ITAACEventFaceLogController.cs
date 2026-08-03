using Domain.ITAACOracleModel;
using Microsoft.AspNetCore.Mvc;
using PHCAttendanceService.Services.AttendanceService;

namespace PHCAttendanceService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ITAACEventFaceLogController : ControllerBase
{
    private readonly HealthEmpAttendanceService _service;
    private readonly ILogger<ITAACEventFaceLogController> _logger;

    public ITAACEventFaceLogController(
        HealthEmpAttendanceService service,
        ILogger<ITAACEventFaceLogController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpPost]
    public async Task<ActionResult<EventFaceLogProcessResult>> Create(List<TbEventFaceLog> eventFaceLogs)
    {
        if (eventFaceLogs == null || eventFaceLogs.Count == 0)
        {
            return BadRequest("At least one event face log is required.");
        }

        try
        {
            var result = await _service.SaveAndProcessEventFaceLogs(eventFaceLogs);
            return Ok(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to save and process {LogCount} face attendance logs.", eventFaceLogs.Count);
            return Problem(
                title: "Unable to push face attendance logs to ITAAC",
                detail: "The logs could not be saved and processed. No changes were committed; please try again or contact support.",
                statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
