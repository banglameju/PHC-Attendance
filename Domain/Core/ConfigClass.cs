using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core
{
    public static class ConfigClass
    {
        //PHC SQL RDS
        //public static string ConnectionString = "Server=Phc-test-aws-db-1.cqlz3th81aq4.eu-west-1.rds.amazonaws.com;Database=PHCServices;Trusted_Connection=True;Integrated Security=false;User Id=admin;Password=9jVF4ribk4LMOd6yV9V9;TrustServerCertificate=True";
        public static string ConnectionString = "Server=phcawsprodmssql1.c93fmaje3wb1.eu-west-1.rds.amazonaws.com;Database=PHCServices;Trusted_Connection=True;Integrated Security=false;User Id=admin;Password=VjdO9pnljHQvEfmHzoIo;TrustServerCertificate=True";

        //Scaffold-DbContext "Host=phc-taacs-proddb.cqpw79y6zq7h.me-south-1.rds.amazonaws.com;Database=hikpro;Username=hikpro;Password=hikpro" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir HikProModels -ContextDir Data -Context HikProDbContext -Force

        public static string BiostarConnectionString = "Server=10.23.127.27;Database=Biostar;Trusted_Connection=True;Integrated Security=false;User Id=biosa;Password=Moh@123;TrustServerCertificate=True";
        public static string HikConnectionString = "Host=phc-taacs-proddb.c93fmaje3wb1.eu-west-1.rds.amazonaws.com;Database=hikpro;Username=hikpro;Password=hikpro;Trust Server Certificate=True;";
        
        //public static string ConnectionStringVaccine = "Data Source=10.23.26.29;Initial Catalog=CdService;User ID=MOHwebsite_user;Password=site-MOH$4738;Encrypt=False";
        public static string ConnectionStringVaccine = "Data Source=moh-sql-db.cor2awkipd5v.me-south-1.rds.amazonaws.com;Initial Catalog=BlazorApp;user id=CDAppUser;password=5004268;Encrypt=False";


        //public static string ConnectionStringAppointment = "Server=Phc-test-aws-db-1.cqlz3th81aq4.eu-west-1.rds.amazonaws.com;Database=PHCAppointments;Trusted_Connection=True;Integrated Security=false;User Id=admin;Password=9jVF4ribk4LMOd6yV9V9;TrustServerCertificate=True";
        public static string ConnectionStringAppointment = "Server=phcawsprodmssql1.c93fmaje3wb1.eu-west-1.rds.amazonaws.com;Database=PHCAppointments;Trusted_Connection=True;Integrated Security=false;User Id=admin;Password=VjdO9pnljHQvEfmHzoIo;TrustServerCertificate=True";



        //public static string ConnectionString = "Server=localhost;Database=CAPITATION;User Id=sa; Password=123";
        //public static string ConnectionString = "Server=moh-sql-db.cor2awkipd5v.me-south-1.rds.amazonaws.com;Database=CAPITATION;User Id=capitation_admin; Password=capitation_admin";        

        public static string ConnectionStringMOHWeb = "Data Source=localhost;Initial Catalog=MOHWebsite2015;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //public static string ConnectionString = "Data Source=NEAMA-GPC;Initial Catalog=PHCCapitation_new;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //public static string ConnectionStringITAAC = "(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = orac.cor2awkipd5v.me-south-1.rds.amazonaws.com)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orac)))";
        public static string ConnectionStringITAAC = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = orac-ir.cnr6xmhgotrc.eu-west-1.rds.amazonaws.com)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = orac))); Persist Security Info=True;User Id = ITAAC_USER; Password=ITAAC_USER";

        public const string MESSAGE_TYPE_SUCCESS = "SUCCESS";
        public const string MESSAGE_TYPE_WARNING = "WARNING";
        public const string MESSAGE_TYPE_ERROR = "ERROR";

        public const string SUCCESS = "001";
        public const string SUCCESS_MESSAGE = "Success";

        public const string WARNING = "004";
        public const string WARNING_MESSAGE = "Warning";

        public const string FAILURE = "002";
        public const string FAILURE_MESSAGE = "Failure";

        public const string DATA_NOT_FOUND = "003";
        public const string DATA_NOT_FOUND_MESSAGE = "No data found";

        public const string DATE_NOT_AVAILABLE = "004";
        public const string DATE_NOT_AVAILABLE_MESSAGE = "Dates not available";

        public const string SLOT_NOT_AVAILABLE = "005";
        public const string SLOT_NOT_AVAILABLE_MESSAGE = "Slot not available. Select another date";

        public const string UPCOMING_APPOINTMENT = "006";
        public const string UPCOMING_APPOINTMENT_MESSAGE = "Upcoming appointment";

        public const string NO_APPOINTMENT = "007";
        public const string No_APPOINTMENT_MESSAGE = "No appointment";

        public const string APPOINTMENT_DETAILS_RETRIEVE_FAILURE = "008";
        public const string APPOINTMENT_DETAILS_RETRIEVE_FAILURE_MESSAGE = "Error while getting data";

        public const string APPT_BOOKING_FAILURE = "009";
        public const string APPT_BOOKING_FAILURE_MESSAGE = "Error while booking appointment";

        public const string INVALID_REQUEST = "010";
        public const string INVALID_REQUEST_MESSAGE = "Invalid Request!";

        public const string INTERNAL_ERROR = "011";
        public const string INTERNAL_ERROR_MESSAGE = "";
    }
}
