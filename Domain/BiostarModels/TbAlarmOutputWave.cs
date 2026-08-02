using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbAlarmOutputWave
{
    public int NOutputWaveIdn { get; set; }

    public string SName { get; set; } = null!;

    public int NDelay { get; set; }

    public int NCount { get; set; }

    public int NHigh { get; set; }

    public int NLow { get; set; }
}
