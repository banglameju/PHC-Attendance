using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaDevice
{
    public int NReaderIdn { get; set; }

    public int NType { get; set; }

    public string SName { get; set; } = null!;
}
