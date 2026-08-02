using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbZoneAlarm
{
    public int NZoneIdn { get; set; }

    public int NInputEvent { get; set; }

    public int NOutputEvent { get; set; }
}
