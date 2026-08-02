using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthOccupation
{
    public int Id { get; set; }

    public string? Job { get; set; }

    public string? Occseries { get; set; }

    public DateTime InsertDate { get; set; }
}
