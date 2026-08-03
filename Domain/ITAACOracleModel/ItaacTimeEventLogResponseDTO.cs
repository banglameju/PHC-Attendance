namespace Domain.ITAACOracleModel;

public class ItaacTimeEventLogResponseDTO
{
    public string? RESPONSE_CODE { get; set; }
    public string? RESPONSE_DESCRPTION { get; set; }
    public List<ItaacTimeEventLogResultDTO>? lstData { get; set; }
}

public class ItaacTimeEventLogResultDTO
{
    public string Cpr { get; set; } = string.Empty;
    public string LogDate { get; set; } = string.Empty;
    public string LogTime { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
}
