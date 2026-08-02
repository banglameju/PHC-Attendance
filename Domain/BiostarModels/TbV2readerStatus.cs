using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbV2readerStatus
{
    public int NReaderIdn { get; set; }

    public int NStatus { get; set; }

    public int NReserved { get; set; }
}
