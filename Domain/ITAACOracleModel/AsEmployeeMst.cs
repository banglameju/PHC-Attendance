using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ITAACOracleModel;

[Table("AS_EMPLOYEE_MST")]
public class AsEmployeeMst
{
    [Key, Column("EMPNO"), MaxLength(30)] public string EmpNo { get; set; } = null!;
    [Column("CPRNO"), MaxLength(30)] public string? CprNo { get; set; }
    [Column("EMP_NAME"), MaxLength(60)] public string? EmpName { get; set; }
    [Column("CC_CODE"), MaxLength(15)] public string? CcCode { get; set; }
    [Column("CC_UNIT"), MaxLength(10)] public string? CcUnit { get; set; }
    [Column("DESIG_CODE"), MaxLength(15)] public string? DesigCode { get; set; }
    [Column("ADDRESS1"), MaxLength(100)] public string? Address1 { get; set; }
    [Column("ADDRESS2"), MaxLength(100)] public string? Address2 { get; set; }
    [Column("ADDRESS3"), MaxLength(100)] public string? Address3 { get; set; }
    [Column("PHONE"), MaxLength(15)] public string? Phone { get; set; }
    [Column("NATIONALITY"), MaxLength(10)] public string? Nationality { get; set; }
    [Column("DOB")] public DateTime? Dob { get; set; }
    [Column("SEX")] public string? Sex { get; set; }
    [Column("MARITALSTAT")] public string? MaritalStat { get; set; }
    [Column("JOIN_DATE")] public DateTime? JoinDate { get; set; }
    [Column("PAYTYPE_CODE"), MaxLength(10)] public string? PayTypeCode { get; set; }
    [Column("GRADE_CODE"), MaxLength(10)] public string? GradeCode { get; set; }
    [Column("STEP_CODE"), MaxLength(10)] public string? StepCode { get; set; }
    [Column("EMPLOYEE_TYPE"), MaxLength(12)] public string? EmployeeType { get; set; }
    [Column("OVERTIME")] public string? Overtime { get; set; }
    [Column("CREATED_BY"), MaxLength(25)] public string? CreatedBy { get; set; }
    [Column("CREATED_DATE")] public DateTime? CreatedDate { get; set; }
    [Column("MODIFIED_BY"), MaxLength(25)] public string? ModifiedBy { get; set; }
    [Column("MODIFIED_DATE")] public DateTime? ModifiedDate { get; set; }
    [Column("LAST_ACTION")] public string? LastAction { get; set; }
    [Column("SUPERVISORID"), MaxLength(10)] public string? SupervisorId { get; set; }
    [Column("ISSUPERVISOR")] public string? IsSupervisor { get; set; }
    [Column("ON_CALL")] public string? OnCall { get; set; }
    [Column("ON_STANDBY")] public string? OnStandby { get; set; }
    [Column("STATUS"), MaxLength(35)] public string? Status { get; set; }
    [Column("EMAIL"), MaxLength(35)] public string? Email { get; set; }
    [Column("ATTENDANCE_PATTERN"), MaxLength(5)] public string? AttendancePattern { get; set; }
    [Column("MEDICAL_COMMITY")] public string? MedicalCommity { get; set; }
    [Column("DEDICATION")] public string? Dedication { get; set; }
    [Column("ACTIVE")] public string? Active { get; set; }
    [Column("RELIGION_CODE"), MaxLength(6)] public string? ReligionCode { get; set; }
    [Column("MOH")] public string? Moh { get; set; }
    [Column("MAX_HRS")] public decimal? MaxHrs { get; set; }
    [Column("REGISTERED")] public string? Registered { get; set; }
    [Column("TERMINATION_DATE")] public DateTime? TerminationDate { get; set; }
    [Column("NAT_TYPE"), MaxLength(10)] public string? NatType { get; set; }
    [Column("REMARKS"), MaxLength(500)] public string? Remarks { get; set; }
    [Column("BANK_CODE"), MaxLength(15)] public string? BankCode { get; set; }
    [Column("ACCOUNT_NO"), MaxLength(30)] public string? AccountNo { get; set; }
    [Column("EXT_NO"), MaxLength(10)] public string? ExtNo { get; set; }
    [Column("BRANCH_CODE"), MaxLength(150)] public string? BranchCode { get; set; }
    [Column("BRANCH_NAME"), MaxLength(120)] public string? BranchName { get; set; }
    [Column("ORG_CODE"), MaxLength(15)] public string? OrgCode { get; set; }
    [Column("ANNUAL_LEAVE_BAL")] public decimal? AnnualLeaveBal { get; set; }
    [Column("SICK_LEAVE_BAL")] public decimal? SickLeaveBal { get; set; }
    [Column("EMP_PER_EMAIL"), MaxLength(100)] public string? EmpPerEmail { get; set; }
}
