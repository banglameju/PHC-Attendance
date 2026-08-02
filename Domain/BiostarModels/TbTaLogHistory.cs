using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaLogHistory
{
    public int NHistroryIdn { get; set; }

    public int NUpdateTime { get; set; }

    public string SUserId { get; set; } = null!;

    public string SIp { get; set; } = null!;

    public int NDateTime { get; set; }

    public int NUserIdn { get; set; }

    public int NReaderIdn { get; set; }

    public short NTnaevent { get; set; }

    public int NFirstInTime { get; set; }

    public int NLastOutTime { get; set; }

    public string SFirstInEvent { get; set; } = null!;

    public string SLastOutEvent { get; set; } = null!;

    public int NTaresult { get; set; }

    public int NWorkTime { get; set; }

    public int NTimeCategoryIdn { get; set; }

    public short NFlag { get; set; }
}
