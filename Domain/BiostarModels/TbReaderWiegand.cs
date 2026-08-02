using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReaderWiegand
{
    public int NReaderIdn { get; set; }

    public int NCustomIdsize { get; set; }

    public int NCardIdsize { get; set; }

    public int NReserved { get; set; }
}
