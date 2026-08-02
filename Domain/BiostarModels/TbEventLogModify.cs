using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbEventLogModify
{
    public int NEventLogIdn { get; set; }

    public int NDateTime { get; set; }

    public int NReaderIdn { get; set; }

    public int NEventIdn { get; set; }

    public int NUserId { get; set; }

    public short NTnaevent { get; set; }

    public short NFlag { get; set; }
}
