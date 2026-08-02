using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthEmployeestatus
{
    public int Id { get; set; }

    public string? EngStatus { get; set; }

    public string? ArStatus { get; set; }

    public DateTime InsertDate { get; set; }
}
