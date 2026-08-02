using Domain.CSBImportRespDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PHCAttendanceService.Services.CSBImportServices;

namespace PHCAttendanceService.Controllers
{    
    [ApiController]
    public class CSBHealthEmpController : ControllerBase
    {
        private CsbHealthEmpDataService _service;
        public CSBHealthEmpController(CsbHealthEmpDataService service)
        {
            _service = service;
        }

        [Route("api/[controller]/GetHealthEmployeeByCpr/{cprNumber}")]
        [HttpGet]
        public CSBHealthEmpDataRespDTO GetHealthEmployeeByCpr(string cprNumber)
        {
            return _service.GetHealthEmployeeByCpr(cprNumber);
        }
    }
}
