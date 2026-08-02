using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthPosition
{
    public int PositionId { get; set; }

    public string? Description { get; set; }

    public string? Name { get; set; }

    public DateTime InsertDate { get; set; }
}
