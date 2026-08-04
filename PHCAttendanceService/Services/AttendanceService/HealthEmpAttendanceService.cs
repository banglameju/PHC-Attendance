using DataAccess.Repository;
using Domain.AttendanceServiceRespDTO;
using Domain.BiostarModels;
using Domain.Core;
using Domain.CSBImportModels;
using Domain.ItaacDTO;
using Domain.ITAACOracleModel;

namespace PHCAttendanceService.Services.AttendanceService
{
    public class HealthEmpAttendanceService
    {        
        private BiostarContext _context;
        private HealthEmpAttendanceRespDTO _resp;
        private List<HealthEmpAttendanceDTO> _lstAttendance;
        private AttendanceLogRespDTO _AttendanceLogRespDTO;
        private List<AttendanceLogDTO> _lstAttendanceLogDTO;

        private TimeSheetRespDTO _timeSheetResp;
        private List<EmployeeTimeSheet> _lstEmployeeTimeSheet;

        private IDataRepository _repository;

        public HealthEmpAttendanceService(IDataRepository repository)
        {
            _repository = repository;
        }

        public async Task<EventFaceLogProcessResult> SaveAndProcessEventFaceLogs(List<TbEventFaceLog> eventFaceLogs)
        {
            ArgumentNullException.ThrowIfNull(eventFaceLogs);
            return await _repository.SaveAndProcessEventFaceLogs(eventFaceLogs);
        }

        public async Task<AttendanceLogRespDTO> GetHikLogByCpr(string CprNumber, string Fromdate, string ToDate)
        {
            _AttendanceLogRespDTO = new();
            _lstAttendanceLogDTO = new();
            if (!CprNumber.Equals("") && !Fromdate.Equals("") && !ToDate.Equals(""))
            {
                try
                {
                    _lstAttendanceLogDTO = await _repository.GetHikLogByCpr(CprNumber, Fromdate, ToDate);
                    if (_lstAttendanceLogDTO != null && _lstAttendanceLogDTO.Count > 0)
                    {
                        _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.SUCCESS;
                        _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE;
                        _AttendanceLogRespDTO.Cpr = CprNumber;
                        _AttendanceLogRespDTO.lstData = _lstAttendanceLogDTO;
                    }
                    else
                    {
                        _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.DATA_NOT_FOUND;
                        _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ConfigClass.DATA_NOT_FOUND_MESSAGE;
                        _AttendanceLogRespDTO.Cpr = null;
                        _AttendanceLogRespDTO.lstData = null;
                    }
                }
                catch (Exception ex)
                {
                    _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.INTERNAL_ERROR;
                    _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ex.ToString();
                    _AttendanceLogRespDTO.Cpr = null;
                    _AttendanceLogRespDTO.lstData = null;
                }
            }
            else
            {
                _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.INVALID_REQUEST;
                _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ConfigClass.INVALID_REQUEST_MESSAGE;
                _AttendanceLogRespDTO.Cpr = null;
                _AttendanceLogRespDTO.lstData = null;
            }
            return _AttendanceLogRespDTO;
        }

        public async Task<AttendanceLogRespDTO> GetBackupBioLogByCpr(string CprNumber, string Fromdate, string ToDate)
        {
            _AttendanceLogRespDTO = new();
            _lstAttendanceLogDTO = new();

            if (!CprNumber.Equals("") && !Fromdate.Equals("") && !ToDate.Equals(""))
            {
                try
                {
                    _lstAttendanceLogDTO = await _repository.GetBackupBioLogByCpr(CprNumber, Fromdate, ToDate);
                    if (_lstAttendanceLogDTO != null && _lstAttendanceLogDTO.Count > 0)
                    {
                        _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.SUCCESS;
                        _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE;
                        _AttendanceLogRespDTO.Cpr = CprNumber;
                        _AttendanceLogRespDTO.lstData = _lstAttendanceLogDTO;
                    }
                    else
                    {
                        _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.DATA_NOT_FOUND;
                        _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ConfigClass.DATA_NOT_FOUND_MESSAGE;
                        _AttendanceLogRespDTO.Cpr = null;
                        _AttendanceLogRespDTO.lstData = null;
                    }
                }
                catch (Exception ex)
                {
                    _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.INTERNAL_ERROR;
                    _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ex.ToString();
                    _AttendanceLogRespDTO.Cpr = null;
                    _AttendanceLogRespDTO.lstData = null;
                }
            }
            else
            {
                _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.INVALID_REQUEST;
                _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ConfigClass.INVALID_REQUEST_MESSAGE;
                _AttendanceLogRespDTO.Cpr = null;
                _AttendanceLogRespDTO.lstData = null;
            }
            return _AttendanceLogRespDTO;
        }

