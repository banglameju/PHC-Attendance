using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaTimecategory
{
    public int NTimeCategoryIdn { get; set; }

    public string SName { get; set; } = null!;

    public float NTimeRate { get; set; }

    public int NRoundingUnit { get; set; }

    public short NRoundingType { get; set; }

    public int NDisplayColor { get; set; }

    public string SDescription { get; set; } = null!;
}
