using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbLiftDept
{
    public int NLiftDept { get; set; }

    public string SName { get; set; } = null!;

    public string SDepartment { get; set; } = null!;

    public int NDepth { get; set; }

    public int NParentIdn { get; set; }
}
