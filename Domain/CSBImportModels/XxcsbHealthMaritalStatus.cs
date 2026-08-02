using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthMaritalStatus
{
    public int Id { get; set; }

    public string? Meaning { get; set; }

    public string? LookupCode { get; set; }

    public DateTime InsertDate { get; set; }
}
