using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReaderHw
{
    public int NReaderIdn { get; set; }

    public string SProductName { get; set; } = null!;

    public string SBoardVersion { get; set; } = null!;

    public string SFirmwareVersion { get; set; } = null!;

    public string SBlackfinVersion { get; set; } = null!;

    public string SKernelVersion { get; set; } = null!;

    public string SPrivateKey { get; set; } = null!;
}
