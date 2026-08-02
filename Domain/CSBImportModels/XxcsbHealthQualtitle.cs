using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthQualtitle
{
    public int Id { get; set; }

    public string QualTitle { get; set; } = null!;

    public DateTime InsertDate { get; set; }
}
