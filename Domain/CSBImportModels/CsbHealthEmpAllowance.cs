using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class CsbHealthEmpAllowance
{
    public int Id { get; set; }

    public string Cpr { get; set; } = null!;

    public int ElementTypeId { get; set; }

    public DateTime InsertDate { get; set; }
}
