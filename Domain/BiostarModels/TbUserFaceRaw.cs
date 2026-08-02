using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUserFaceRaw
{
    public int NUserIdn { get; set; }

    public short NIndex { get; set; }

    public byte[]? BTemplate { get; set; }

    public int NTemplateLen { get; set; }

    public int NType { get; set; }
}
