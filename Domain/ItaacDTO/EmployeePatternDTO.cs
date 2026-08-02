using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ItaacDTO
{
    public class EmployeePatternDTO
    {
        public string? EMPNO { get; set; }
        public string? CC_CODE { get; set; }
        public string? CC_UNIT { get; set; }
        public DateTime? FROMDATE { get; set; }
        public DateTime? TODATE { get; set; }
        public string? PATTERN_TYPE { get; set; }
        public string? PATTERN_CODE { get; set; }
        public string? PERM { get; set; }
        public string? STATUS { get; set; }
        public int? MAX_HRS { get; set; }
    }
}
