using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class CsbHealthTerminatedEmp
{
    public int Id { get; set; }

    public string? Cpr { get; set; }

    public DateTime? FinalProcessDate { get; set; }

    public string Remark { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public DateTime InsertDate { get; set; }
}
