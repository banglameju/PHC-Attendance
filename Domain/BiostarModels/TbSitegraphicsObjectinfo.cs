using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbSitegraphicsObjectinfo
{
    public int NSiteGraphicsIdn { get; set; }

    public byte[]? BDoorsObject { get; set; }

    public int NDoorsObjectLen { get; set; }
}
