using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class ViewTbTaResultModified
{
    public int NUserIdn { get; set; }

    public string? MStartTime { get; set; }

    public string? MEndTime { get; set; }

    public int NTaresult { get; set; }

    public string? MWorkTime { get; set; }

    public int NIsModify { get; set; }

    public string? MLateInTime { get; set; }

    public string? MEarlyOutTime { get; set; }

    public string SUserName { get; set; } = null!;

    public string SUserId { get; set; } = null!;

    public DateTime? MDateTime { get; set; }

    public int NShiftIdn { get; set; }

    public string SDepartment { get; set; } = null!;

    public string? ShiftHr { get; set; }

    public string? HoursPerDay { get; set; }

    public int Expr1 { get; set; }

    public string? MHoursPerDay { get; set; }
}
