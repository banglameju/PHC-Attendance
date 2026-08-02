using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbDoorDept
{
    public int NDoorDept { get; set; }

    public string SName { get; set; } = null!;

    public string SDepartment { get; set; } = null!;

    public short NDepth { get; set; }

    public int NParentIdn { get; set; }
}
