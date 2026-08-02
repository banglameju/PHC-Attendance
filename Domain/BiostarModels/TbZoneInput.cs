using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbZoneInput
{
    public int NZoneIdn { get; set; }

    public int NReaderIoidn { get; set; }

    public string SName { get; set; } = null!;

    public int NInputFlag { get; set; }
}
