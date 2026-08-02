using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbEventFace
{
    public int NEventFaceIdn { get; set; }

    public short NType { get; set; }

    public byte[]? BFaceImage { get; set; }

    public int NFaceImageLen { get; set; }

    public int NDateTime { get; set; }

    public int NReaderIdn { get; set; }

    public int NEventIdn { get; set; }

    public int NUserId { get; set; }
}
