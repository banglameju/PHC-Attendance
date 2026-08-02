using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain.CSBImportModels;

public partial class CsbimportContext : DbContext
{
    public CsbimportContext()
    {
    }

    public CsbimportContext(DbContextOptions<CsbimportContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AsException> AsExceptions { get; set; }

    public virtual DbSet<BackupXxcsbHealthDatum> BackupXxcsbHealthData { get; set; }

    public virtual DbSet<CsbAllowancesMaster> CsbAllowancesMasters { get; set; }

    public virtual DbSet<CsbHealthEmpAllowance> CsbHealthEmpAllowances { get; set; }

    public virtual DbSet<CsbHealthLeaveTran> CsbHealthLeaveTrans { get; set; }

    public virtual DbSet<CsbHealthLeaveTransTemp> CsbHealthLeaveTransTemps { get; set; }

    public virtual DbSet<CsbHealthTerminatedEmp> CsbHealthTerminatedEmps { get; set; }

    public virtual DbSet<CsbLeaveMaster> CsbLeaveMasters { get; set; }

    public virtual DbSet<DummyTable> DummyTables { get; set; }

    public virtual DbSet<TMohLeave> TMohLeaves { get; set; }

    public virtual DbSet<TMohLeaveCancel> TMohLeaveCancels { get; set; }

    public virtual DbSet<XxcsbHealthBank> XxcsbHealthBanks { get; set; }

    public virtual DbSet<XxcsbHealthBranch> XxcsbHealthBranches { get; set; }

    public virtual DbSet<XxcsbHealthBudget> XxcsbHealthBudgets { get; set; }

    public virtual DbSet<XxcsbHealthChangeOrg> XxcsbHealthChangeOrgs { get; set; }

    public virtual DbSet<XxcsbHealthChangePo> XxcsbHealthChangePos { get; set; }

    public virtual DbSet<XxcsbHealthDatum> XxcsbHealthData { get; set; }

    public virtual DbSet<XxcsbHealthEmpcatogry> XxcsbHealthEmpcatogries { get; set; }

    public virtual DbSet<XxcsbHealthEmployeestatus> XxcsbHealthEmployeestatuses { get; set; }

    public virtual DbSet<XxcsbHealthGrade> XxcsbHealthGrades { get; set; }

    public virtual DbSet<XxcsbHealthJobPo> XxcsbHealthJobPos { get; set; }

    public virtual DbSet<XxcsbHealthMaritalStatus> XxcsbHealthMaritalStatuses { get; set; }

    public virtual DbSet<XxcsbHealthNationality> XxcsbHealthNationalities { get; set; }

    public virtual DbSet<XxcsbHealthOccupation> XxcsbHealthOccupations { get; set; }

    public virtual DbSet<XxcsbHealthOrganization> XxcsbHealthOrganizations { get; set; }

    public virtual DbSet<XxcsbHealthPosBudget> XxcsbHealthPosBudgets { get; set; }

    public virtual DbSet<XxcsbHealthPosition> XxcsbHealthPositions { get; set; }

    public virtual DbSet<XxcsbHealthPositionGr> XxcsbHealthPositionGrs { get; set; }

    public virtual DbSet<XxcsbHealthQuallevel> XxcsbHealthQuallevels { get; set; }

    public virtual DbSet<XxcsbHealthQualtitle> XxcsbHealthQualtitles { get; set; }

    public virtual DbSet<XxcsbHealthQualtype> XxcsbHealthQualtypes { get; set; }

    public virtual DbSet<XxcsbHealthSex> XxcsbHealthSexes { get; set; }

    public virtual DbSet<XxcsbHealthShift> XxcsbHealthShifts { get; set; }

    public virtual DbSet<XxcsbHealthStandbyot> XxcsbHealthStandbyots { get; set; }

    public virtual DbSet<XxcsbHealthTkgroup> XxcsbHealthTkgroups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Phc-test-aws-db-1.cqlz3th81aq4.eu-west-1.rds.amazonaws.com;Database=CSBImport;Trusted_Connection=True;Integrated Security=false;User Id=admin;Password=9jVF4ribk4LMOd6yV9V9;TrustServerCertificate=True");
        //=> optionsBuilder.UseSqlServer("Server=phcawsprodmssql1.c93fmaje3wb1.eu-west-1.rds.amazonaws.com;Database=CSBImport;Trusted_Connection=True;Integrated Security=false;User Id=admin;Password=VjdO9pnljHQvEfmHzoIo;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AsException>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AS_EXCEPTION");

            entity.Property(e => e.AeErrMsg)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("ae_err_msg");
            entity.Property(e => e.AeErrNum).HasColumnName("ae_err_num");
            entity.Property(e => e.AsCreBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("as_cre_by");
            entity.Property(e => e.AsCreDate).HasColumnName("as_cre_date");
        });

