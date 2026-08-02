using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbAlarmDest
{
    public int NAlarmDestIdn { get; set; }

    public int NType { get; set; }

    public int NAgent { get; set; }

    public int NEventIdn { get; set; }

    public int NAlarmIdn { get; set; }
}
