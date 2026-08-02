using Domain.Core;
using Domain.CSBImportModels;
using Domain.CSBImportRespDTO;

namespace PHCAttendanceService.Services.CSBImportServices
{
    public class CsbHealthEmpDataService
    {
        private CsbimportContext _context;
        private List<XxcsbHealthDatum> _csbHelthEmp {get; set;}
        private CSBHealthEmpDataRespDTO _resp { get; set; }
        public CsbHealthEmpDataService(CsbimportContext context)
        {
            _context = context;
        }

        public CSBHealthEmpDataRespDTO GetHealthEmployeeByCpr(string cprNumber)
        {
            _resp = new();
            _csbHelthEmp = new();
            
            if (cprNumber != null && !cprNumber.Equals(""))
            {
                try
                {
                    _csbHelthEmp = _context.XxcsbHealthData.Where(x => x.Cpr == cprNumber && x.EmployeeStatus.Equals("Active")).ToList();
                    if (_csbHelthEmp != null)
                    {
                        _resp.RESPONSE_CODE = ConfigClass.SUCCESS;
                        _resp.RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE;                        
                        _resp.lstData = _csbHelthEmp;
                    }
                    else
                    {
                        _resp.RESPONSE_CODE = ConfigClass.DATA_NOT_FOUND;
                        _resp.RESPONSE_DESCRPTION = ConfigClass.DATA_NOT_FOUND;
                        _resp.lstData = null;
                    }
                }
                catch (Exception ex)
                {
                    _resp.RESPONSE_CODE = ConfigClass.FAILURE;
                    _resp.RESPONSE_DESCRPTION = ex.ToString();
                    _resp.lstData = null;
                }
            }
            else
            {
                _resp.RESPONSE_CODE = ConfigClass.INVALID_REQUEST;
                _resp.RESPONSE_DESCRPTION = ConfigClass.INVALID_REQUEST_MESSAGE;
                _resp.lstData = null;
            }           
            
            return _resp;
        }
    }
}
