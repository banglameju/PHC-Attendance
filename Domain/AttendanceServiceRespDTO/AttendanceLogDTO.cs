using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AttendanceServiceRespDTO
{
    public class AttendanceLogDTO
    {
        public DateTime? AttendanceDate { get; set; }
        public string? AttendanceTime { get; set; }
        public string? DeviceId { get; set; }
        public string? DeviceName { get; set; }
    }
}
