using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbZoneAlarmzone
{
    public int NZoneIdn { get; set; }

    public int NType { get; set; }

    public int NLockDelayTime { get; set; }

    public int NUnlockDelayTime { get; set; }

    public int NStatus { get; set; }

    public short NSoundStatus { get; set; }

    public int NArmKey { get; set; }

    public int NArmCardId { get; set; }

    public int NArmCustomId { get; set; }

    public int NDisarmKey { get; set; }

    public int NDisarmCardId { get; set; }

    public int NDisarmCustomId { get; set; }
}
