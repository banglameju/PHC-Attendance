using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaShiftOverride
{
    public int NShiftOverrideIdn { get; set; }

    public int NUserIdn { get; set; }

    public int NShiftIdn { get; set; }

    public int NStartTime { get; set; }

    public int NEndTime { get; set; }

    public int NType { get; set; }
}
