using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReaderNetworkHistory
{
    public int NReaderIdn { get; set; }

    public int NUpdateDate { get; set; }

    public string SAdminId { get; set; } = null!;

    public string SIp { get; set; } = null!;
}
