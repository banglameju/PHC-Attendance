using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthBranch
{
    public string Bankcode { get; set; } = null!;

    public string? Bankname { get; set; }

    public string Branchcode { get; set; } = null!;

    public string? Branch { get; set; }

    public DateTime InsertDate { get; set; }
}