        public async Task<AttendanceLogRespDTO> GetBioLogByCpr(string CprNumber, string Fromdate, string ToDate)
        {
            _AttendanceLogRespDTO = new();
            _lstAttendanceLogDTO = new();

            if (!CprNumber.Equals("") && !Fromdate.Equals("") && !ToDate.Equals(""))
            {
                try
                {
                    _lstAttendanceLogDTO = await _repository.GetBioLogByCpr(CprNumber, Fromdate, ToDate);
                    if (_lstAttendanceLogDTO != null && _lstAttendanceLogDTO.Count > 0)
                    {
                        _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.SUCCESS;
                        _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE;
                        _AttendanceLogRespDTO.Cpr = CprNumber;
                        _AttendanceLogRespDTO.lstData = _lstAttendanceLogDTO;
                    }
                    else
                    {
                        _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.DATA_NOT_FOUND;
                        _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ConfigClass.DATA_NOT_FOUND_MESSAGE;
                        _AttendanceLogRespDTO.Cpr = null;
                        _AttendanceLogRespDTO.lstData = null;
                    }
                }
                catch (Exception ex)
                {
                    _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.INTERNAL_ERROR;
                    _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ex.ToString();
                    _AttendanceLogRespDTO.Cpr = null;
                    _AttendanceLogRespDTO.lstData = null;
                }
            }
            else
            {
                _AttendanceLogRespDTO.RESPONSE_CODE = ConfigClass.INVALID_REQUEST;
                _AttendanceLogRespDTO.RESPONSE_DESCRPTION = ConfigClass.INVALID_REQUEST_MESSAGE;
                _AttendanceLogRespDTO.Cpr = null;
                _AttendanceLogRespDTO.lstData = null;
            }
            return _AttendanceLogRespDTO;
        }

