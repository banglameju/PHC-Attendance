using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTraceUser
{
    public int NLogIdn { get; set; }

    public int NDateTime { get; set; }

    public string SAdminId { get; set; } = null!;

    public string SAdminIp { get; set; } = null!;

    public string SAccessType { get; set; } = null!;

    public byte[] SUserName { get; set; } = null!;

    public string? SDepartment { get; set; }

    public byte[]? STelNumber { get; set; }

    public byte[]? SEmail { get; set; }

    public string SUserId { get; set; } = null!;

    public byte[]? SPassword { get; set; }

    public int NStartDate { get; set; }

    public int NEndDate { get; set; }

    public int NAdminLevel { get; set; }
}