        modelBuilder.Entity<BackupXxcsbHealthDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BACKUP_XXCSB$HEALTH$DATA");

            entity.Property(e => e.Annual).HasColumnName("annual");
            entity.Property(e => e.ApprovedGrade)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("approved_grade");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("bank_account");
            entity.Property(e => e.BankCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("bank_code");
            entity.Property(e => e.BankName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("bank_name");
            entity.Property(e => e.BasicPay).HasColumnName("basic_pay");
            entity.Property(e => e.BranchCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("branch_code");
            entity.Property(e => e.BranchName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("branch_name");
            entity.Property(e => e.BudgetCode)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("budget_code");
            entity.Property(e => e.Car).HasColumnName("car");
            entity.Property(e => e.Chairmanship).HasColumnName("chairmanship");
            entity.Property(e => e.Communication).HasColumnName("communication");
            entity.Property(e => e.Cpr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.Directorate)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("directorate");
            entity.Property(e => e.Division)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("division");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.EmployeeArabicName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("employee_arabic_name");
            entity.Property(e => e.EmployeeCategory)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("employee_category");
            entity.Property(e => e.EmployeeStatus)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("employee_status");
            entity.Property(e => e.EmployyEnglishName)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("employy_english_name");
            entity.Property(e => e.Grade)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("grade");
            entity.Property(e => e.Groupp)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("groupp");
            entity.Property(e => e.Hiring)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("hiring");
            entity.Property(e => e.HlthSciLec).HasColumnName("hlth_sci_lec");
            entity.Property(e => e.Hostelsup).HasColumnName("hostelsup");
            entity.Property(e => e.Housing).HasColumnName("housing");
            entity.Property(e => e.Inducement).HasColumnName("inducement");
            entity.Property(e => e.InsertDate)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("insert_date");
            entity.Property(e => e.LivingStd).HasColumnName("living_std");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("marital_status");
            entity.Property(e => e.Nationality)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nationality");
            entity.Property(e => e.NatureOfWork).HasColumnName("nature_of_work");
            entity.Property(e => e.OccupationCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("occupation_code");
            entity.Property(e => e.Oncall).HasColumnName("oncall");
            entity.Property(e => e.OrganizationCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("organization_code");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("organization_name");
            entity.Property(e => e.ParttimeRate)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("parttime_rate");
            entity.Property(e => e.PositionId).HasColumnName("position_id");
            entity.Property(e => e.Postion)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("postion");
            entity.Property(e => e.Practice).HasColumnName("practice");
            entity.Property(e => e.QualificationCode)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("qualification_code");
            entity.Property(e => e.Religion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("religion");
            entity.Property(e => e.Section)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("sex");
            entity.Property(e => e.ShiftIndCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("shift_ind_code");
            entity.Property(e => e.Sick).HasColumnName("sick");
            entity.Property(e => e.Skill).HasColumnName("skill");
            entity.Property(e => e.Social).HasColumnName("social");
            entity.Property(e => e.Special).HasColumnName("special");
            entity.Property(e => e.Step)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("step");
            entity.Property(e => e.Telephone).HasColumnName("telephone");
            entity.Property(e => e.TelephoneNumber1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("telephone_number_1");
            entity.Property(e => e.TelephoneNumber2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("telephone_number_2");
            entity.Property(e => e.TelephoneNumber3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("telephone_number_3");
            entity.Property(e => e.TkNumber)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("tk_number");
            entity.Property(e => e.Transport).HasColumnName("transport");
            entity.Property(e => e.Uniform).HasColumnName("uniform");
            entity.Property(e => e.Unit)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<CsbAllowancesMaster>(entity =>
        {
            entity.HasKey(e => e.ElementTypeId).HasName("PK_CSB_ALLOWANCES_MASTER_1");

            entity.ToTable("CSB_ALLOWANCES_MASTER");

            entity.Property(e => e.ElementTypeId)
                .ValueGeneratedNever()
                .HasColumnName("element_type_id");
            entity.Property(e => e.AllowanceAr)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("allowance_ar");
            entity.Property(e => e.AllowanceEn)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("allowance_en");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
        });

        modelBuilder.Entity<CsbHealthEmpAllowance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CSB_HEALTH_EMP_ALLOWANCES_1");

            entity.ToTable("CSB_HEALTH_EMP_ALLOWANCES");

            entity.HasIndex(e => e.Cpr, "INX_CSB_EMP_EID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cpr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.ElementTypeId).HasColumnName("element_type_id");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
        });

        modelBuilder.Entity<CsbHealthLeaveTran>(entity =>
        {
            entity.ToTable("CSB_HEALTH_LEAVE_TRANS");

            entity.HasIndex(e => new { e.Cpr, e.FromDate, e.ToDate }, "INX_LEAVE");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbsenceId).HasColumnName("absence_id");
            entity.Property(e => e.Cpr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entry_date");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("from_date");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.LeaveType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("leave_type");
            entity.Property(e => e.NoOfDays).HasColumnName("no_of_days");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("to_date");
        });

        modelBuilder.Entity<CsbHealthLeaveTransTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CSB_HEALTH_LEAVE_TRANS_TEMP");

            entity.Property(e => e.AbsenceId).HasColumnName("absence_id");
            entity.Property(e => e.Cpr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.EntryDate).HasColumnName("entry_date");
            entity.Property(e => e.FromDate).HasColumnName("from_date");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.LeaveType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("leave_type");
            entity.Property(e => e.NoOfDays).HasColumnName("no_of_days");
            entity.Property(e => e.ToDate).HasColumnName("to_date");
        });

        modelBuilder.Entity<CsbHealthTerminatedEmp>(entity =>
        {
            entity.ToTable("CSB_HEALTH_TERMINATED_EMP");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cpr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.FinalProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("final_process_date");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Remark)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("remark");
        });

        modelBuilder.Entity<CsbLeaveMaster>(entity =>
        {
            entity.HasKey(e => e.LeaveCode);

            entity.ToTable("CSB_LEAVE_MASTER");

            entity.Property(e => e.LeaveCode)
                .ValueGeneratedNever()
                .HasColumnName("leave_code");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.LeaveDescAr)
                .HasMaxLength(90)
                .HasColumnName("leave_desc_ar");
            entity.Property(e => e.LeaveDescEng)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("leave_desc_eng");
        });

        modelBuilder.Entity<DummyTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DUMMY_TABLE");

            entity.Property(e => e.A)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("a");
        });

        modelBuilder.Entity<TMohLeave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_MOH_LEAVE");

            entity.Property(e => e.AbsenceId).HasColumnName("absence_id");
            entity.Property(e => e.Cpr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entry_date");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("from_date");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.LeaveType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("leave_type");
            entity.Property(e => e.NoOfDays).HasColumnName("no_of_days");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("to_date");
        });

        modelBuilder.Entity<TMohLeaveCancel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_MOH_LEAVE_CANCEL");

            entity.Property(e => e.AbsenceId).HasColumnName("absence_id");
            entity.Property(e => e.Cpr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.EntryDate).HasColumnName("entry_date");
            entity.Property(e => e.FromDate).HasColumnName("from_date");
            entity.Property(e => e.InsertDate).HasColumnName("insert_date");
            entity.Property(e => e.LeaveType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("leave_type");
            entity.Property(e => e.NoOfDays).HasColumnName("no_of_days");
            entity.Property(e => e.ToDate).HasColumnName("to_date");
        });

        modelBuilder.Entity<XxcsbHealthBank>(entity =>
        {
            entity.HasKey(e => e.Bankcode);

            entity.ToTable("XXCSB$HEALTH$BANK");

            entity.Property(e => e.Bankcode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("bankcode");
            entity.Property(e => e.Bankname)
                .HasMaxLength(372)
                .IsUnicode(false)
                .HasColumnName("bankname");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
        });

        modelBuilder.Entity<XxcsbHealthBranch>(entity =>
        {
            entity.HasKey(e => new { e.Bankcode, e.Branchcode });

            entity.ToTable("XXCSB$HEALTH$BRANCH");

            entity.Property(e => e.Bankcode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("bankcode");
            entity.Property(e => e.Branchcode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("branchcode");
            entity.Property(e => e.Bankname)
                .HasMaxLength(372)
                .IsUnicode(false)
                .HasColumnName("bankname");
            entity.Property(e => e.Branch)
                .HasMaxLength(372)
                .IsUnicode(false)
                .HasColumnName("branch");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
        });

        modelBuilder.Entity<XxcsbHealthBudget>(entity =>
        {
            entity.ToTable("XXCSB$HEALTH$BUDGET");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Budgetcode)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("budgetcode");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Name)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<XxcsbHealthChangeOrg>(entity =>
        {
            entity.HasKey(e => new { e.Cpr, e.Oldcode, e.Newcode });

            entity.ToTable("XXCSB$HEALTH$CHANGE$ORG");

            entity.Property(e => e.Cpr)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.Oldcode).HasColumnName("oldcode");
            entity.Property(e => e.Newcode).HasColumnName("newcode");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("effective_date");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Neworganization)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("neworganization");
            entity.Property(e => e.Oldorganization)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("oldorganization");
        });

        modelBuilder.Entity<XxcsbHealthChangePo>(entity =>
        {
            entity.HasKey(e => new { e.Cpr, e.PositionidNew, e.PositionidOld });

            entity.ToTable("XXCSB$HEALTH$CHANGE$POS");

            entity.Property(e => e.Cpr)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.PositionidNew).HasColumnName("positionid_new");
            entity.Property(e => e.PositionidOld).HasColumnName("positionid_old");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("effective_date");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Newposition)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("newposition");
            entity.Property(e => e.Oldposition)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("oldposition");
        });

        modelBuilder.Entity<XxcsbHealthDatum>(entity =>
        {
            entity.ToTable("XXCSB$HEALTH$DATA");

            entity.HasIndex(e => e.Cpr, "INX_CSB_CPR");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AbsenceHours).HasColumnName("absence_hours");
            entity.Property(e => e.Acting).HasColumnName("acting");
            entity.Property(e => e.AgriculturalLoan).HasColumnName("agricultural_loan");
            entity.Property(e => e.Annual).HasColumnName("annual");
            entity.Property(e => e.ApprovedGrade)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("approved_grade");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("bank_account");
            entity.Property(e => e.BankCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("bank_code");
            entity.Property(e => e.BankName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("bank_name");
            entity.Property(e => e.BasicPay).HasColumnName("basic_pay");
            entity.Property(e => e.BranchCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("branch_code");
            entity.Property(e => e.BranchName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("branch_name");
            entity.Property(e => e.BudgetCode)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("budget_code");
            entity.Property(e => e.Car).HasColumnName("car");
            entity.Property(e => e.Chairmanship).HasColumnName("chairmanship");
            entity.Property(e => e.Communication).HasColumnName("communication");
            entity.Property(e => e.CommutationDed).HasColumnName("commutation_ded");
            entity.Property(e => e.Cpr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("date_of_birth");
            entity.Property(e => e.Directorate)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("directorate");
            entity.Property(e => e.Division)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("division");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.EmployeeArabicName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("employee_arabic_name");
            entity.Property(e => e.EmployeeCategory)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("employee_category");
            entity.Property(e => e.EmployeeStatus)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("employee_status");
            entity.Property(e => e.EmployyEnglishName)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("employy_english_name");
            entity.Property(e => e.GovRentHouseDed).HasColumnName("gov_rent_house_ded");
            entity.Property(e => e.Grade)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("grade");
            entity.Property(e => e.Groupp)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("groupp");
            entity.Property(e => e.HealthElecDed).HasColumnName("health_elec_ded");
            entity.Property(e => e.Hiring)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("hiring");
            entity.Property(e => e.HlthSciLec).HasColumnName("hlth_sci_lec");
            entity.Property(e => e.Hostelsup).HasColumnName("hostelsup");
            entity.Property(e => e.Housing).HasColumnName("housing");
            entity.Property(e => e.HousingLoan).HasColumnName("housing_loan");
            entity.Property(e => e.Inducement).HasColumnName("inducement");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.LawCourDed).HasColumnName("law_cour_ded");
            entity.Property(e => e.LivingStd).HasColumnName("living_std");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("marital_status");
            entity.Property(e => e.MobilePurch).HasColumnName("mobile_purch");
            entity.Property(e => e.Nationality)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nationality");
            entity.Property(e => e.NatureOfWork).HasColumnName("nature_of_work");
            entity.Property(e => e.Nursing).HasColumnName("nursing");
            entity.Property(e => e.OccupationCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("occupation_code");
            entity.Property(e => e.Oncall).HasColumnName("oncall");
            entity.Property(e => e.OrganizationCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("organization_code");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("organization_name");
            entity.Property(e => e.ParttimeRate)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("parttime_rate");
            entity.Property(e => e.PenRepDed).HasColumnName("pen_rep_ded");
            entity.Property(e => e.PenSerPurch).HasColumnName("pen_ser_purch");
            entity.Property(e => e.PensionLoan).HasColumnName("pension_loan");
            entity.Property(e => e.Pfc).HasColumnName("pfc");
            entity.Property(e => e.PositionId).HasColumnName("position_id");
            entity.Property(e => e.Postion)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("postion");
            entity.Property(e => e.Practice).HasColumnName("practice");
            entity.Property(e => e.PrevYearDed).HasColumnName("prev_year_ded");
            entity.Property(e => e.QualificationCode)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("qualification_code");
            entity.Property(e => e.Religion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("religion");
            entity.Property(e => e.Section)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("sex");
            entity.Property(e => e.ShiftIndCode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("shift_ind_code");
            entity.Property(e => e.Sick).HasColumnName("sick");
            entity.Property(e => e.Skill).HasColumnName("skill");
            entity.Property(e => e.Social).HasColumnName("social");
            entity.Property(e => e.SocialPfc).HasColumnName("social_pfc");
            entity.Property(e => e.Special).HasColumnName("special");
            entity.Property(e => e.Step)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("step");
            entity.Property(e => e.Telephone).HasColumnName("telephone");
            entity.Property(e => e.TelephoneNumber1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("telephone_number_1");
            entity.Property(e => e.TelephoneNumber2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("telephone_number_2");
            entity.Property(e => e.TelephoneNumber3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("telephone_number_3");
            entity.Property(e => e.TkNumber)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("tk_number");
            entity.Property(e => e.Transport).HasColumnName("transport");
            entity.Property(e => e.Unemployment).HasColumnName("unemployment");
            entity.Property(e => e.Uniform).HasColumnName("uniform");
            entity.Property(e => e.Unit)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<XxcsbHealthEmpcatogry>(entity =>
        {
            entity.HasKey(e => e.EmploymentCategory);

            entity.ToTable("XXCSB$HEALTH$EMPCATOGRY");

            entity.Property(e => e.EmploymentCategory)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("employment_category");
            entity.Property(e => e.Description)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
        });

        modelBuilder.Entity<XxcsbHealthEmployeestatus>(entity =>
        {
            entity.ToTable("XXCSB$HEALTH$EMPLOYEESTATUS");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArStatus)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ar_status");
            entity.Property(e => e.EngStatus)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("eng_status");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
        });

        modelBuilder.Entity<XxcsbHealthGrade>(entity =>
        {
            entity.HasKey(e => e.GradeId);

            entity.ToTable("XXCSB$HEALTH$GRADE");

            entity.Property(e => e.GradeId)
                .ValueGeneratedNever()
                .HasColumnName("grade_id");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Name)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<XxcsbHealthJobPo>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.PositionId, e.OrganizationId });

            entity.ToTable("XXCSB$HEALTH$JOB$POS");

            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.PositionId).HasColumnName("position_id");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Job)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Occseries)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("occseries");
            entity.Property(e => e.Postion)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("postion");
        });

        modelBuilder.Entity<XxcsbHealthMaritalStatus>(entity =>
        {
            entity.ToTable("XXCSB$HEALTH$MARITAL_STATUS");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.LookupCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("lookup_code");
            entity.Property(e => e.Meaning)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("meaning");
        });

        modelBuilder.Entity<XxcsbHealthNationality>(entity =>
        {
            entity.HasKey(e => e.LookupCode);

            entity.ToTable("XXCSB$HEALTH$NATIONALITY");

            entity.Property(e => e.LookupCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("lookup_code");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Meaning)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("meaning");
        });

        modelBuilder.Entity<XxcsbHealthOccupation>(entity =>
        {
            entity.ToTable("XXCSB$HEALTH$OCCUPATION");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Job)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Occseries)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("occseries");
        });

        modelBuilder.Entity<XxcsbHealthOrganization>(entity =>
        {
            entity.ToTable("XXCSB$HEALTH$ORGANIZATION");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArName)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ar_name");
            entity.Property(e => e.EngName)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("eng_name");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.OrganizationChild)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("organization_child");
            entity.Property(e => e.OrganizationId).HasColumnName("organization_id");
            entity.Property(e => e.OrganizationParent)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("organization_parent");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<XxcsbHealthPosBudget>(entity =>
        {
            entity.ToTable("XXCSB$HEALTH$POS$BUDGET");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualsApp).HasColumnName("Actuals_App.");
            entity.Property(e => e.ActualsEmployees).HasColumnName("Actuals_Employees");
            entity.Property(e => e.ApprovedBudget).HasColumnName("Approved_Budget");
            entity.Property(e => e.ApprovedGrade)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("approved_grade");
            entity.Property(e => e.Directorate)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("directorate");
            entity.Property(e => e.Division)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("division");
            entity.Property(e => e.GroupName)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("group_name");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("location_code");
            entity.Property(e => e.Ministry)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("ministry");
            entity.Property(e => e.Organization)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.PositionTitle)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("position_title");
            entity.Property(e => e.PostionStatus)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("Postion_Status");
            entity.Property(e => e.Section)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Unit)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<XxcsbHealthPosition>(entity =>
        {
            entity.HasKey(e => e.PositionId);

            entity.ToTable("XXCSB$HEALTH$POSITION");

            entity.Property(e => e.PositionId)
                .ValueGeneratedNever()
                .HasColumnName("position_id");
            entity.Property(e => e.Description)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Name)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<XxcsbHealthPositionGr>(entity =>
        {
            entity.ToTable("XXCSB$HEALTH$POSITION$GR");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Grade)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("grade");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Position)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("position");
        });

        modelBuilder.Entity<XxcsbHealthQuallevel>(entity =>
        {
            entity.HasKey(e => e.Quallevel);

            entity.ToTable("XXCSB$HEALTH$QUALLEVEL");

            entity.Property(e => e.Quallevel)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("quallevel");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
        });

        modelBuilder.Entity<XxcsbHealthQualtitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_XXCSB$HEALTH$QUALTITLE_1");

            entity.ToTable("XXCSB$HEALTH$QUALTITLE");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.QualTitle)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("qual_title");
        });

        modelBuilder.Entity<XxcsbHealthQualtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_XXCSB$HEALTH$QUALTYPE_1");

            entity.ToTable("XXCSB$HEALTH$QUALTYPE");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.QualType)
                .HasMaxLength(105)
                .IsUnicode(false)
                .HasColumnName("qual_type");
        });

        modelBuilder.Entity<XxcsbHealthSex>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XXCSB$HEALTH$SEX");

            entity.Property(e => e.Description)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.Sex)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sex");
        });

        modelBuilder.Entity<XxcsbHealthShift>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XXCSB$HEALTH$SHIFT");

            entity.Property(e => e.Description)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.ShiftInd)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("shift_ind");
        });

        modelBuilder.Entity<XxcsbHealthStandbyot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("XXCSB$HEALTH$STANDBYOT");

            entity.Property(e => e.Category)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Cpr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cpr");
            entity.Property(e => e.Hours)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("hours");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<XxcsbHealthTkgroup>(entity =>
        {
            entity.HasKey(e => e.Tk);

            entity.ToTable("XXCSB$HEALTH$TKGROUP");

            entity.Property(e => e.Tk)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("tk");
            entity.Property(e => e.Description)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insert_date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
