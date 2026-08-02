using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthJobPo
{
    public int JobId { get; set; }

    public string? Job { get; set; }

    public int PositionId { get; set; }

    public string? Postion { get; set; }

    public int OrganizationId { get; set; }

    public string? Occseries { get; set; }

    public DateTime InsertDate { get; set; }
}
