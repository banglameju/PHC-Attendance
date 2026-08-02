using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthNationality
{
    public string? Meaning { get; set; }

    public string LookupCode { get; set; } = null!;

    public DateTime InsertDate { get; set; }
}
