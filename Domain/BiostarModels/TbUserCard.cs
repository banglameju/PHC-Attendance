using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUserCard
{
    public int NCardIdn { get; set; }

    public int NUserIdn { get; set; }

    public short NType { get; set; }

    public string SCardNo { get; set; } = null!;

    public string SCustomNo { get; set; } = null!;

    public int NSecurityLevel { get; set; }

    public int NDateTime { get; set; }

    public int NExpiryDateTime { get; set; }

    public short NBypass { get; set; }

    public int NStatus { get; set; }

    public short NLatest { get; set; }

    public int NEncryption { get; set; }

    public int NV2cardType { get; set; }
}
