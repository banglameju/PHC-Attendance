using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReader
{
    public int NReaderIdn { get; set; }

    public string SName { get; set; } = null!;

    public int NType { get; set; }

    public int NDeptIdn { get; set; }

    public string SIp { get; set; } = null!;

    public string SMacAddress { get; set; } = null!;

    public int NConnType { get; set; }

    public string SDescription { get; set; } = null!;

    public int NTimezone { get; set; }
}
