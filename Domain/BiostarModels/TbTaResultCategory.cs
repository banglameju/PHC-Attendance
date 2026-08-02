using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaResultCategory
{
    public int NDateTime { get; set; }

    public int NUserIdn { get; set; }

    public int NTimeCategoryIdn { get; set; }

    public int NWorkTime { get; set; }

    public int NTaresult { get; set; }

    public int NIsModify { get; set; }

    public int NLateInTime { get; set; }

    public int NEarlyOutTime { get; set; }
}
