using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbEvent
{
    public int NEventIdn { get; set; }

    public string SName { get; set; } = null!;

    public short NPriority { get; set; }

    public short NAck { get; set; }

    public int NSwalarmIdn { get; set; }

    public int NAlarmEmailIdn { get; set; }

    public string SDescription { get; set; } = null!;
}
