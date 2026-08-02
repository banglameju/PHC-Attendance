using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbEventLog
{
    public int NEventLogIdn { get; set; }

    public int NDateTime { get; set; }

    public int NReaderIdn { get; set; }

    public int NEventIdn { get; set; }

    public int NUserId { get; set; }

    public short NIsLog { get; set; }

    public short NTnaevent { get; set; }

    public short NIsUseTa { get; set; }

    public short NType { get; set; }
}
