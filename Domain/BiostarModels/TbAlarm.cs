using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbAlarm
{
    public int NAlarmIdn { get; set; }

    public int NSwalarmIdn { get; set; }

    public int NOutputDeviceSoundIdn { get; set; }

    public int NOutputReaderIdn { get; set; }

    public int NOutputPort { get; set; }

    public int NOutputWaveIdn { get; set; }

    public int NAlarmEmailIdn { get; set; }

    public string SDescription { get; set; } = null!;
}
