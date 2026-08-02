using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbZone
{
    public int NZoneIdn { get; set; }

    public string SName { get; set; } = null!;

    public short NType { get; set; }

    public int NAttribute { get; set; }

    public int NTimezone { get; set; }

    public string SDescription { get; set; } = null!;
}
