namespace Domain.HikProModels;

public partial class HikProAccessLog
{
    public int LogId { get; set; }

    public string? EmpId { get; set; }

    public DateTime AccessDateTime { get; set; }

    public DateOnly? AccessDate { get; set; }

    public TimeOnly? AccessTime { get; set; }

    public string? DevName { get; set; }

    public string? DevSn { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpLastName { get; set; }

    public DateTime? RecordCreatedDate { get; set; }

    public int? IsProcessed { get; set; }
}
