using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaShift
{
    public int NShiftIdn { get; set; }

    public string SName { get; set; } = null!;

    public int NStartTime { get; set; }

    public int NEndTime { get; set; }

    public short NCycleType { get; set; }

    public int NCyclePeriod { get; set; }

    public string SDescription { get; set; } = null!;
}
