using DataAccess.Repository;
using Domain.AttendanceServiceRespDTO;
using Domain.Core;
using Domain.ItaacDTO;

namespace PHCAttendanceService.Services.AttendanceService
{
    public class PatternService
    {
        private IDataRepository _repository;
        private EmployeePatternRespDTO _employeePatternResp;
        private List<EmployeePatternDTO> _lsEmployeePatternDTO;
        private List<PatternDTO> _lstPatternDTO;
        private PatternRespDTO _patternResp;
        private PatternMaster _patternMaster;
        private List<PatternDetails> _lstPatternDetails;

        public PatternService(IDataRepository dataRepository)
        {
            _repository = dataRepository;
        }

        public async Task<EmployeePatternRespDTO> GetEmployeePattern(string CprNumber)
        {
            _lsEmployeePatternDTO = new();
            _employeePatternResp = new();

            if (!CprNumber.Equals(""))
            {
                try
                {
                    _lsEmployeePatternDTO = await _repository.GetEmployeePattern(CprNumber);
                    if (_lsEmployeePatternDTO != null && _lsEmployeePatternDTO.Count > 0)
                    {
                        _employeePatternResp.RESPONSE_CODE = ConfigClass.SUCCESS;
                        _employeePatternResp.RESPONSE_DESCRIPTION = ConfigClass.SUCCESS_MESSAGE;
                        _employeePatternResp.lstData = _lsEmployeePatternDTO;
                    }
                    else
                    {
                        _employeePatternResp.RESPONSE_CODE = ConfigClass.DATA_NOT_FOUND;
                        _employeePatternResp.RESPONSE_DESCRIPTION = ConfigClass.DATA_NOT_FOUND_MESSAGE;
                        _employeePatternResp.lstData = null;
                    }
                }
                catch (Exception ex)
                {
                    _employeePatternResp.RESPONSE_CODE = ConfigClass.INTERNAL_ERROR;
                    _employeePatternResp.RESPONSE_DESCRIPTION = ConfigClass.INTERNAL_ERROR_MESSAGE;
                    _employeePatternResp.lstData = null;
                }
            }
            else
            {
                _employeePatternResp.RESPONSE_CODE = ConfigClass.INVALID_REQUEST;
                _employeePatternResp.RESPONSE_DESCRIPTION = ConfigClass.INVALID_REQUEST_MESSAGE;
                _employeePatternResp.lstData = null;
            }
            return _employeePatternResp;
        }

        public async Task<PatternRespDTO> GetPatterDetailsByCode(string PatternCode)
        {
            _patternResp = new();
            _lstPatternDTO = new();
            _patternMaster = new();
            _lstPatternDetails = new();

            if (PatternCode != null && !PatternCode.Equals(""))
            {
                try
                {
                    _lstPatternDTO = await _repository.GetPatterDetailsByCode(PatternCode);
                    if (_lstPatternDTO != null && _lstPatternDTO.Count() > 0)
                    {
                        var PatternMaster = _lstPatternDTO.FirstOrDefault();
                        if (PatternMaster != null)
                        {
                            _patternMaster.PATTERN_TYPE = PatternMaster.PATTERN_TYPE;
                            _patternMaster.PATTERN_CODE = PatternMaster.PATTERN_CODE;
                            _patternMaster.PATTERN_NAME = PatternMaster.PATTERN_NAME;
                            _patternMaster.FLEXI = PatternMaster.FLEXI;
                            _patternMaster.IS_RAMADAN = PatternMaster.IS_RAMADAN;
                            _patternMaster.EXTENDED = PatternMaster.EXTENDED;
                        }

                        foreach (var PatternDetails in _lstPatternDTO)
                        {
                            PatternDetails details = new();
                            details.DAY = PatternDetails.DAY;
                            details.START_TIME = PatternDetails.START_TIME;
                            details.END_TIME = PatternDetails.END_TIME;
                            details.START_GRACE_TIME = PatternDetails.START_GRACE_TIME;
                            details.END_GRACE_TIME = PatternDetails.END_GRACE_TIME;
                            details.SEQ_NO = PatternDetails.SEQ_NO;
                            details.NIGHT_SHIFT = PatternDetails.NIGHT_SHIFT;
                            details.HOLIDAY = PatternDetails.HOLIDAY;
                            _lstPatternDetails.Add(details);
                        }
                        _patternResp.RESPONSE_CODE = ConfigClass.SUCCESS;
                        _patternResp.RESPONSE_DESCRIPTION = ConfigClass.SUCCESS;
                        _patternResp.PatternMaster = _patternMaster;
                        _patternResp.PatternDetails = _lstPatternDetails;
                    }
                    else
                    {
                        _patternResp.RESPONSE_CODE = ConfigClass.DATA_NOT_FOUND;
                        _patternResp.RESPONSE_DESCRIPTION = ConfigClass.DATA_NOT_FOUND_MESSAGE;
                        _patternResp.PatternMaster = null;
                        _patternResp.PatternDetails = null;
                    }
                }
                catch (Exception ex)
                {
                    _patternResp.RESPONSE_CODE = ConfigClass.INTERNAL_ERROR;
                    _patternResp.RESPONSE_DESCRIPTION = ConfigClass.INTERNAL_ERROR_MESSAGE;
                    _patternResp.PatternMaster = null;
                    _patternResp.PatternDetails = null;
                }
            }
            else
            {
                _patternResp.RESPONSE_CODE = ConfigClass.INVALID_REQUEST;
                _patternResp.RESPONSE_DESCRIPTION = ConfigClass.INVALID_REQUEST_MESSAGE;
                _patternResp.PatternMaster = null;
                _patternResp.PatternDetails = null;
            }

            return _patternResp;
        }
    }
}
