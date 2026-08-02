using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbLeaveItem
{
    public int NLeaveItemIdn { get; set; }

    public string SName { get; set; } = null!;

    public int NType { get; set; }

    public string? SDescription { get; set; }
}
