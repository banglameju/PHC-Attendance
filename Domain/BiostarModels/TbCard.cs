using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbCard
{
    public int NCardIdn { get; set; }

    public short NIndex { get; set; }

    public short NType { get; set; }

    public string SCardNo { get; set; } = null!;

    public int NUserIdn { get; set; }

    public int NSecurityLevel { get; set; }

    public int NAccessgroup { get; set; }
}
