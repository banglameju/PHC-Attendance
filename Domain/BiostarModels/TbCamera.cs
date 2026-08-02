using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbCamera
{
    public int NCameraIdn { get; set; }

    public string SName { get; set; } = null!;

    public int NDepartmentIdn { get; set; }

    public string SIp { get; set; } = null!;

    public int NPort { get; set; }

    public string SUserId { get; set; } = null!;

    public string SPassword { get; set; } = null!;

    public int NVendor { get; set; }

    public string SModel { get; set; } = null!;

    public int NType { get; set; }

    public int NEncryption { get; set; }
}
