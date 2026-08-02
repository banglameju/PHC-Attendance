using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class AsException
{
    public int? AeErrNum { get; set; }

    public string? AeErrMsg { get; set; }

    public DateOnly? AsCreDate { get; set; }

    public string? AsCreBy { get; set; }
}
