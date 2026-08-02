using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReaderFinger
{
    public int NReaderIdn { get; set; }

    public int NSecurity { get; set; }

    public int NFastMode { get; set; }

    public int NImageQuality { get; set; }

    public short NViewImage { get; set; }

    public int NTimeout { get; set; }

    public int NFreeScanDelay { get; set; }

    public int NMatchTimeout { get; set; }

    public short NCheckDuplicate { get; set; }

    public short NEncryption { get; set; }
}
