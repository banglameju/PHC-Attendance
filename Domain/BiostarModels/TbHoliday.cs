using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbHoliday
{
    public int NHoliday { get; set; }

    public string SName { get; set; } = null!;

    public string SDescription { get; set; } = null!;
}
