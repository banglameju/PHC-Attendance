using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUserFaceStillcut
{
    public int NUserIdn { get; set; }

    public int NType { get; set; }

    public byte[]? BImage { get; set; }

    public int NImageLen { get; set; }
}
