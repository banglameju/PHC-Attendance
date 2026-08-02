using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ItaacDTO
{
    public class EmployeeTimeSheet
    {

        public string EMP_ID { get; set; }
        public string EMP_NAME { get; set; }
        public string PLAN_TYPE { get; set; }
        public string LOG_DATE { get; set; }
        public string LOGDAY { get; set; }
        public string NORMAL_IN { get; set; }
        public string NORMAL_OUT { get; set; }
        public string NORMAL_HOURS { get; set; }
        public string NORMAL_EXTRA_HOURS { get; set; }
        public string EXTRA_IN { get; set; }
        public string EXTRA_OUT { get; set; }
        public string EXTRA_HOURS { get; set; }
        public string TOTAL_EXTRA_HOURS { get; set; }
        public string STATUS { get; set; }
        public string ABNORMAL { get; set; }
        public string ATTENDANCE_PATTERN { get; set; }
        public string PATTERN_TYPE { get; set; }
        public string PATTERN_START_TIME { get; set; }
        public string PATTERN_END_TIME { get; set; }
        public int START_GRACE_TIME { get; set; }
        public int END_GRACE_TIME { get; set; }
        public DateTime HOLFROMDATE { get; set; }
        public DateTime HOLTODATE { get; set; }
        public DateTime LEAVEFROMDATE { get; set; }
        public DateTime LEAVETODATE { get; set; }
        public string LEAVEDESC { get; set; }
        public string HOLIDAY { get; set; }
        public string FLEXI { get; set; }
        public string CRE_BY { get; set; }
        public DateTime CRE_DATE { get; set; }
        public string OT_VERIFIED_HRS { get; set; }
        public string OT_PENDED_HRS { get; set; }
        public string REMARKS { get; set; }
    }
}
