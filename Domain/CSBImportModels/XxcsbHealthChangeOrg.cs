using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthChangeOrg
{
    public string Cpr { get; set; } = null!;

    public int Oldcode { get; set; }

    public string Oldorganization { get; set; } = null!;

    public int Newcode { get; set; }

    public string Neworganization { get; set; } = null!;

    public string? EffectiveDate { get; set; }

    public DateTime InsertDate { get; set; }
}
