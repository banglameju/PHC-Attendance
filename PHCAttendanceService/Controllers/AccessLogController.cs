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

    [HttpPost("biostar")]
    public Task<BiostarLogRespDTO> GetBiostarByCprs([FromBody] BiostarLogRequestDTO request) =>
        _healthAttendanceService.GetBioLogsByCprs(request);

    [HttpPost("itaac-status")]
    public Task<ItaacTimeEventLogResponseDTO> GetItaacStatus(
        [FromBody] ItaacTimeEventLogRequestDTO request) =>
        _service.GetItaacStatus(request);
}
