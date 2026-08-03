using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ITAACOracleModel;

[Table("AS_TIME_EVENT_LOG")]
public class AsTimeEventLog
{
    [Required, MaxLength(30), Column("EMP_ID")]
    public string EmpId { get; set; } = null!;

    [Column("LOG_DATETIME")]
    public DateTime LogDateTime { get; set; }

    [MaxLength(11), Column("LOG_DATE")]
    public string? LogDate { get; set; }

    [MaxLength(10), Column("LOG_TIME")]
    public string? LogTime { get; set; }

    [Column("LOGIN_ID")]
    public decimal LoginId { get; set; }

    [Column("READER_ID")]
    public decimal ReaderId { get; set; }

    [Column("EVENT_ID")]
    public decimal? EventId { get; set; }

    [MaxLength(1), Column("STATUS")]
    public string? Status { get; set; }

    [MaxLength(100), Column("COMMENTS")]
    public string? Comments { get; set; }

    [MaxLength(50), Column("USER_ID")]
    public string? UserId { get; set; }

    [Column("MODIFY_DATE")]
    public DateTime? ModifyDate { get; set; }

    [MaxLength(100), Column("JUSTIFY")]
    public string? Justify { get; set; }

    [MaxLength(10), Column("CC_CODE")]
    public string? CcCode { get; set; }

    [MaxLength(10), Column("CC_UNIT")]
    public string? CcUnit { get; set; }

    [Column("LOADING_TIME")]
    public DateTime? LoadingTime { get; set; }

    [MaxLength(20), Column("CREATED_BY")]
    public string? CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [MaxLength(20), Column("MODIFIED_BY")]
    public string? ModifiedBy { get; set; }

    [Column("MODIFIED_DATE")]
    public DateTime? ModifiedDate { get; set; }

    [MaxLength(2), Column("LOG_STATUS")]
    public string? LogStatus { get; set; }

    [MaxLength(2), Column("ATT_STATUS")]
    public string? AttStatus { get; set; }

    [MaxLength(1), Column("LOG_TYPE")]
    public string? LogType { get; set; }
}
