namespace Domain.AttendanceServiceRespDTO;

public class HikProAccessLogRequestDTO
{
    public List<string> Cprs { get; set; } = [];
    public string FromDate { get; set; } = string.Empty;
    public string ToDate { get; set; } = string.Empty;
    public int? IsProcessed { get; set; }
}
