using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class CsbAllowancesMaster
{
    public int ElementTypeId { get; set; }

    public string? AllowanceEn { get; set; }

    public string? AllowanceAr { get; set; }

    public DateTime InsertDate { get; set; }
}
