using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbLift
{
    public int NLiftIdn { get; set; }

    public string SName { get; set; } = null!;

    public int NLiftDept { get; set; }

    public int NIoreaderIdn { get; set; }

    public int NBaseFloor { get; set; }

    public int NMaxFloor { get; set; }

    public string SDescription { get; set; } = null!;
}
