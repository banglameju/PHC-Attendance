using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbLiftFloor
{
    public int NLiftFloorIdn { get; set; }

    public int NLiftIdn { get; set; }

    public int NIndex { get; set; }

    public int NOutput { get; set; }

    public int NFloor { get; set; }

    public string SName { get; set; } = null!;

    public string SDescription { get; set; } = null!;
}
