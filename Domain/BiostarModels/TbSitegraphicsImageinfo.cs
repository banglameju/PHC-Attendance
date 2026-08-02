using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbSitegraphicsImageinfo
{
    public int NSiteGraphicsIdn { get; set; }

    public byte[]? BBgimage { get; set; }

    public int NBgimageLen { get; set; }
}
