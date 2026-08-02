using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUserTemplate
{
    public int NUserIdn { get; set; }

    public short NIndex { get; set; }

    public byte[] BTemplate { get; set; } = null!;

    public int NTemplatecs { get; set; }

    public short NDuress { get; set; }

    public short NEncryption { get; set; }

    public int NSecurityLevel { get; set; }

    public int NFingerIndex { get; set; }

    public short NTemplateIndex { get; set; }

    public int NEnrollQuality { get; set; }
}
