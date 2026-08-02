using System;
using System.Collections.Generic;

namespace Domain.HikProModels;

public partial class AccessLog
{
    public string EmpId { get; set; } = null!;

    public DateTime AccessDateTime { get; set; }

    public DateOnly? AccessDate { get; set; }

    public TimeOnly? AccessTime { get; set; }

    public string? DevName { get; set; }

    public string? DevSn { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpLastName { get; set; }
}
