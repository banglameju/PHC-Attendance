using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaDeviceEventKey
{
    public int NDeviceEventKeyIdn { get; set; }

    public int NReaderIdn { get; set; }

    public int NKeyIdn { get; set; }

    public int NKeyEvent { get; set; }

    public short NNoLate { get; set; }

    public short NIsOnlyResult { get; set; }

    public short NIsWorkTime { get; set; }

    public string SEventName { get; set; } = null!;
}
