using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ITAACOracleModel;

[Table("TB_EVENT_FACE_LOG")]
public class TbEventFaceLog
{
    [Key]
    [Column("EVENT_LOG_ID")]
    public decimal EventLogId { get; set; }

    [Column("EMP_ID")]
    public decimal EmpId { get; set; }

    [Required, MaxLength(100)]
    [Column("ACCESS_DATE_TIME")]
    public string AccessDateTime { get; set; } = null!;

    [Required, MaxLength(15)]
    [Column("ACCESS_DATE")]
    public string AccessDate { get; set; } = null!;

    [Required, MaxLength(15)]
    [Column("ACCESS_TIME")]
    public string AccessTime { get; set; } = null!;

    [Required, MaxLength(50)]
    [Column("DEV_SN")]
    public string DevSn { get; set; } = null!;

    [Required, MaxLength(100)]
    [Column("DEV_NAME")]
    public string DevName { get; set; } = null!;

    [Required, MaxLength(100)]
    [Column("EMP_FIRST_NAME")]
    public string EmpFirstName { get; set; } = null!;

    [MaxLength(100)]
    [Column("EMP_LAST_NAME")]
    public string? EmpLastName { get; set; }

    [Column("IS_PROCESSED")]
    public decimal IsProcessed { get; set; } = 0;
}
