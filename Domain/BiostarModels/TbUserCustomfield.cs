using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbUserCustomfield
{
    public int NFieldIdn { get; set; }

    public string SFieldName { get; set; } = null!;

    public int NFieldType { get; set; }

    public int NDataType { get; set; }

    public short NEssential { get; set; }

    public int NValueIdn { get; set; }

    public string SData { get; set; } = null!;
}
