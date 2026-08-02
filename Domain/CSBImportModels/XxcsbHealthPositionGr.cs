using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthPositionGr
{
    public int Id { get; set; }

    public string? Position { get; set; }

    public string? Grade { get; set; }

    public DateTime InsertDate { get; set; }
}
