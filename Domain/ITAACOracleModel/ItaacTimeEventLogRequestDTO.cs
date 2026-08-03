namespace Domain.ITAACOracleModel;

public class ItaacTimeEventLogRequestDTO
{
    public List<ItaacTimeEventLogLookupDTO> Logs { get; set; } = [];
}

public class ItaacTimeEventLogLookupDTO
{
    public string Cpr { get; set; } = string.Empty;
    public string LogDate { get; set; } = string.Empty;
    public string LogTime { get; set; } = string.Empty;
}
