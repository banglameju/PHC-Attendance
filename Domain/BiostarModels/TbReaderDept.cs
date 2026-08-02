using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbReaderDept
{
    public int NDeptIdn { get; set; }

    public int NDeptType { get; set; }

    public string SName { get; set; } = null!;

    public int NDepth { get; set; }

    public int NParentIdn { get; set; }

    public int NParentReaderIdn { get; set; }

    public string SDescription { get; set; } = null!;
}
