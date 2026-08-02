using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ItaacDTO
{
    public class PatternDetails
    {
        public string DAY { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public string START_GRACE_TIME { get; set; }
        public string END_GRACE_TIME { get; set; }
        public string SEQ_NO { get; set; }
        public string NIGHT_SHIFT { get; set; }
        public string HOLIDAY { get; set; }
    }
}
