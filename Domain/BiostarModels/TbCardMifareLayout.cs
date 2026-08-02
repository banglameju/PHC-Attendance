using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbCardMifareLayout
{
    public int NMifareIdn { get; set; }

    public int NCisidn { get; set; }

    public int NNumOfTemplate { get; set; }

    public int NTemplateSize { get; set; }

    public int NTemplateBlock1 { get; set; }

    public int NTemplateBlock2 { get; set; }

    public int NTemplateBlock3 { get; set; }

    public int NTemplateBlock4 { get; set; }
}