        public async Task<BiostarLogRespDTO> GetBioLogsByCprs(BiostarLogRequestDTO request)
        {
            var cprs = request?.Cprs?
                .Where(cpr => !string.IsNullOrWhiteSpace(cpr))
                .Select(cpr => cpr.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList() ?? [];
            if (cprs.Count == 0 || string.IsNullOrWhiteSpace(request?.FromDate)
                || string.IsNullOrWhiteSpace(request.ToDate))
            {
                return BiostarError(ConfigClass.INVALID_REQUEST, ConfigClass.INVALID_REQUEST_MESSAGE);
            }

            try
            {
                var logs = await _repository.GetBioLogsByCprs(cprs, request.FromDate, request.ToDate);
                if (logs.Count == 0)
                {
                    return BiostarError(ConfigClass.DATA_NOT_FOUND, ConfigClass.DATA_NOT_FOUND_MESSAGE);
                }

                return new BiostarLogRespDTO
                {
                    RESPONSE_CODE = ConfigClass.SUCCESS,
                    RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE,
                    Cprs = cprs,
                    lstData = logs
                };
            }
            catch (ArgumentException ex)
            {
                return BiostarError(ConfigClass.INVALID_REQUEST, ex.Message);
            }
            catch (Exception)
            {
                return BiostarError(ConfigClass.INTERNAL_ERROR,
                    "An error occurred while retrieving Biostar attendance logs.");
            }
        }

        private static BiostarLogRespDTO BiostarError(string code, string description) => new()
        {
            RESPONSE_CODE = code,
            RESPONSE_DESCRPTION = description
        };


        public async Task<HealthEmpAttendanceRespDTO> GetHealthEmpAttendaceByDate(string CprNumber,string Fromdate, string ToDate)
        {
            _resp = new();
            _lstAttendance = new();
            
            if (!CprNumber.Equals("") && !Fromdate.Equals("") && !ToDate.Equals(""))
            {
                try
                {
                    _lstAttendance = await _repository.GetEmpAtendanceByCpr(CprNumber, Fromdate, ToDate);
                    if (_lstAttendance != null && _lstAttendance.Count > 0)
                    {
                        //_lstEmployeeTimeSheet = await _repository.GetTimeSheetByCpr(CprNumber, Fromdate,ToDate);
                        //foreach (var att in _lstAttendance)
                        //{
                        //    foreach (var time in _lstEmployeeTimeSheet)
                        //    {
                        //        if (att.AttendanceDate == time.LOG_DATE)
                        //        {
                        //            att.TimeSheetData = time;
                        //            _lstAttendanceWithTimeSheet.Add(att);
                        //        }
                        //    }
                        //}
                        _resp.RESPONSE_CODE = ConfigClass.SUCCESS;
                        _resp.RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE;
                        _resp.Cpr = CprNumber;
                        _resp.lstData = _lstAttendance;
                    }
                    else
                    {
                        _resp.RESPONSE_CODE = ConfigClass.DATA_NOT_FOUND;
                        _resp.RESPONSE_DESCRPTION = ConfigClass.DATA_NOT_FOUND_MESSAGE;
                        _resp.Cpr = null;
                        _resp.lstData = null;
                    }                    
                }
                catch (Exception ex)
                {
                    _resp.RESPONSE_CODE = ConfigClass.INTERNAL_ERROR;
                    _resp.RESPONSE_DESCRPTION = ex.ToString();
                    _resp.Cpr = null;
                    _resp.lstData = null;
                }
            }
            else
            {
                _resp.RESPONSE_CODE = ConfigClass.INVALID_REQUEST;
                _resp.RESPONSE_DESCRPTION = ConfigClass.INVALID_REQUEST_MESSAGE;
                _resp.Cpr = null;
                _resp.lstData = null;
            }
            return _resp;
        }

        public async Task<HealthEmpAttendanceRespDTO> GetEmpAtendanceBackupByCpr(string CprNumber, string Fromdate, string ToDate)
        {
            _resp = new();
            _lstAttendance = new();

            if (!CprNumber.Equals("") && !Fromdate.Equals("") && !ToDate.Equals(""))
            {
                try
                {
                    _lstAttendance = await _repository.GetEmpAtendanceBackupByCpr(CprNumber, Fromdate, ToDate);
                    if (_lstAttendance != null && _lstAttendance.Count > 0)
                    {
                        _resp.RESPONSE_CODE = ConfigClass.SUCCESS;
                        _resp.RESPONSE_DESCRPTION = ConfigClass.SUCCESS_MESSAGE;
                        _resp.Cpr = CprNumber;
                        _resp.lstData = _lstAttendance;
                    }
                    else
                    {
                        _resp.RESPONSE_CODE = ConfigClass.DATA_NOT_FOUND;
                        _resp.RESPONSE_DESCRPTION = ConfigClass.DATA_NOT_FOUND_MESSAGE;
                        _resp.Cpr = null;
                        _resp.lstData = null;
                    }
                }
                catch (Exception ex)
                {
                    _resp.RESPONSE_CODE = ConfigClass.INTERNAL_ERROR;
                    _resp.RESPONSE_DESCRPTION = ex.ToString();
                    _resp.Cpr = null;
                    _resp.lstData = null;
                }
            }
            else
            {
                _resp.RESPONSE_CODE = ConfigClass.INVALID_REQUEST;
                _resp.RESPONSE_DESCRPTION = ConfigClass.INVALID_REQUEST_MESSAGE;
                _resp.Cpr = null;
                _resp.lstData = null;
            }
            return _resp;
        }

        public async Task<TimeSheetRespDTO> GetHealthEmpTimeSheetByCpr(string CprNumber, string Fromdate, string ToDate)
        {
            _timeSheetResp = new();
            _lstEmployeeTimeSheet = new();

            if (!CprNumber.Equals("") && !Fromdate.Equals("") && !ToDate.Equals(""))
            {
                try
                {
                    _lstEmployeeTimeSheet = await _repository.GetTimeSheetByCpr(CprNumber, Fromdate, ToDate);
                    if (_lstEmployeeTimeSheet != null && _lstEmployeeTimeSheet.Count > 0)
                    {
                        _timeSheetResp.RESPONSE_CODE = ConfigClass.SUCCESS;
                        _timeSheetResp.RESPONSE_DESCRIPTION = ConfigClass.SUCCESS_MESSAGE;
                        _timeSheetResp.lstTimeSheet = _lstEmployeeTimeSheet;
                    }
                    else
                    {
                        _timeSheetResp.RESPONSE_CODE = ConfigClass.DATA_NOT_FOUND;
                        _timeSheetResp.RESPONSE_DESCRIPTION = ConfigClass.DATA_NOT_FOUND_MESSAGE;
                        _timeSheetResp.lstTimeSheet = null;
                    }
                }
                catch (Exception ex)
                {
                    _timeSheetResp.RESPONSE_CODE = ConfigClass.INTERNAL_ERROR;
                    _timeSheetResp.RESPONSE_DESCRIPTION = ex.ToString();
                    _timeSheetResp.lstTimeSheet = null;
                }
            }
            else
            {
                _timeSheetResp.RESPONSE_CODE = ConfigClass.INVALID_REQUEST;
                _timeSheetResp.RESPONSE_DESCRIPTION = ConfigClass.INVALID_REQUEST_MESSAGE;
                _timeSheetResp.lstTimeSheet = null;
            }
            return _timeSheetResp;
        }
        

        //public async Task<List<EmployeeTimeSheet>> GetHealthEmpTimeSheetByCpr(string CprNumber, string Fromdate, string ToDate)
        //{
        //    _lstEmployeeTimeSheet = new();
        //    if (!CprNumber.Equals("") && !Fromdate.Equals("") && !ToDate.Equals(""))
        //    {
        //        try
        //        {
        //            _lstEmployeeTimeSheet = await _repository.GetTimeSheetByCpr(CprNumber, Fromdate, ToDate);
        //        }
        //        catch (Exception ex)
        //        {
        //            _lstEmployeeTimeSheet = null;
        //        }
        //    }
        //    else
        //    {
        //        _lstEmployeeTimeSheet = null;
        //    }
        //    return _lstEmployeeTimeSheet;
        //}

    }
}
