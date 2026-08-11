using Domain.AttendanceServiceRespDTO;
using Microsoft.AspNetCore.Mvc;
using PHCAttendanceService.Services.AttendanceService;
using Domain.ITAACOracleModel;

namespace PHCAttendanceService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccessLogController : ControllerBase
{
    private readonly AccessLogService _service;
    private readonly HealthEmpAttendanceService _healthAttendanceService;

    public AccessLogController(AccessLogService service, HealthEmpAttendanceService healthAttendanceService)
    {
        _service = service;
        _healthAttendanceService = healthAttendanceService;
    }

    [HttpPost]
    public Task<AccessLogRespDTO> GetByCprs([FromBody] AccessLogRequestDTO request) =>
        _service.GetByCprs(request);

    [HttpPost("hikpro")]
    public Task<HikProAccessLogRespDTO> GetHikProAccessLogs([FromBody] HikProAccessLogRequestDTO request) =>
        _service.GetHikProAccessLogs(request);

    [HttpPost("hikpro/process")]
    public async Task<ActionResult<HikProAccessLogProcessResultDTO>> SaveAndProcessHikProAccessLogs(
        [FromBody] List<HikProAccessLogDTO> accessLogs)
    {
        try
        {
            return Ok(await _service.SaveAndProcessHikProAccessLogs(accessLogs));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception)
        {
            return Problem(
                title: "Unable to process HikPro access logs",
                detail: "The logs could not be saved and processed; please try again or contact support.",
                statusCode: StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPost("biostar")]
    public Task<BiostarLogRespDTO> GetBiostarByCprs([FromBody] BiostarLogRequestDTO request) =>
        _healthAttendanceService.GetBioLogsByCprs(request);

    [HttpPost("itaac-status")]
    public Task<ItaacTimeEventLogResponseDTO> GetItaacStatus(
        [FromBody] ItaacTimeEventLogRequestDTO request) =>
        _service.GetItaacStatus(request);
}
