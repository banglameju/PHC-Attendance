using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ItaacDTO
{
    public class PatternMaster
    {
        public string? PATTERN_TYPE { get; set; }
        public string PATTERN_CODE { get; set; }
        public string? PATTERN_NAME { get; set; }
        public string? FLEXI { get; set; }
        public string? IS_RAMADAN { get; set; }
        public string? EXTENDED { get; set; }
    }
}
