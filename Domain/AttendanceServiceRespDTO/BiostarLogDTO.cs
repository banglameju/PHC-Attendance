namespace Domain.AttendanceServiceRespDTO;

public class BiostarLogDTO
{
    public string? Cpr { get; set; }
    public DateTime? AttendanceDate { get; set; }
    public string? AttendanceTime { get; set; }
    public string? DeviceId { get; set; }
    public string? DeviceName { get; set; }
    public bool ItaacUpdated { get; set; }
}
