using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AttendanceServiceRespDTO
{
    public class AttendanceLogRespDTO
    {
        public string? RESPONSE_CODE { get; set; }
        public string? RESPONSE_DESCRPTION { get; set; }
        public string? Cpr { get; set; }
        public List<AttendanceLogDTO>? lstData { get; set; }
    }
}
