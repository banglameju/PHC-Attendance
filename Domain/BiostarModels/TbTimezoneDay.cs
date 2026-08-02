using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbTimezoneDay
{
    public int NTimezone { get; set; }

    public int NDay { get; set; }

    public int NHolidayIdn { get; set; }

    public int NTimecode { get; set; }
}
