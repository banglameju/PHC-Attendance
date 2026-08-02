using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthBank
{
    public string Bankcode { get; set; } = null!;

    public string? Bankname { get; set; }

    public DateTime InsertDate { get; set; }
}
