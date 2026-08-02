using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReaderDisplay
{
    public int NReaderIdn { get; set; }

    public int NLanguage { get; set; }

    public int NBackground { get; set; }

    public int NSubInfo { get; set; }

    public int NMenuTimeout { get; set; }

    public int NMessageTimeout { get; set; }

    public short NPrivateAuth { get; set; }

    public int NVolume { get; set; }

    public short NDateType { get; set; }

    public short NTimeSync { get; set; }
}
