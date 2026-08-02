using Domain.AttendanceServiceRespDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PHCAttendanceService.Services.AttendanceService;

namespace PHCAttendanceService.Controllers
{    
    [ApiController]
    public class PhcEmpAttendanceController : ControllerBase
    {
        private HealthEmpAttendanceService _service;
        private PatternService _patternService;
        public PhcEmpAttendanceController(HealthEmpAttendanceService service, PatternService patternService)
        {
            _service = service;
            _patternService = patternService;

        }

        [Route("api/[controller]/GetHikLogByCpr/{CprNumber}/{Fromdate}/{ToDate}")]
        [HttpGet]
        public async Task<AttendanceLogRespDTO> GetHikLogByCpr(string CprNumber, string Fromdate, string ToDate)
        {
            return await _service.GetHikLogByCpr(CprNumber, Fromdate, ToDate);
        }

        [Route("api/[controller]/GetBackupBioLogByCpr/{CprNumber}/{Fromdate}/{ToDate}")]
        [HttpGet]
        public async Task<AttendanceLogRespDTO> GetBackupBioLogByCpr(string CprNumber, string Fromdate, string ToDate)
        {
            return await _service.GetBackupBioLogByCpr(CprNumber, Fromdate, ToDate);
        }

        [Route("api/[controller]/GetBioLogByCpr/{CprNumber}/{Fromdate}/{ToDate}")]
        [HttpGet]
        public async Task<AttendanceLogRespDTO> GetBioLogByCpr(string CprNumber, string Fromdate, string ToDate)
        {
            return await _service.GetBioLogByCpr(CprNumber, Fromdate, ToDate);
        }

        [Route("api/[controller]/GetHealthEmpAttendaceByDate/{CprNumber}/{Fromdate}/{ToDate}")]
        [HttpGet]
        public async Task<HealthEmpAttendanceRespDTO> GetHealthEmpAttendaceByDate(string CprNumber, string Fromdate, string ToDate)
        {
            return await _service.GetHealthEmpAttendaceByDate(CprNumber, Fromdate, ToDate);
        }

        [Route("api/[controller]/GetEmpAttendaceBackupByDate/{CprNumber}/{Fromdate}/{ToDate}")]
        [HttpGet]
        public async Task<HealthEmpAttendanceRespDTO> GetEmpAtendanceBackupByCpr(string CprNumber, string Fromdate, string ToDate)
        {
            return await _service.GetEmpAtendanceBackupByCpr(CprNumber, Fromdate, ToDate);
        }

        [Route("api/[controller]/GetHealthEmpTimeSheetByCpr/{CprNumber}/{Fromdate}/{ToDate}")]
        [HttpGet]
        public async Task<TimeSheetRespDTO> GetHealthEmpTimeSheetByCpr(string CprNumber, string Fromdate, string ToDate)
        {
            return await _service.GetHealthEmpTimeSheetByCpr(CprNumber, Fromdate, ToDate);
        }

        [Route("api/[controller]/GetEmployeePattern/{CprNumber}")]
        [HttpGet]
        public async Task<EmployeePatternRespDTO> GetEmployeePattern(string CprNumber)
        {
            return await _patternService.GetEmployeePattern(CprNumber);
        }

        [Route("api/[controller]/GetPatterDetailsByCode/{PatternCode}")]
        [HttpGet]
        public async Task<PatternRespDTO> GetPatterDetailsByCode(string PatternCode)
        {
            return await _patternService.GetPatterDetailsByCode(PatternCode);
        }
    }
}
