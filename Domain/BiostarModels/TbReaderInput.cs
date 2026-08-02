using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReaderInput
{
    public int NReaderIoidn { get; set; }

    public int NReaderIdn { get; set; }

    public int NInputType { get; set; }

    public int NFunctionType { get; set; }

    public int NDurationTime { get; set; }

    public int NSwitchType { get; set; }

    public int NTimezone { get; set; }
}
