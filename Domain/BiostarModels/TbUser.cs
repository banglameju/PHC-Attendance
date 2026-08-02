using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUser
{
    public int NUserIdn { get; set; }

    public string SUserName { get; set; } = null!;

    public int NDepartmentIdn { get; set; }

    public string STelNumber { get; set; } = null!;

    public string SEmail { get; set; } = null!;

    public string SUserId { get; set; } = null!;

    public string SPassword { get; set; } = null!;

    public int NStartDate { get; set; }

    public int NEndDate { get; set; }

    public int NAdminLevel { get; set; }

    public int NAuthMode { get; set; }

    public int NAuthLimitCount { get; set; }

    public int NTimedApb { get; set; }

    public int NEncryption { get; set; }

    public byte[] BPassword2 { get; set; } = null!;
}
