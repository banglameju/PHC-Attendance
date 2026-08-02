using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUserFaceTemplate
{
    public int NUserIdn { get; set; }

    public short NIndex { get; set; }

    public byte[]? BTemplate { get; set; }

    public int NTemplateLen { get; set; }

    public int NTemplatecs { get; set; }

    public int NEncryption { get; set; }

    public int NUpdated { get; set; }

    public int NUpdateIndex { get; set; }

    public int NType { get; set; }
}
