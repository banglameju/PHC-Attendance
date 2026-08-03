using Dapper;
using DataAccess.DbAccess;
using Domain.AttendanceServiceRespDTO;
using Domain.Core;
using Domain.CSBOracleModel;
using Domain.ItaacDTO;
using Domain.ITAACOracleModel;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class DataRepository : IDataRepository
    {
        private static readonly string[] SupportedDateFormats = ["yyyy-MM-dd", "dd-MM-yyyy"];
        private SqlDataAccess db = new SqlDataAccess();

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<int> SaveEventFaceLogs(List<TbEventFaceLog> eventFaceLogs)
        {
            if (eventFaceLogs == null)
            {
                throw new ArgumentNullException(nameof(eventFaceLogs));
            }

            if (eventFaceLogs.Count == 0)
            {
                return 0;
            }

            const string sql = @"INSERT INTO TB_EVENT_FACE_LOG
                (EVENT_LOG_ID, EMP_ID, ACCESS_DATE_TIME, ACCESS_DATE, ACCESS_TIME,
                 DEV_SN, DEV_NAME, EMP_FIRST_NAME, EMP_LAST_NAME, IS_PROCESSED)
                VALUES
                (:EventLogId, :EmpId, :AccessDateTime, :AccessDate, :AccessTime,
                 :DevSn, :DevName, :EmpFirstName, :EmpLastName, :IsProcessed)";

            await using var connection = new OracleConnection(ConfigClass.ConnectionStringITAAC);
            await connection.OpenAsync();
            await using var transaction = connection.BeginTransaction();

            try
            {
                // Serialize ID allocation because TB_EVENT_FACE_LOG does not use an Oracle sequence.
                await connection.ExecuteAsync(
                    "LOCK TABLE TB_EVENT_FACE_LOG IN EXCLUSIVE MODE",
                    transaction: transaction);

                var currentEventLogId = await connection.QuerySingleAsync<decimal>(
                    "SELECT NVL(MAX(EVENT_LOG_ID), 0) FROM TB_EVENT_FACE_LOG",
                    transaction: transaction);

                foreach (var eventFaceLog in eventFaceLogs)
                {
                    eventFaceLog.EventLogId = ++currentEventLogId;
                    eventFaceLog.IsProcessed = 0;
                }

                var rowsInserted = await connection.ExecuteAsync(sql, eventFaceLogs, transaction);
                await transaction.CommitAsync();
                return rowsInserted;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }


        public async Task<List<AttendanceLogDTO>> GetHikLogByCpr(string Cpr, string FromDate, string ToDate)
        {
            var (startOfDay, endDateExclusive) = DateRangeParser.Parse(FromDate, ToDate);

            using (IDbConnection connection = new NpgsqlConnection(ConfigClass.HikConnectionString))
            {
                string sql = $@"
                            SELECT 
                                ""ACCESS_DATE"" AS AttendanceDate,
                                ""ACCESS_TIME""::text AS AttendanceTime,
                                ""DEV_SN"" AS DeviceId,
                                ""DEV_NAME"" AS DeviceName
                            FROM public.access_logs
                            WHERE ""EMP_ID"" = @Cpr
                                AND ""ACCESS_DATE_TIME"" >= @StartOfDay
                                AND ""ACCESS_DATE_TIME"" < @EndDateExclusive
                            ORDER BY ""ACCESS_DATE_TIME"" DESC;";
                var parameters = new
                {
                    Cpr,
                    StartOfDay = startOfDay,
                    EndDateExclusive = endDateExclusive
                };

                var results = await connection.QueryAsync<AttendanceLogDTO>(sql, parameters);
                return results.ToList();
            }

               
            //var getdata = await db.LoadData<AttendanceLogDTO, dynamic>(sql, new { }, ConfigClass.HikConnectionString);
            //return getdata;
        }

        public async Task<List<AccessLogDTO>> GetAccessLogsByCprs(IReadOnlyCollection<string> Cprs, string FromDate, string ToDate)
        {
            var (startOfDay, endDateExclusive) = DateRangeParser.Parse(FromDate, ToDate);

            const string sql = @"
                SELECT
                    ""EMP_ID"" AS EmpId,
                    ""ACCESS_DATE_TIME"" AS AccessDateTime,
                    ""ACCESS_DATE""::timestamp AS AccessDate,
                    (""ACCESS_TIME"" - TIME '00:00:00') AS AccessTime,
                    ""DEV_NAME"" AS DevName,
                    ""DEV_SN"" AS DevSn,
                    ""EMP_FIRST_NAME"" AS EmpFirstName,
                    ""EMP_LAST_NAME"" AS EmpLastName
                FROM public.access_logs
                WHERE ""EMP_ID"" = ANY(@Cprs)
                  AND ""ACCESS_DATE_TIME"" >= @StartDate
                  AND ""ACCESS_DATE_TIME"" < @EndDateExclusive
                ORDER BY ""EMP_ID"", ""ACCESS_DATE_TIME"";";

            using IDbConnection connection = new NpgsqlConnection(ConfigClass.HikConnectionString);
            var results = await connection.QueryAsync<PostgresAccessLogRow>(sql, new
            {
                Cprs = Cprs.ToArray(),
                StartDate = startOfDay,
                EndDateExclusive = endDateExclusive
            });
            return results.Select(row => new AccessLogDTO
            {
                EmpId = row.EmpId,
                AccessDateTime = row.AccessDateTime,
                AccessDate = row.AccessDate.HasValue
                    ? DateOnly.FromDateTime(row.AccessDate.Value)
                    : null,
                AccessTime = row.AccessTime.HasValue
                    ? TimeOnly.FromTimeSpan(row.AccessTime.Value)
                    : null,
                DevName = row.DevName,
                DevSn = row.DevSn,
                EmpFirstName = row.EmpFirstName,
                EmpLastName = row.EmpLastName
            }).ToList();
        }

        public async Task<List<AsEmployeeMst>> GetEmployeesByCostCenter(string CostCenter)
        {
            const string sql = @"SELECT
                EMPNO EmpNo, CPRNO CprNo, EMP_NAME EmpName, CC_CODE CcCode, CC_UNIT CcUnit,
                DESIG_CODE DesigCode, ADDRESS1 Address1, ADDRESS2 Address2, ADDRESS3 Address3,
                PHONE Phone, NATIONALITY Nationality, DOB Dob, SEX Sex, MARITALSTAT MaritalStat,
                JOIN_DATE JoinDate, PAYTYPE_CODE PayTypeCode, GRADE_CODE GradeCode, STEP_CODE StepCode,
                EMPLOYEE_TYPE EmployeeType, OVERTIME Overtime, CREATED_BY CreatedBy, CREATED_DATE CreatedDate,
                MODIFIED_BY ModifiedBy, MODIFIED_DATE ModifiedDate, LAST_ACTION LastAction,
                SUPERVISORID SupervisorId, ISSUPERVISOR IsSupervisor, ON_CALL OnCall, ON_STANDBY OnStandby,
                STATUS Status, EMAIL Email, ATTENDANCE_PATTERN AttendancePattern, MEDICAL_COMMITY MedicalCommity,
                DEDICATION Dedication, ACTIVE Active, RELIGION_CODE ReligionCode, MOH Moh, MAX_HRS MaxHrs,
                REGISTERED Registered, TERMINATION_DATE TerminationDate, NAT_TYPE NatType, REMARKS Remarks,
                BANK_CODE BankCode, ACCOUNT_NO AccountNo, EXT_NO ExtNo, BRANCH_CODE BranchCode,
                BRANCH_NAME BranchName, ORG_CODE OrgCode, ANNUAL_LEAVE_BAL AnnualLeaveBal,
                SICK_LEAVE_BAL SickLeaveBal, EMP_PER_EMAIL EmpPerEmail
                FROM AS_EMPLOYEE_MST
                WHERE CC_CODE = :CostCenter
                ORDER BY CPRNO";

            await using var connection = new OracleConnection(ConfigClass.ConnectionStringITAAC);
            var employees = await connection.QueryAsync<AsEmployeeMst>(sql, new { CostCenter });
            return employees.ToList();
        }

        private sealed class PostgresAccessLogRow
        {
            public string? EmpId { get; init; }
            public DateTime AccessDateTime { get; init; }
            public DateTime? AccessDate { get; init; }
            public TimeSpan? AccessTime { get; init; }
            public string? DevName { get; init; }
            public string? DevSn { get; init; }
            public string? EmpFirstName { get; init; }
            public string? EmpLastName { get; init; }
        }

        public async Task<List<AttendanceLogDTO>> GetBackupBioLogByCpr(string Cpr, string FromDate, string ToDate)
        {
            string sql = $@"SELECT CONVERT(date, DATEADD(second, l.nDateTime, '1970-01-01')) AS AttendanceDate,
                convert(varchar,DATEADD(s,l.nDateTime, '1970-01-01 00:00:00'),108) AS AttendanceTime,
                l.nReaderIdn AS DeviceId, r.sName AS DeviceName FROM TB_EVENT_LOG_BK l INNER JOIN TB_READER r 
                ON l.nReaderIdn = r.nReaderIdn WHERE l.nUserID = {Cpr}
                AND r.NTYPE NOT IN (1,2,3,11,113) 
                AND CONVERT(date, DATEADD(second, l.nDateTime, '1970-01-01'))
                BETWEEN CONVERT(date,'{FromDate}',105) 
                AND CONVERT(date,'{ToDate}',105) 
                ORDER BY AttendanceDate DESC, DATEADD(second, l.nDateTime, '1970-01-01');";
            var getdata = await db.LoadData<AttendanceLogDTO, dynamic>(sql, new { }, ConfigClass.BiostarConnectionString);
            return getdata;
        }

        public async Task<List<AttendanceLogDTO>> GetBioLogByCpr(string Cpr, string FromDate, string ToDate)
        {
            string sql = $@"SELECT CONVERT(date, DATEADD(second, l.nDateTime, '1970-01-01')) AS AttendanceDate,
                convert(varchar,DATEADD(s,l.nDateTime, '1970-01-01 00:00:00'),108) AS AttendanceTime,
                l.nReaderIdn AS DeviceId, r.sName AS DeviceName FROM TB_EVENT_LOG l INNER JOIN TB_READER r 
                ON l.nReaderIdn = r.nReaderIdn WHERE l.nUserID = {Cpr}
                AND r.NTYPE NOT IN (1,2,3,11,113) 
                AND CONVERT(date, DATEADD(second, l.nDateTime, '1970-01-01'))
                BETWEEN CONVERT(date,'{FromDate}',105) 
                AND CONVERT(date,'{ToDate}',105) 
                ORDER BY AttendanceDate DESC, DATEADD(second, l.nDateTime, '1970-01-01');";
            var getdata = await db.LoadData<AttendanceLogDTO, dynamic>(sql, new { }, ConfigClass.BiostarConnectionString);
            return getdata;
        }

        public async Task<List<HealthEmpAttendanceDTO>> GetEmpAtendanceByCpr(string Cpr,string FromDate, string ToDate)
        {
            string sql = "WITH AttTimeData AS (" +
                    " SELECT " +
                        //" nUserId AS Cpr," +
                        " l.nReaderIdn AS ReaderId," +
                        " r.sName AS ReaderName," +
                        " convert(varchar,dateadd(s,nDateTime, '1970-01-01 00:00:00'),105) AS AttendanceDate," +
                        " convert(DATE,dateadd(s,nDateTime, '1970-01-01 00:00:00'),105) AS AttDate, " +
                        " convert(varchar,dateadd(s,nDateTime, '1970-01-01 00:00:00'),108) AS AttendanceTime," +
                        " ROW_NUMBER() OVER (PARTITION BY convert(varchar,dateadd(s,nDateTime, '1970-01-01 00:00:00'),105) " +
                    " ORDER BY convert(varchar,dateadd(s,nDateTime, '1970-01-01 00:00:00'),105)) AS RowNum" +
                    " FROM TB_EVENT_LOG l inner join TB_READER r on l.nReaderIdn = r.nReaderIdn " +
                    " where nUserID = '" + Cpr + "' and r.NTYPE NOT IN(1,2,3,11,113) " +
                    " and convert(date,dateadd(s,nDateTime, '1970-01-01 00:00:00'),105) " +
                    " between convert(date,'" + FromDate + "',105) and convert(date,'" + ToDate + "',105)" +
                " ) " +
                " SELECT  " +
                    //" Cpr, " +
                    " AttendanceDate," +
                    " MAX(CASE WHEN RowNum = 1 THEN AttendanceTime END) AS Time1, " +
                    " MAX(CASE WHEN RowNum = 1 THEN ReaderId END) AS DeviceId1, " +
                    " MAX(CASE WHEN RowNum = 1 THEN ReaderName END) AS DeviceName1, " +

                    " MAX(CASE WHEN RowNum = 2 THEN AttendanceTime END) AS Time2, " +
                    " MAX(CASE WHEN RowNum = 2 THEN ReaderId END) AS DeviceId2, " +
                    " MAX(CASE WHEN RowNum = 2 THEN ReaderName END) AS DeviceName2, " +

                    " MAX(CASE WHEN RowNum = 3 THEN AttendanceTime END) AS Time3, " +
                    " MAX(CASE WHEN RowNum = 3 THEN ReaderId END) AS DeviceId3, " +
                    " MAX(CASE WHEN RowNum = 3 THEN ReaderName END) AS DeviceName3, " +

                    " MAX(CASE WHEN RowNum = 4 THEN AttendanceTime END) AS Time4, " +
                    " MAX(CASE WHEN RowNum = 4 THEN ReaderId END) AS DeviceId4, " +
                    " MAX(CASE WHEN RowNum = 4 THEN ReaderName END) AS DeviceName4, " +

                    " MAX(CASE WHEN RowNum = 5 THEN AttendanceTime END) AS Time5, " +
                    " MAX(CASE WHEN RowNum = 5 THEN ReaderId END) AS DeviceId5," +
                    " MAX(CASE WHEN RowNum = 5 THEN ReaderName END) AS DeviceName5," +

                    " MAX(CASE WHEN RowNum = 6 THEN AttendanceTime END) AS Time6, " +
                    " MAX(CASE WHEN RowNum = 6 THEN ReaderId END) AS DeviceId6, " +
                    " MAX(CASE WHEN RowNum = 6 THEN ReaderName END) AS DeviceName6, " +

                    " MAX(CASE WHEN RowNum = 7 THEN AttendanceTime END) AS Time7, " +
                    " MAX(CASE WHEN RowNum = 7 THEN ReaderId END) AS DeviceId7, " +
                    " MAX(CASE WHEN RowNum = 7 THEN ReaderName END) AS DeviceName7, " +

                    " MAX(CASE WHEN RowNum = 8 THEN AttendanceTime END) AS Time8, " +
                    " MAX(CASE WHEN RowNum = 8 THEN ReaderId END) AS DeviceId8, " +
                    " MAX(CASE WHEN RowNum = 8 THEN ReaderName END) AS DeviceName8 " +
                " FROM AttTimeData " +
                //" GROUP BY CPR,AttDate,AttendanceDate " +
                " GROUP BY AttDate,AttendanceDate " +
                " ORDER BY AttDate desc";
            var getdata = await db.LoadData<HealthEmpAttendanceDTO, dynamic>(sql, new { }, ConfigClass.BiostarConnectionString);
            return getdata;
        }
        public async Task<List<HealthEmpAttendanceDTO>> GetEmpAtendanceBackupByCpr(string Cpr, string FromDate, string ToDate)
        {
            string sql = "WITH AttTimeData AS (" +
                    " SELECT " +
                        //" nUserId AS Cpr," +
                        " l.nReaderIdn AS ReaderId," +
                        " r.sName AS ReaderName," +
                        " convert(varchar,dateadd(s,nDateTime, '1970-01-01 00:00:00'),105) AS AttendanceDate," +
                        " convert(DATE,dateadd(s,nDateTime, '1970-01-01 00:00:00'),105) AS AttDate, " +
                        " convert(varchar,dateadd(s,nDateTime, '1970-01-01 00:00:00'),108) AS AttendanceTime," +
                        " ROW_NUMBER() OVER (PARTITION BY convert(varchar,dateadd(s,nDateTime, '1970-01-01 00:00:00'),105) " +
                    " ORDER BY convert(varchar,dateadd(s,nDateTime, '1970-01-01 00:00:00'),105)) AS RowNum" +
                    " FROM TB_EVENT_LOG_BK l inner join TB_READER r on l.nReaderIdn = r.nReaderIdn " +
                    " where nUserID = '" + Cpr + "' and r.NTYPE NOT IN(1,2,3,11,113) " +
                    " and convert(date,dateadd(s,nDateTime, '1970-01-01 00:00:00'),105) " +
                    " between convert(date,'" + FromDate + "',105) and convert(date,'" + ToDate + "',105)" +
                " ) " +
                " SELECT  " +
                    //" Cpr, " +
                    " AttendanceDate," +
                    " MAX(CASE WHEN RowNum = 1 THEN AttendanceTime END) AS Time1, " +
                    " MAX(CASE WHEN RowNum = 1 THEN ReaderId END) AS DeviceId1, " +
                    " MAX(CASE WHEN RowNum = 1 THEN ReaderName END) AS DeviceName1, " +

                    " MAX(CASE WHEN RowNum = 2 THEN AttendanceTime END) AS Time2, " +
                    " MAX(CASE WHEN RowNum = 2 THEN ReaderId END) AS DeviceId2, " +
                    " MAX(CASE WHEN RowNum = 2 THEN ReaderName END) AS DeviceName2, " +

                    " MAX(CASE WHEN RowNum = 3 THEN AttendanceTime END) AS Time3, " +
                    " MAX(CASE WHEN RowNum = 3 THEN ReaderId END) AS DeviceId3, " +
                    " MAX(CASE WHEN RowNum = 3 THEN ReaderName END) AS DeviceName3, " +

                    " MAX(CASE WHEN RowNum = 4 THEN AttendanceTime END) AS Time4, " +
                    " MAX(CASE WHEN RowNum = 4 THEN ReaderId END) AS DeviceId4, " +
                    " MAX(CASE WHEN RowNum = 4 THEN ReaderName END) AS DeviceName4, " +

                    " MAX(CASE WHEN RowNum = 5 THEN AttendanceTime END) AS Time5, " +
                    " MAX(CASE WHEN RowNum = 5 THEN ReaderId END) AS DeviceId5," +
                    " MAX(CASE WHEN RowNum = 5 THEN ReaderName END) AS DeviceName5," +

                    " MAX(CASE WHEN RowNum = 6 THEN AttendanceTime END) AS Time6, " +
                    " MAX(CASE WHEN RowNum = 6 THEN ReaderId END) AS DeviceId6, " +
                    " MAX(CASE WHEN RowNum = 6 THEN ReaderName END) AS DeviceName6, " +

                    " MAX(CASE WHEN RowNum = 7 THEN AttendanceTime END) AS Time7, " +
                    " MAX(CASE WHEN RowNum = 7 THEN ReaderId END) AS DeviceId7, " +
                    " MAX(CASE WHEN RowNum = 7 THEN ReaderName END) AS DeviceName7, " +

                    " MAX(CASE WHEN RowNum = 8 THEN AttendanceTime END) AS Time8, " +
                    " MAX(CASE WHEN RowNum = 8 THEN ReaderId END) AS DeviceId8, " +
                    " MAX(CASE WHEN RowNum = 8 THEN ReaderName END) AS DeviceName8 " +
                " FROM AttTimeData " +
                //" GROUP BY CPR,AttDate,AttendanceDate " +
                " GROUP BY AttDate,AttendanceDate " +
                " ORDER BY AttDate desc";
            var getdata = await db.LoadData<HealthEmpAttendanceDTO, dynamic>(sql, new { }, ConfigClass.BiostarConnectionString);
            return getdata;
        }
        public async Task<List<PatternDTO>> GetPatterDetailsByCode(string PatternCode)
        {
            string sql = "SELECT PM.PATTERN_TYPE,PM.PATTERN_CODE, "+
                            "PM.PATTERN_NAME,PM.FLEXI,PM.IS_RAMADAN,PM.EXTENDED, "+
                            "PD.DAY,PD.START_TIME,PD.END_TIME,PD.START_GRACE_TIME, "+
                            "PD.END_GRACE_TIME,PD.SEQ_NO,PD.NIGHT_SHIFT,PD.HOLIDAY "+
                            "FROM  "+
                            "AS_PATTERN_MASTER PM INNER JOIN AS_PATTERN_DETAILS PD "+
                            "ON PM.PATTERN_CODE = PD.PATTERN_CODE "+
                            "WHERE PD.PATTERN_CODE = '2'";
            var getdata = await db.LoadDataOracle<PatternDTO, dynamic>(sql, new { }, ConfigClass.ConnectionStringITAAC);
            return getdata;
        }
        public async Task<List<Csb_Health_Leave_Trans>> GetHealthLeaveTransactions(string Cpr, string FromDate, string ToDate)
        {
            string sql = " SELECT LT.CPR,LT.LEAVE_TYPE,LT.FROM_DATE,LT.TO_DATE,LT.NO_OF_DAYS,LT.4,LT.INSERT_DATE,LT.ABSENCE_ID "+
                         " FROM CSB_USER.CSB_HEALTH_LEAVE_TRANS LT "+
                         " WHERE CPR = '"+ Cpr + "' "+
                         " AND LT.FROM_DATE <= TO_DATE('"+ToDate+"', 'DD-MM-YYYY') + 1 - 1 / 86400 "+
                         " AND LT.TO_DATE >= TO_DATE('"+ FromDate + "', 'DD-MM-YYYY') "+
                         " ORDER BY LT.FROM_DATE ";
            var getdata = await db.LoadDataOracle<Csb_Health_Leave_Trans, dynamic>(sql, new { }, ConfigClass.ConnectionStringITAAC);
            return getdata;
        }
        public async Task<List<EmployeePatternDTO>> GetEmployeePattern(string CprNumber)
        {
            string sql = "SELECT EP.EMPNO, "+
                            "EP.CC_CODE, "+
                            "EP.CC_UNIT, " +
                            "EP.FROMDATE, " +
                            "EP.TODATE, " +
                            "EP.PATTERN_TYPE, " +
                            "EP.PATTERN_CODE, " +
                            "EP.PERM, " +
                            "EP.STATUS, " +
                            "EP.MAX_HRS FROM AS_EMP_PATTERN EP WHERE EP.EMPNO = '"+ CprNumber + "' ";
            var getdata = await db.LoadDataOracle<EmployeePatternDTO, dynamic>(sql, new { }, ConfigClass.ConnectionStringITAAC);
            return getdata;
        }
        public async Task<List<EmployeeTimeSheet>> GetTimeSheetByCpr(string CprNumber, string FromDate, string ToDate)
        {
            string sql = "SELECT "+ 
                            " EMP_ID,"+
                            " EMP_NAME," +
                            " PLAN_TYPE," +
                            " TO_CHAR(TO_DATE(LOGDATE),'DD-MM-YYYY') AS LOG_DATE," +
                            " LOGDAY," +
                            " NORMAL_IN," +
                            " NORMAL_OUT," +
                            " NORMAL_HOURS," +
                            " NORMAL_EXTRA_HOURS, " +
                            " EXTRA_IN," +
                            " EXTRA_OUT," +
                            " EXTRA_HOURS," +
                            " TOTAL_EXTRA_HOURS, " +
                            " STATUS," +
                            " ABNORMAL," +
                            " ATTENDANCE_PATTERN," +
                            " PATTERN_TYPE," +
                            " PATTERN_START_TIME, " +
                            " PATTERN_END_TIME," +
                            " START_GRACE_TIME," +
                            " END_GRACE_TIME," +
                            " HOLFROMDATE," +
                            " HOLTODATE," +
                            " LEAVEFROMDATE," +
                            " LEAVETODATE," +
                            " LEAVEDESC," +
                            " HOLIDAY," +
                            " FLEXI," +
                            " CRE_BY," +
                            " CRE_DATE," +
                            " OT_VERIFIED_HRS," +
                            " OT_PENDED_HRS," +
                            " REMARKS" +
                            " FROM " +
                            " AS_EMP_TIME_SHEET" +
                            " WHERE EMP_ID = '"+CprNumber+"' AND TO_DATE(LOGDATE) BETWEEN" +
                            " TO_DATE(TO_CHAR(TO_DATE('"+FromDate+"', 'DD-MM-YYYY'),'DD-MON-YYYY')) " +
                            " AND TO_DATE(TO_CHAR(TO_DATE('"+ToDate+"', 'DD-MM-YYYY'),'DD-MON-YYYY')) " +
                            " ORDER BY TO_DATE(LOGDATE) DESC ";
            var getdata = await db.LoadDataOracle<EmployeeTimeSheet, dynamic>(sql, new { }, ConfigClass.ConnectionStringITAAC);
            return getdata;
        }

        //public async Task<List<AllRequestListDTO>> GetAllRequestByCprAndRequestType(RequestListReqDTO requestListReqDTO)
        //{            
        //    if (requestListReqDTO.RequesterCpr == null || requestListReqDTO.RequesterCpr.Equals(""))
        //    {
        //        requestListReqDTO.RequesterCpr = "%";
        //    }

        //    string sql = "select req.RequestId,req.RequesterId,r.RequesterCpr,r.RequesterName,r.MobileNumber,req.RefNumber,req.StatusId,s.StatusDesc,req.Note,req.RequestTypeId,t.RequestTypeDesc,req.CreatedBy,req.CreatedDate from transactions.Requests req inner join master.Requester r on req.RequesterId = r.RequesterId inner join master.RequestStatus s on req.StatusId = s.StatusId inner join master.RequestType t on req.RequestTypeId = t.RequestTypeId where r.RequesterCpr like '" + requestListReqDTO.RequesterCpr + "' and  ";
        //    if (requestListReqDTO.RequestTypeId > 0)
        //    {
        //        sql += " req.RequestTypeId = '"+ requestListReqDTO.RequestTypeId + "' and ";
        //    }
        //    var getdata = await db.LoadData<AllRequestListDTO, dynamic>(sql+" req.Active = 1 order by req.CreatedDate desc", new { }, ConfigClass.ConnectionString);
        //    return getdata;
        //}   

        //public async Task<List<HealthCenter>> GetPhcHcByBlock(string blockNo)
        //{
        //    string sql = " select * from master.HealthCenter where Blocks like  '%" + blockNo + "%' ";
        //    var getdata = await db.LoadData<HealthCenter, dynamic>(sql, new { }, ConfigClass.ConnectionStringAppointment);
        //    return getdata;
        //}

        //public async Task<List<string>> GenerateAppointmentSlots(GenerateAppointmentReqDTO req)
        //{            
        //    List<string> getdata = await db.GenerateAppointmentProcess<string, dynamic>("prcGenerateAppointmentSlot", req, ConfigClass.ConnectionStringAppointment);
        //    return getdata;
        //}

        //public async Task<List<int>> GetSessionExistance(GenerateAppointmentReqDTO req)
        //{
        //    string sql = " SELECT * FROM dbo.SessionValidation ('" + req.FromDate+"','"+req.ToDate+"','"+req.ClinicId+"') ";
        //    List<int> getdata = await db.LoadData<int, dynamic>(sql, new { }, ConfigClass.ConnectionStringAppointment);
        //    return getdata;
        //}

        //public async Task<List<AvailableDateDTO>> GetAvailableDates(int HospitalId)
        //{
        //    string sql = "  select * from dbo.GetAvailableDate('" + HospitalId+"') ";
        //    var getdata = await db.LoadData<AvailableDateDTO, dynamic>(sql, new { }, ConfigClass.ConnectionStringAppointment);
        //    return getdata;
        //}

        //public async Task<List<AvailableSlotsDTO>> GetAvailableSlots(int SessionId)
        //{
        //    string sql = "select sl.SlotId,Convert(NVARCHAR,sl.FromTime,105) AppointmentDate,FORMAT (convert(datetime,sl.FromTime), 'HH:mm') FromTime,FORMAT (convert(datetime,sl.ToTime), 'HH:mm') ToTime from dental.SessionSlot sl where SessionId = '" + SessionId+"' ";
        //    var getdata = await db.LoadData<AvailableSlotsDTO, dynamic>(sql, new { }, ConfigClass.ConnectionStringAppointment);
        //    return getdata;
        //}

        //public async Task<List<AppointmentDetail>> GetAppointmentDetails(string CprNumber)
        //{
        //    string sql = "select det.* from dental.AppointmentDetails det inner join dental.SessionSlot sl on det.SlotId = sl.SlotId where det.CprNumber = '"+ CprNumber + "' and convert(date,sl.FromTime,101) >= convert(date,CURRENT_TIMESTAMP,101) and ResponseMessage = 'Success' ";
        //    var getdata = await db.LoadData<AppointmentDetail, dynamic>(sql, new { }, ConfigClass.ConnectionStringAppointment);
        //    return getdata;
        //}

        //public async Task<List<AppointmentDetail>> BookAppointment(BookAppointmentReqDTO req)
        //{
        //    var getdata = await db.BookAppointmentProcess<AppointmentDetail, dynamic>("prcBookAppointment", req, ConfigClass.ConnectionStringAppointment);
        //    return getdata;
        //}


        //public async Task<List<int>> BookAppointment(int SlotId)
        //{
        //    //select sl.IsSlotAvailable from dental.SessionSlot sl where sl.SlotId = 17
        //    string sql = "select sl.SlotId,Convert(NVARCHAR,sl.FromTime,105) AppointmentDate,FORMAT (convert(datetime,sl.FromTime), 'HH:mm') FromTime,FORMAT (convert(datetime,sl.ToTime), 'HH:mm') ToTime from dental.SessionSlot sl where SessionId = '" + SessionId + "' ";
        //    var getdata = await db.LoadData<AvailableSlotsDTO, dynamic>(sql, new { }, ConfigClass.ConnectionStringAppointment);
        //    return getdata;
        //}
    }
}
