using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReaderNetwork
{
    public int NReaderIdn { get; set; }

    public short NType { get; set; }

    public int NPort { get; set; }

    public int NMaxConnection { get; set; }

    public short NSsl { get; set; }

    public short NDhcp { get; set; }

    public string SIpaddress { get; set; } = null!;

    public string SGateway { get; set; } = null!;

    public string SSubnetMask { get; set; } = null!;

    public string SServerIp { get; set; } = null!;

    public short NTimeSync { get; set; }

    public string SComPort { get; set; } = null!;

    public int NRs485mode { get; set; }

    public int NRs485baudrate { get; set; }

    public int NRs232baudrate { get; set; }

    public int NSecureIo { get; set; }

    public short NIsHistory { get; set; }

    public int NUpdateDate { get; set; }
}
