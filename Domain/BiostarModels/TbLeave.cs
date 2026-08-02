using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbLeave
{
    public int NLeaveIdn { get; set; }

    public string SName { get; set; } = null!;

    public int NType { get; set; }

    public int NStartTime { get; set; }

    public int NEndTime { get; set; }

    public string SDescription { get; set; } = null!;
}
