using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTraceAdmin
{
    public int NLogIdn { get; set; }

    public int NDateTime { get; set; }

    public string SAdminId { get; set; } = null!;

    public string SAdminIp { get; set; } = null!;

    public string SAccessType { get; set; } = null!;

    public string SUserId { get; set; } = null!;

    public byte[]? SPassword { get; set; }

    public int NUserIdn { get; set; }

    public int NPrivilegeIdn { get; set; }
}
