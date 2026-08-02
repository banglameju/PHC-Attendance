using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTaTimeslot
{
    public int NTimeSlotIdn { get; set; }

    public int NDailyScheduleIdn { get; set; }

    public int NStartTime { get; set; }

    public int NEndTime { get; set; }

    public int NTimeCategoryIdn { get; set; }

    public int NStartGrace { get; set; }

    public int NEndGrace { get; set; }

    public int NInRounding { get; set; }

    public int NOutRounding { get; set; }

    public int NMinimumDuration { get; set; }

    public short NMustCheckIn { get; set; }

    public short NMustCheckOut { get; set; }

    public short NAutoCheckIn { get; set; }

    public short NAutoCheckOut { get; set; }

    public short NAffectingResult { get; set; }
}
