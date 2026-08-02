using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthQualtype
{
    public int Id { get; set; }

    public string QualType { get; set; } = null!;

    public DateTime InsertDate { get; set; }
}
