using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReaderWlan
{
    public int NReaderIdn { get; set; }

    public short NPresetIndex { get; set; }

    public string SName { get; set; } = null!;

    public int NOperationMode { get; set; }

    public string SEssid { get; set; } = null!;

    public int NAuthType { get; set; }

    public int NEncryption { get; set; }

    public int NKeyType { get; set; }

    public string SKey { get; set; } = null!;
}
