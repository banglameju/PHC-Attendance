using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbDbExport
{
    public long Id { get; set; }

    public string TableName { get; set; } = null!;

    public int PrimaryKey { get; set; }
}
