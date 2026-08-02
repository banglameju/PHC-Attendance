using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class CsbLeaveMaster
{
    public int LeaveCode { get; set; }

    public string? LeaveDescEng { get; set; }

    public string? LeaveDescAr { get; set; }

    public DateTime? InsertDate { get; set; }
}
