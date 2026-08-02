using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaResult
{
    public int NDateTime { get; set; }

    public int NUserIdn { get; set; }

    public int NShiftIdn { get; set; }

    public int NDailyScheduleIdn { get; set; }

    public int NStartTime { get; set; }

    public int NEndTime { get; set; }

    public string SStartEvent { get; set; } = null!;

    public string SEndEvent { get; set; } = null!;

    public int NTaresult { get; set; }

    public int NWorkTime { get; set; }

    public int NIsModify { get; set; }

    public int NLateInTime { get; set; }

    public int NEarlyOutTime { get; set; }
}
