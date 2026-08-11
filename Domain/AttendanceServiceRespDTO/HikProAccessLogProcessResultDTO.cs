namespace Domain.AttendanceServiceRespDTO;

public class HikProAccessLogProcessResultDTO
{
    public int RowsInserted { get; set; }
    public int RowsMarkedProcessed { get; set; }
    public int FromEventLogId { get; set; }
    public int ToEventLogId { get; set; }
    public string Message { get; set; } = string.Empty;
}
