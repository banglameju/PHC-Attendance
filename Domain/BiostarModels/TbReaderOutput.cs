using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReaderOutput
{
    public int NReaderIoidn { get; set; }

    public int NReaderIdn { get; set; }

    public int NEvent { get; set; }

    public int NDeviceId { get; set; }

    public short NRelayPort { get; set; }

    public short NRelayOn { get; set; }

    public int NOutputWaveIdn { get; set; }

    public int NPriority { get; set; }
}
