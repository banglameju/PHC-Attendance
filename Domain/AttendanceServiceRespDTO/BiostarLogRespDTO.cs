namespace Domain.AttendanceServiceRespDTO;

public class BiostarLogRespDTO
{
    public string? RESPONSE_CODE { get; set; }
    public string? RESPONSE_DESCRPTION { get; set; }
    public List<string>? Cprs { get; set; }
    public List<BiostarLogDTO>? lstData { get; set; }
}
