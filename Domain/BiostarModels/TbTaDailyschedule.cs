using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaDailyschedule
{
    public int NDailyScheduleIdn { get; set; }

    public string SName { get; set; } = null!;

    public int NDateStartTime { get; set; }

    public short NIsFirstAndLastAuth { get; set; }

    public string SDescription { get; set; } = null!;
}
