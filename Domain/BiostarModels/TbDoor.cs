using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbDoor
{
    public int NDoorIdn { get; set; }

    public string SName { get; set; } = null!;

    public int NDoorDept { get; set; }

    public int NOpenTime { get; set; }

    public int NHoldTime { get; set; }

    public int NIoreaderIdn { get; set; }

    public int NOpenRelayId { get; set; }

    public string SDescription { get; set; } = null!;

    public int NUnlockTrigger { get; set; }

    public int NInputDelay { get; set; }

    public int NZoneIdn { get; set; }
}
