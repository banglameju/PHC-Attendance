using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaShiftHour
{
    public int NShiftIdn { get; set; }

    public string? SName { get; set; }

    public string? HoursPerDay { get; set; }
}
