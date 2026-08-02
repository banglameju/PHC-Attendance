using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbZoneDoor
{
    public int NZoneDoorIdn { get; set; }

    public int NZoneIdn { get; set; }

    public int NDoorIdn { get; set; }

    public int NDoorDept { get; set; }

    public int NTimezone { get; set; }
}
