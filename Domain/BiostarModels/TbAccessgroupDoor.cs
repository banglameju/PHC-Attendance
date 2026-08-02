using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbAccessgroupDoor
{
    public int NAccessDoorIdn { get; set; }

    public int NAccessIdn { get; set; }

    public int NType { get; set; }

    public int NAgentIdn { get; set; }

    public int NTimezone { get; set; }
}
