namespace Domain.AttendanceServiceRespDTO;

public class AccessLogRespDTO
{
    public string? RESPONSE_CODE { get; set; }
    public string? RESPONSE_DESCRPTION { get; set; }
    public string? Cpr { get; set; }
    public List<AccessLogDTO>? lstData { get; set; }
}
