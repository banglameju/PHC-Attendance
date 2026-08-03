namespace Domain.AttendanceServiceRespDTO;

/// <summary>
/// Represents a row from the HikCentral public.access_logs table.
/// </summary>
public class AccessLogDTO
{
    public string? EmpId { get; set; }
    public DateTime AccessDateTime { get; set; }
    public DateOnly? AccessDate { get; set; }
    public TimeOnly? AccessTime { get; set; }
    public string? DevName { get; set; }
    public string? DevSn { get; set; }
    public string? EmpFirstName { get; set; }
    public string? EmpLastName { get; set; }
    public bool ItaacUpdated { get; set; }
}
