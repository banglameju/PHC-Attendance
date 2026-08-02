using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbOperatorPrivilege
{
    public int NPrivilegeIdn { get; set; }

    public int NType { get; set; }

    public string SName { get; set; } = null!;

    public string SDescription { get; set; } = null!;
}
