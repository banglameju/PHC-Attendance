using Domain.ITAACOracleModel;

namespace Domain.AttendanceServiceRespDTO;

public class CostCenterEmployeeRespDTO
{
    public string? RESPONSE_CODE { get; set; }
    public string? RESPONSE_DESCRPTION { get; set; }
    public string? CostCenter { get; set; }
    public string? Cpr { get; set; }
    public List<AsEmployeeMst>? lstData { get; set; }
}
