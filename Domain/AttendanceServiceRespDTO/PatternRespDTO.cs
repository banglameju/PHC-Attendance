using Domain.ItaacDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AttendanceServiceRespDTO
{
    public class PatternRespDTO
    {
        public string RESPONSE_CODE { get; set; }
        public string RESPONSE_DESCRIPTION { get; set; }
        public PatternMaster? PatternMaster { get; set; }
        public List<PatternDetails>? PatternDetails { get; set; }
    }
}
