using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbAccessgroup
{
    public int NAccessIdn { get; set; }

    public string SName { get; set; } = null!;

    public string SDescription { get; set; } = null!;
}
