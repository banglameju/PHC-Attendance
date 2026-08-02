using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthChangePo
{
    public string Cpr { get; set; } = null!;

    public string? Newposition { get; set; }

    public string? Oldposition { get; set; }

    public string? EffectiveDate { get; set; }

    public int PositionidNew { get; set; }

    public int PositionidOld { get; set; }

    public DateTime InsertDate { get; set; }
}
