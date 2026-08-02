using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class TMohLeave
{
    public string? Cpr { get; set; }

    public string LeaveType { get; set; } = null!;

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int? NoOfDays { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? InsertDate { get; set; }

    public int? AbsenceId { get; set; }
}
