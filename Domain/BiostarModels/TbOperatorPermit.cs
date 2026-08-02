using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbOperatorPermit
{
    public int NPermitIdn { get; set; }

    public int NPrivilegeIdn { get; set; }

    public int NModuleIdn { get; set; }

    public int NAgentType { get; set; }

    public int NAgentIdn { get; set; }

    public int NPermit { get; set; }
}
