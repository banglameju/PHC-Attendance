using Domain.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = ConfigClass.ConnectionString;

            using (IDbConnection connection = new SqlConnection(connectionStringName))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters).ToList();

                return rows;
            }
        }

        public async Task<List<T>> LoadDataOracle<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = ConfigClass.ConnectionString;

            using (IDbConnection connection = new OracleConnection(connectionStringName))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters).ToList();

                return rows;
            }
        }

        public async Task SaveListOfData<T>(string storedProcedure, List<T> ClassList, string connectionStringName)
        {
            string connectionString = ConfigClass.ConnectionString;

            using (IDbConnection connection = new SqlConnection(connectionStringName))
            {
                await connection.ExecuteAsync(storedProcedure, commandType: CommandType.Text);
            }
        }

        public void SaveListOfDataWitoutAsync<T>(string storedProcedure, List<T> ClassList, string connectionStringName)
        {
            string connectionString = ConfigClass.ConnectionString;

            using (IDbConnection connection = new SqlConnection(connectionStringName))
            {
                connection.Execute(storedProcedure, commandType: CommandType.Text);
            }
        }

        public async Task SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = ConfigClass.ConnectionString;

            using (IDbConnection connection = new SqlConnection(connectionStringName))
            {
                await connection.ExecuteAsync(storedProcedure, parameters);
            }
        }

        //public async Task<List<string>> GenerateAppointmentProcess<T, U>(string storedProcedure,GenerateAppointmentReqDTO req, string connectionStringName)
        //{
        //    string connectionString = connectionStringName;

        //    using (var con = new SqlConnection(connectionString))
        //    {
        //        return (List<string>)con.Query<string>(storedProcedure,
        //            param: new { req.ClinicId, req.FromDate, req.ToDate, req.FromTime, req.ToTime, req.UserName },
        //            commandType: System.Data.CommandType.StoredProcedure);
        //    }
        //}

        //public async Task<List<AppointmentDetail>> BookAppointmentProcess<T, U>(string storedProcedure, BookAppointmentReqDTO req, string connectionStringName)
        //{
        //    string connectionString = connectionStringName;

        //    using (var con = new SqlConnection(connectionString))
        //    {
        //        return (List<AppointmentDetail>)con.Query<AppointmentDetail>(storedProcedure,
        //            param: new { req.PatientCpr, req.PatientFullNameEn, req.PatientFullNameAr, req.DateOfBirth, req.BlockNo, req.RoadNo,req.Building,req.Flat,req.Mobile,req.SlotId,req.UserName },
        //            commandType: System.Data.CommandType.StoredProcedure);
        //    }
        //}

        //public async Task<List<PayrollAndFinanceDTO>> ExecuteRefCursor<T, U>(string storedProcedure, string P_MONTH, string P_YEAR, string connectionStringName)
        //{
        //    List<PayrollAndFinanceDTO> lstResp = new();
        //    string resp;
        //    string cpr = "";
        //    using (OracleConnection connection = new OracleConnection(connectionStringName))
        //    {
        //        OracleCommand cmd = new OracleCommand("P_GET_PAYROLL_DETAILS", connection);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        OracleParameter p1 = cmd.Parameters.Add("p_month", OracleDbType.Varchar2);
        //        p1.Value = P_MONTH;
        //        p1.Direction = ParameterDirection.Input;

        //        OracleParameter p2 = cmd.Parameters.Add("p_year", OracleDbType.Varchar2);
        //        p2.Value = P_YEAR;
        //        p2.Direction = ParameterDirection.Input;

        //        OracleParameter p3 = cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor);
        //        p3.Direction = ParameterDirection.Output;

        //        try
        //        {
        //            connection.Open();
        //            cmd.ExecuteNonQuery();

        //            OracleDataReader reader1 = ((OracleRefCursor)p3.Value).GetDataReader();
        //            while (reader1.Read())
        //            {
        //                PayrollAndFinanceDTO dto = new PayrollAndFinanceDTO();
        //                dto.emp_cpr = reader1["EMP_ID"].ToString();
        //                dto.emp_name = reader1["EMP_NAME"].ToString();
        //                dto.position_title = reader1["POSITION_TITLE"].ToString();
        //                dto.payroll_grade_step = reader1["PAYROLL_GRADE_STEP"].ToString();
        //                dto.current_grade_step = reader1["CURRENT_GRADE_STEP"].ToString();
        //                dto.basic = Convert.ToDouble(reader1["BASIC"].ToString());
        //                dto.other_allowances = Convert.ToDouble(reader1["OTHER_ALLOWANCES"].ToString());
        //                dto.shifts = Convert.ToDouble(reader1["SHIFT_2_3"].ToString());
        //                dto.standby_hours = reader1["STANDBY_HOURS"].ToString();
        //                dto.standby_amount = Convert.ToDouble(reader1["STANDBY_AMOUNT"].ToString());
        //                dto.dedication_hours = reader1["DEDICATION_HOURS"].ToString();
        //                dto.dedication_amount = Convert.ToDouble(reader1["DEDICATION_AMOUNT"].ToString());
        //                dto.pattern_type = reader1["PATTERN_TYPE"].ToString();
        //                dto.pattern_description = reader1["PATTERN_DESC"].ToString();
        //                lstResp.Add(dto);
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //    }

        //    return lstResp;
        //}
    }
}
