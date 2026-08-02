using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class TMohLeaveCancel
{
    public string? Cpr { get; set; }

    public string LeaveType { get; set; } = null!;

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public int? NoOfDays { get; set; }

    public DateOnly? EntryDate { get; set; }

    public DateOnly? InsertDate { get; set; }

    public int? AbsenceId { get; set; }
}
