using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTimecode
{
    public int NTimecode { get; set; }

    public int NStartTime1 { get; set; }

    public int NEndTime1 { get; set; }

    public int NStartTime2 { get; set; }

    public int NEndTime2 { get; set; }

    public int NStartTime3 { get; set; }

    public int NEndTime3 { get; set; }

    public int NStartTime4 { get; set; }

    public int NEndTime4 { get; set; }

    public int NStartTime5 { get; set; }

    public int NEndTime5 { get; set; }

    public string SDescription { get; set; } = null!;
}
