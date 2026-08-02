using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbOperator
{
    public string SUserId { get; set; } = null!;

    public string SPassword { get; set; } = null!;

    public int NUserIdn { get; set; }

    public int NPrivilegeIdn { get; set; }
}
