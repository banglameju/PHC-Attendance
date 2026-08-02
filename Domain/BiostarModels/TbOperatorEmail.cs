using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbOperatorEmail
{
    public int NEmailIdn { get; set; }

    public string SSmtpserver { get; set; } = null!;

    public string SUserId { get; set; } = null!;

    public string SPassword { get; set; } = null!;

    public string SSender { get; set; } = null!;

    public string SRecipient { get; set; } = null!;

    public string SSmtpport { get; set; } = null!;

    public int NSecurityType { get; set; }
}
