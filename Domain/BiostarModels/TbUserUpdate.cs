using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUserUpdate
{
    public int NUserUpdateIdn { get; set; }

    public int NUserIdn { get; set; }

    public int NDeviceId { get; set; }

    public int NDeviceUpdate { get; set; }
}
