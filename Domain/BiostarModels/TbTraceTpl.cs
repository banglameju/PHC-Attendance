using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTraceTpl
{
    public int NTraceTplIdn { get; set; }

    public int NDateTime { get; set; }

    public int NType { get; set; }

    public byte[]? BData { get; set; }

    public int NDataLen { get; set; }
}
