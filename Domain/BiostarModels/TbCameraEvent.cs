using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbCameraEvent
{
    public int NCameraEventIdn { get; set; }

    public int NCameraIdn { get; set; }

    public int NReaderIdn { get; set; }

    public string SReaderName { get; set; } = null!;

    public int NReaderType { get; set; }

    public byte[] BEventIdns { get; set; } = null!;
}
