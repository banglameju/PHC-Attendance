using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTimezone
{
    public int NTimezone { get; set; }

    public string SName { get; set; } = null!;

    public string SDescription { get; set; } = null!;
}
