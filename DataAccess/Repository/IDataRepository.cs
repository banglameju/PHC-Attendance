using Domain.AttendanceServiceRespDTO;
using Domain.CSBOracleModel;
using Domain.ItaacDTO;
using Domain.ITAACOracleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IDataRepository : IDisposable
    {
        Task<List<AttendanceLogDTO>> GetHikLogByCpr(string Cpr, string FromDate, string ToDate);
        Task<List<AccessLogDTO>> GetAccessLogsByCprs(IReadOnlyCollection<string> Cprs, string FromDate, string ToDate);
        Task<List<HikProAccessLogDTO>> GetHikProAccessLogs(HikProAccessLogRequestDTO request);
        Task<HikProAccessLogProcessResultDTO> SaveAndProcessHikProAccessLogs(
            IReadOnlyCollection<HikProAccessLogDTO> accessLogs);
        Task<List<AsEmployeeMst>> GetEmployees(string? CostCenter, string? Cpr);
        Task<List<AttendanceLogDTO>> GetBackupBioLogByCpr(string Cpr, string FromDate, string ToDate);
        Task<List<AttendanceLogDTO>> GetBioLogByCpr(string Cpr, string FromDate, string ToDate);
        Task<List<BiostarLogDTO>> GetBioLogsByCprs(IReadOnlyCollection<string> Cprs, string FromDate, string ToDate);
        Task<List<HealthEmpAttendanceDTO>> GetEmpAtendanceByCpr(string Cpr, string FromDate, string ToDate);
        Task<List<EmployeeTimeSheet>> GetTimeSheetByCpr(string CprNumber, string FromDate, string ToDate);
        Task<List<EmployeePatternDTO>> GetEmployeePattern(string CprNumber);
        Task<List<PatternDTO>> GetPatterDetailsByCode(string PatternCode);
        Task<List<Csb_Health_Leave_Trans>> GetHealthLeaveTransactions(string Cpr, string FromDate, string ToDate);
        Task<List<HealthEmpAttendanceDTO>> GetEmpAtendanceBackupByCpr(string Cpr, string FromDate, string ToDate);
        Task<EventFaceLogProcessResult> SaveAndProcessEventFaceLogs(List<TbEventFaceLog> eventFaceLogs);
        Task<List<AsTimeEventLog>> GetItaacTimeEventLogs(IReadOnlyCollection<ItaacTimeEventLogLookupDTO> logs);

        //Task<List<AllRequestListDTO>> GetAllRequest();
        //Task<List<AllRequestListDTO>> GetAllRequestByCprAndRequestType(RequestListReqDTO requestListReqDTO);
        //Task<List<HealthCenter>> GetPhcHcByBlock(string blockNo);
        //Task<List<string>> GenerateAppointmentSlots(GenerateAppointmentReqDTO req);
        //Task<List<int>> GetSessionExistance(GenerateAppointmentReqDTO req);
        //Task<List<AvailableDateDTO>> GetAvailableDates(int HospitalId);
        //Task<List<AvailableSlotsDTO>> GetAvailableSlots(int SessionId);
        //Task<List<AppointmentDetail>> GetAppointmentDetails(string CprNumber);
        //Task<List<AppointmentDetail>> BookAppointment(BookAppointmentReqDTO req);
    }
}
