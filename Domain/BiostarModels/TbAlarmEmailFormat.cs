using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbAlarmEmailFormat
{
    public int NEmailFormatIdn { get; set; }

    public string SEmailTitle { get; set; } = null!;

    public string SEmailMessage { get; set; } = null!;
}
