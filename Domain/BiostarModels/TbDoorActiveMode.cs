using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbDoorActiveMode
{
    public int NDoorIdn { get; set; }

    public int NMode { get; set; }

    public int NType { get; set; }

    public int NMethod { get; set; }

    public int NTimezone { get; set; }
}
