using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CSBOracleModel
{
    public class Csb_Health_Leave_Trans
    {
        public string CPR { get; set; }
        public string LEAVE_TYPE { get; set; }
        public DateTime FROM_DATE { get; set; }
        public DateTime TO_DATE { get; set; }
        public decimal NO_OF_DAYS { get; set; }
        public DateTime ENTRY_DATE { get; set; }
        public DateTime INSERT_DATE { get; set; }
        public int ABSENCE_ID { get; set; }
    }
}
