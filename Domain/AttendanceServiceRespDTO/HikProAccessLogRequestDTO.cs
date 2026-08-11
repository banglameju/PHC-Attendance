namespace Domain.AttendanceServiceRespDTO;

public class HikProAccessLogRequestDTO
{
    public List<string>? Cprs { get; set; }
    public string? FromDate { get; set; }
    public string? ToDate { get; set; }
    public int? IsProcessed { get; set; }
    public int? RecordCount { get; set; }
}
