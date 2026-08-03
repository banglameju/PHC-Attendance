namespace Domain.AttendanceServiceRespDTO;

public class AccessLogRequestDTO
{
    public List<string> Cprs { get; set; } = [];
    public string FromDate { get; set; } = string.Empty;
    public string ToDate { get; set; } = string.Empty;
}
