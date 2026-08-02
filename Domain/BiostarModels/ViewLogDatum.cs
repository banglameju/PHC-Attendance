using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class ViewLogDatum
{
    public string? SLogTime { get; set; }

    public string SName { get; set; } = null!;

    public int NEventIdn { get; set; }

    public int NUserId { get; set; }
}
