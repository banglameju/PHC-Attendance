using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbAccessgroupUser
{
    public int NAccessUserIdn { get; set; }

    public int NAccessIdn { get; set; }

    public int NType { get; set; }

    public int NAgentIdn { get; set; }
}
