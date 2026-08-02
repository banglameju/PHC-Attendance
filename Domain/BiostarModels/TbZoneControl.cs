using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbZoneControl
{
    public int NZoneIdn { get; set; }

    public int NUserIdn { get; set; }

    public int NNumOfEntrance { get; set; }

    public short NFlag { get; set; }

    public int NTime { get; set; }
}
