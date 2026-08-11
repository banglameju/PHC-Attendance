namespace Domain.AttendanceServiceRespDTO;

public class HikProAccessLogRespDTO
{
    public string? RESPONSE_CODE { get; set; }
    public string? RESPONSE_DESCRPTION { get; set; }
    public List<string>? Cprs { get; set; }
    public int? IsProcessed { get; set; }
    public List<HikProAccessLogDTO>? lstData { get; set; }
}
