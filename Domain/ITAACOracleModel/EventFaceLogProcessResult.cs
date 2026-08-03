namespace Domain.ITAACOracleModel;

public class EventFaceLogProcessResult
{
    public int RowsInserted { get; set; }
    public decimal FromEventLogId { get; set; }
    public decimal ToEventLogId { get; set; }
    public string Message { get; set; } = string.Empty;
}
