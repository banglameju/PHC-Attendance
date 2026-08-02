using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthStandbyot
{
    public string? Cpr { get; set; }

    public string? Category { get; set; }

    public string? Hours { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateTime InsertDate { get; set; }
}
