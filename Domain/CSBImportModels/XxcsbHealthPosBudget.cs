using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthPosBudget
{
    public int Id { get; set; }

    public string? Ministry { get; set; }

    public string? Division { get; set; }

    public string? Directorate { get; set; }

    public string? Section { get; set; }

    public string? GroupName { get; set; }

    public string? Unit { get; set; }

    public string Organization { get; set; } = null!;

    public string? Type { get; set; }

    public string LocationCode { get; set; } = null!;

    public string PostionStatus { get; set; } = null!;

    public string? PositionTitle { get; set; }

    public string? ApprovedGrade { get; set; }

    public int? ApprovedBudget { get; set; }

    public int? ActualsEmployees { get; set; }

    public int? ActualsApp { get; set; }

    public int? Variance { get; set; }

    public DateTime InsertDate { get; set; }
}
