using Domain.ItaacDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AttendanceServiceRespDTO
{
    public class TimeSheetRespDTO
    {
        public string RESPONSE_CODE { get; set; }
        public string RESPONSE_DESCRIPTION { get; set; }
        public List<EmployeeTimeSheet>? lstTimeSheet { get; set; }
    }
}
