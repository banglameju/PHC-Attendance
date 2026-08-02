using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUserDevice
{
    public int NUserDeviceIdn { get; set; }

    public int NUserIdn { get; set; }

    public int NDeviceId { get; set; }

    public short NIsUpdated { get; set; }

    public short NIsDelete { get; set; }
}
