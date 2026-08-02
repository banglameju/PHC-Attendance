using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUserFace
{
    public int NUserIdn { get; set; }

    public short NIndex { get; set; }

    public byte[] BTemplate { get; set; } = null!;

    public int NTemplatecs { get; set; }

    public int NImageLen { get; set; }

    public byte[]? BImage { get; set; }

    public short NEncryption { get; set; }

    public int NSecurityLevel { get; set; }

    public int NAuthLimitCount { get; set; }
}
