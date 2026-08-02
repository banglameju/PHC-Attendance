using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaHolidayRule
{
    public int NHolidayRuleIdn { get; set; }

    public string SName { get; set; } = null!;

    public int NType { get; set; }

    public int NDailyScheduleIdn { get; set; }

    public string SDescription { get; set; } = null!;
}
