using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbDoorReader
{
    public int NDoorIdn { get; set; }

    public int NReaderIdn { get; set; }

    public short NInout { get; set; }

    public int NOpenRelay { get; set; }

    public int NOpenTime { get; set; }

    public int NCloseTime { get; set; }

    public int NOpenEvent { get; set; }

    public int NRte { get; set; }

    public int NRtetype { get; set; }

    public int NSensor { get; set; }

    public int NSensorType { get; set; }

    public int NCloseEvent { get; set; }
}
