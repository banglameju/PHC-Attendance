using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbAlarmSw
{
    public int NSwalarmIdn { get; set; }

    public string SName { get; set; } = null!;

    public string SFileName { get; set; } = null!;
}
