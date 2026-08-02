using Domain.CSBImportModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CSBImportRespDTO
{
    public class CSBHealthEmpDataRespDTO
    {
        public string RESPONSE_CODE { get; set; }
        public string RESPONSE_DESCRPTION { get; set; }
        public List<XxcsbHealthDatum>? lstData { get; set; }
    }
}
