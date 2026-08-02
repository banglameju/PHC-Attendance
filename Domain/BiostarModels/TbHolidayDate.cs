using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class TbHolidayDate
{
    public int NHoliday { get; set; }

    public int NDate { get; set; }

    public short NYearRepeat { get; set; }

    public int NDaysLong { get; set; }
}
