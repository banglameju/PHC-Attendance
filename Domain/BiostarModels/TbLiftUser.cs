using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbLiftUser
{
    public int NLiftUserIdn { get; set; }

    public int NLiftFloorIdn { get; set; }

    public string SUserId { get; set; } = null!;

    public string SUserName { get; set; } = null!;

    public string SDepartment { get; set; } = null!;

    public int NEncryption { get; set; }
}
