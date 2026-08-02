using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain.BiostarModels;

public partial class BiostarContext : DbContext
{
    public BiostarContext()
    {
    }

    public BiostarContext(DbContextOptions<BiostarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sam> Sams { get; set; }

    public virtual DbSet<TGhEmployess> TGhEmployesses { get; set; }

    public virtual DbSet<TbAccessgroup> TbAccessgroups { get; set; }

    public virtual DbSet<TbAccessgroupDoor> TbAccessgroupDoors { get; set; }

    public virtual DbSet<TbAccessgroupUser> TbAccessgroupUsers { get; set; }

    public virtual DbSet<TbAccessgroupZone> TbAccessgroupZones { get; set; }

    public virtual DbSet<TbAdminOption> TbAdminOptions { get; set; }

    public virtual DbSet<TbAlarm> TbAlarms { get; set; }

    public virtual DbSet<TbAlarmDest> TbAlarmDests { get; set; }

    public virtual DbSet<TbAlarmEmail> TbAlarmEmails { get; set; }

    public virtual DbSet<TbAlarmEmailFormat> TbAlarmEmailFormats { get; set; }

    public virtual DbSet<TbAlarmEmailPriority> TbAlarmEmailPriorities { get; set; }

    public virtual DbSet<TbAlarmOutputWave> TbAlarmOutputWaves { get; set; }

    public virtual DbSet<TbAlarmSw> TbAlarmSws { get; set; }

    public virtual DbSet<TbBkupSchedule> TbBkupSchedules { get; set; }

    public virtual DbSet<TbCamera> TbCameras { get; set; }

    public virtual DbSet<TbCameraDept> TbCameraDepts { get; set; }

    public virtual DbSet<TbCameraEvent> TbCameraEvents { get; set; }

    public virtual DbSet<TbCameraVendor> TbCameraVendors { get; set; }

    public virtual DbSet<TbCard> TbCards { get; set; }

    public virtual DbSet<TbCardMifareLayout> TbCardMifareLayouts { get; set; }

    public virtual DbSet<TbDbExport> TbDbExports { get; set; }

    public virtual DbSet<TbDoor> TbDoors { get; set; }

    public virtual DbSet<TbDoorActiveMode> TbDoorActiveModes { get; set; }

    public virtual DbSet<TbDoorDept> TbDoorDepts { get; set; }

    public virtual DbSet<TbDoorReader> TbDoorReaders { get; set; }

    public virtual DbSet<TbEvent> TbEvents { get; set; }

    public virtual DbSet<TbEventDatum> TbEventData { get; set; }

    public virtual DbSet<TbEventFace> TbEventFaces { get; set; }

    public virtual DbSet<TbEventLog> TbEventLogs { get; set; }

    public virtual DbSet<TbEventLogArch> TbEventLogArches { get; set; }

    public virtual DbSet<TbEventLogBk> TbEventLogBks { get; set; }

    public virtual DbSet<TbEventLogManager> TbEventLogManagers { get; set; }

    public virtual DbSet<TbEventLogModify> TbEventLogModifies { get; set; }

    public virtual DbSet<TbHoliday> TbHolidays { get; set; }

    public virtual DbSet<TbHolidayDate> TbHolidayDates { get; set; }

    public virtual DbSet<TbLeave> TbLeaves { get; set; }

    public virtual DbSet<TbLeaveItem> TbLeaveItems { get; set; }

    public virtual DbSet<TbLift> TbLifts { get; set; }

    public virtual DbSet<TbLiftDept> TbLiftDepts { get; set; }

    public virtual DbSet<TbLiftFloor> TbLiftFloors { get; set; }

    public virtual DbSet<TbLiftReader> TbLiftReaders { get; set; }

    public virtual DbSet<TbLiftUser> TbLiftUsers { get; set; }

    public virtual DbSet<TbLiftio> TbLiftios { get; set; }

    public virtual DbSet<TbLiftioInput> TbLiftioInputs { get; set; }

    public virtual DbSet<TbLiftioOutput> TbLiftioOutputs { get; set; }

    public virtual DbSet<TbOperator> TbOperators { get; set; }

    public virtual DbSet<TbOperatorEmail> TbOperatorEmails { get; set; }

    public virtual DbSet<TbOperatorPermit> TbOperatorPermits { get; set; }

    public virtual DbSet<TbOperatorPrivilege> TbOperatorPrivileges { get; set; }

    public virtual DbSet<TbReader> TbReaders { get; set; }

    public virtual DbSet<TbReaderDept> TbReaderDepts { get; set; }

    public virtual DbSet<TbReaderDisplay> TbReaderDisplays { get; set; }

    public virtual DbSet<TbReaderFinger> TbReaderFingers { get; set; }

    public virtual DbSet<TbReaderHw> TbReaderHws { get; set; }

    public virtual DbSet<TbReaderInput> TbReaderInputs { get; set; }

    public virtual DbSet<TbReaderIoEvent> TbReaderIoEvents { get; set; }

    public virtual DbSet<TbReaderNetwork> TbReaderNetworks { get; set; }

    public virtual DbSet<TbReaderNetworkHistory> TbReaderNetworkHistories { get; set; }

    public virtual DbSet<TbReaderOutput> TbReaderOutputs { get; set; }

    public virtual DbSet<TbReaderWiegand> TbReaderWiegands { get; set; }

    public virtual DbSet<TbReaderWlan> TbReaderWlans { get; set; }

    public virtual DbSet<TbSecureio> TbSecureios { get; set; }

    public virtual DbSet<TbSitegraphic> TbSitegraphics { get; set; }

    public virtual DbSet<TbSitegraphicsDoor> TbSitegraphicsDoors { get; set; }

    public virtual DbSet<TbSitegraphicsImageinfo> TbSitegraphicsImageinfos { get; set; }

    public virtual DbSet<TbSitegraphicsObjectinfo> TbSitegraphicsObjectinfos { get; set; }

    public virtual DbSet<TbTaDailyschedule> TbTaDailyschedules { get; set; }

    public virtual DbSet<TbTaDevice> TbTaDevices { get; set; }

    public virtual DbSet<TbTaDeviceEventKey> TbTaDeviceEventKeys { get; set; }

    public virtual DbSet<TbTaHolidayRule> TbTaHolidayRules { get; set; }

    public virtual DbSet<TbTaHolidayRuleDatum> TbTaHolidayRuleData { get; set; }

    public virtual DbSet<TbTaLogHistory> TbTaLogHistories { get; set; }

    public virtual DbSet<TbTaResult> TbTaResults { get; set; }

    public virtual DbSet<TbTaResultCategory> TbTaResultCategories { get; set; }

    public virtual DbSet<TbTaShift> TbTaShifts { get; set; }

    public virtual DbSet<TbTaShiftDaily> TbTaShiftDailies { get; set; }

    public virtual DbSet<TbTaShiftHour> TbTaShiftHours { get; set; }

    public virtual DbSet<TbTaShiftOverride> TbTaShiftOverrides { get; set; }

    public virtual DbSet<TbTaTimecategory> TbTaTimecategories { get; set; }

    public virtual DbSet<TbTaTimeslot> TbTaTimeslots { get; set; }

    public virtual DbSet<TbTaUser> TbTaUsers { get; set; }

    public virtual DbSet<TbTimecode> TbTimecodes { get; set; }

    public virtual DbSet<TbTimezone> TbTimezones { get; set; }

    public virtual DbSet<TbTimezoneDay> TbTimezoneDays { get; set; }

    public virtual DbSet<TbTraceAdmin> TbTraceAdmins { get; set; }

    public virtual DbSet<TbTraceTpl> TbTraceTpls { get; set; }

    public virtual DbSet<TbTraceUser> TbTraceUsers { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbUserAc> TbUserAcs { get; set; }

    public virtual DbSet<TbUserCard> TbUserCards { get; set; }

    public virtual DbSet<TbUserCustomfield> TbUserCustomfields { get; set; }

    public virtual DbSet<TbUserCustominfo> TbUserCustominfos { get; set; }

    public virtual DbSet<TbUserDept> TbUserDepts { get; set; }

    public virtual DbSet<TbUserDevice> TbUserDevices { get; set; }

    public virtual DbSet<TbUserEx> TbUserExes { get; set; }

    public virtual DbSet<TbUserFace> TbUserFaces { get; set; }

    public virtual DbSet<TbUserFaceRaw> TbUserFaceRaws { get; set; }

    public virtual DbSet<TbUserFaceStillcut> TbUserFaceStillcuts { get; set; }

    public virtual DbSet<TbUserFaceTemplate> TbUserFaceTemplates { get; set; }

    public virtual DbSet<TbUserTemplate> TbUserTemplates { get; set; }

    public virtual DbSet<TbUserUpdate> TbUserUpdates { get; set; }

    public virtual DbSet<TbV2readerStatus> TbV2readerStatuses { get; set; }

    public virtual DbSet<TbZone> TbZones { get; set; }

    public virtual DbSet<TbZoneAccesszone> TbZoneAccesszones { get; set; }

    public virtual DbSet<TbZoneAlarm> TbZoneAlarms { get; set; }

    public virtual DbSet<TbZoneAlarmzone> TbZoneAlarmzones { get; set; }

    public virtual DbSet<TbZoneApbzone> TbZoneApbzones { get; set; }

    public virtual DbSet<TbZoneCard> TbZoneCards { get; set; }

    public virtual DbSet<TbZoneControl> TbZoneControls { get; set; }

    public virtual DbSet<TbZoneDoor> TbZoneDoors { get; set; }

    public virtual DbSet<TbZoneElzone> TbZoneElzones { get; set; }

    public virtual DbSet<TbZoneFirezone> TbZoneFirezones { get; set; }

    public virtual DbSet<TbZoneInput> TbZoneInputs { get; set; }

    public virtual DbSet<TbZoneMusterzone> TbZoneMusterzones { get; set; }

    public virtual DbSet<TbZoneOutput> TbZoneOutputs { get; set; }

    public virtual DbSet<TbZoneReader> TbZoneReaders { get; set; }

    public virtual DbSet<ViewDeptEmpCount> ViewDeptEmpCounts { get; set; }

    public virtual DbSet<ViewLogDatum> ViewLogData { get; set; }

    public virtual DbSet<ViewNotEnrolledEmpDept> ViewNotEnrolledEmpDepts { get; set; }

    public virtual DbSet<ViewNotEnrolledEmployess> ViewNotEnrolledEmployesses { get; set; }

    public virtual DbSet<ViewTbTaResultModified> ViewTbTaResultModifieds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.23.127.27;Database=Biostar;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Sam");

            entity.Property(e => e.CountEmps).HasColumnName("Count_emps");
            entity.Property(e => e.NDepartmentIdn).HasColumnName("nDepartmentIdn");
            entity.Property(e => e.SDepartment)
                .HasMaxLength(255)
                .HasColumnName("sDepartment");
            entity.Property(e => e.SUserName)
                .HasMaxLength(32)
                .HasColumnName("sUserName");
        });

        modelBuilder.Entity<TGhEmployess>(entity =>
        {
            entity.HasKey(e => e.GhEmCpr).HasName("PK__T_GH_EMP__B36208BFB5B03B75");

            entity.ToTable("T_GH_EMPLOYESS");

            entity.Property(e => e.GhEmCpr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GH_EM_CPR");
        });

        modelBuilder.Entity<TbAccessgroup>(entity =>
        {
            entity.HasKey(e => e.NAccessIdn);

            entity.ToTable("TB_ACCESSGROUP");

            entity.Property(e => e.NAccessIdn)
                .ValueGeneratedNever()
                .HasColumnName("nAccessIdn");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbAccessgroupDoor>(entity =>
        {
            entity.HasKey(e => e.NAccessDoorIdn);

            entity.ToTable("TB_ACCESSGROUP_DOOR");

            entity.Property(e => e.NAccessDoorIdn).HasColumnName("nAccessDoorIdn");
            entity.Property(e => e.NAccessIdn).HasColumnName("nAccessIdn");
            entity.Property(e => e.NAgentIdn).HasColumnName("nAgentIdn");
            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
            entity.Property(e => e.NType).HasColumnName("nType");
        });

        modelBuilder.Entity<TbAccessgroupUser>(entity =>
        {
            entity.HasKey(e => e.NAccessUserIdn);

            entity.ToTable("TB_ACCESSGROUP_USER");

            entity.Property(e => e.NAccessUserIdn).HasColumnName("nAccessUserIdn");
            entity.Property(e => e.NAccessIdn).HasColumnName("nAccessIdn");
            entity.Property(e => e.NAgentIdn).HasColumnName("nAgentIdn");
            entity.Property(e => e.NType).HasColumnName("nType");
        });

        modelBuilder.Entity<TbAccessgroupZone>(entity =>
        {
            entity.HasKey(e => new { e.NAccessIdn, e.NZoneIdn });

            entity.ToTable("TB_ACCESSGROUP_ZONE");

            entity.Property(e => e.NAccessIdn).HasColumnName("nAccessIdn");
            entity.Property(e => e.NZoneIdn).HasColumnName("nZoneIdn");
            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
        });

        modelBuilder.Entity<TbAdminOption>(entity =>
        {
            entity.HasKey(e => e.NFieldType);

            entity.ToTable("TB_ADMIN_OPTION");

            entity.Property(e => e.NFieldType)
                .ValueGeneratedNever()
                .HasColumnName("nFieldType");
            entity.Property(e => e.SValue)
                .HasMaxLength(255)
                .HasColumnName("sValue");
        });

        modelBuilder.Entity<TbAlarm>(entity =>
        {
            entity.HasKey(e => e.NAlarmIdn);

            entity.ToTable("TB_ALARM");

            entity.Property(e => e.NAlarmIdn).HasColumnName("nAlarmIdn");
            entity.Property(e => e.NAlarmEmailIdn).HasColumnName("nAlarmEmailIdn");
            entity.Property(e => e.NOutputDeviceSoundIdn).HasColumnName("nOutputDeviceSoundIdn");
            entity.Property(e => e.NOutputPort).HasColumnName("nOutputPort");
            entity.Property(e => e.NOutputReaderIdn).HasColumnName("nOutputReaderIdn");
            entity.Property(e => e.NOutputWaveIdn).HasColumnName("nOutputWaveIdn");
            entity.Property(e => e.NSwalarmIdn).HasColumnName("nSWAlarmIdn");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sDescription");
        });

        modelBuilder.Entity<TbAlarmDest>(entity =>
        {
            entity.HasKey(e => e.NAlarmDestIdn);

            entity.ToTable("TB_ALARM_DEST");

            entity.Property(e => e.NAlarmDestIdn).HasColumnName("nAlarmDestIdn");
            entity.Property(e => e.NAgent).HasColumnName("nAgent");
            entity.Property(e => e.NAlarmIdn).HasColumnName("nAlarmIdn");
            entity.Property(e => e.NEventIdn).HasColumnName("nEventIdn");
            entity.Property(e => e.NType).HasColumnName("nType");
        });

        modelBuilder.Entity<TbAlarmEmail>(entity =>
        {
            entity.HasKey(e => e.NAlarmEmailIdn);

            entity.ToTable("TB_ALARM_EMAIL");

            entity.Property(e => e.NAlarmEmailIdn).HasColumnName("nAlarmEmailIdn");
            entity.Property(e => e.NEmailIdn1).HasColumnName("nEmailIdn1");
            entity.Property(e => e.NEmailIdn2).HasColumnName("nEmailIdn2");
            entity.Property(e => e.NEmailIdn3).HasColumnName("nEmailIdn3");
            entity.Property(e => e.NEmailIdn4).HasColumnName("nEmailIdn4");
            entity.Property(e => e.NEmailIdn5).HasColumnName("nEmailIdn5");
        });

        modelBuilder.Entity<TbAlarmEmailFormat>(entity =>
        {
            entity.HasKey(e => e.NEmailFormatIdn).HasName("PK_ALARM_EMAIL_FORMAT");

            entity.ToTable("TB_ALARM_EMAIL_FORMAT");

            entity.Property(e => e.NEmailFormatIdn).HasColumnName("nEmailFormatIdn");
            entity.Property(e => e.SEmailMessage)
                .HasMaxLength(500)
                .HasColumnName("sEmailMessage");
            entity.Property(e => e.SEmailTitle)
                .HasMaxLength(255)
                .HasColumnName("sEmailTitle");
        });

        modelBuilder.Entity<TbAlarmEmailPriority>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_ALARM_EMAIL_PRIORITY");

            entity.Property(e => e.NPriorityFormatIdn0).HasColumnName("nPriorityFormatIdn0");
            entity.Property(e => e.NPriorityFormatIdn1).HasColumnName("nPriorityFormatIdn1");
            entity.Property(e => e.NPriorityFormatIdn2).HasColumnName("nPriorityFormatIdn2");
            entity.Property(e => e.NPriorityFormatIdn3).HasColumnName("nPriorityFormatIdn3");
            entity.Property(e => e.NPriorityFormatIdn4).HasColumnName("nPriorityFormatIdn4");
        });

        modelBuilder.Entity<TbAlarmOutputWave>(entity =>
        {
            entity.HasKey(e => e.NOutputWaveIdn);

            entity.ToTable("TB_ALARM_OUTPUT_WAVE");

            entity.Property(e => e.NOutputWaveIdn).HasColumnName("nOutputWaveIdn");
            entity.Property(e => e.NCount).HasColumnName("nCount");
            entity.Property(e => e.NDelay).HasColumnName("nDelay");
            entity.Property(e => e.NHigh).HasColumnName("nHigh");
            entity.Property(e => e.NLow).HasColumnName("nLow");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbAlarmSw>(entity =>
        {
            entity.HasKey(e => e.NSwalarmIdn);

            entity.ToTable("TB_ALARM_SW");

            entity.Property(e => e.NSwalarmIdn).HasColumnName("nSWAlarmIdn");
            entity.Property(e => e.SFileName)
                .HasMaxLength(64)
                .HasColumnName("sFileName");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbBkupSchedule>(entity =>
        {
            entity.HasKey(e => e.NFieldType);

            entity.ToTable("TB_BKUP_SCHEDULE");

            entity.Property(e => e.NFieldType)
                .ValueGeneratedNever()
                .HasColumnName("nFieldType");
            entity.Property(e => e.SValue)
                .HasMaxLength(255)
                .HasColumnName("sValue");
        });

        modelBuilder.Entity<TbCamera>(entity =>
        {
            entity.HasKey(e => e.NCameraIdn);

            entity.ToTable("TB_CAMERA");

            entity.Property(e => e.NCameraIdn).HasColumnName("nCameraIdn");
            entity.Property(e => e.NDepartmentIdn).HasColumnName("nDepartmentIdn");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.NPort).HasColumnName("nPort");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.NVendor).HasColumnName("nVendor");
            entity.Property(e => e.SIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sIP");
            entity.Property(e => e.SModel)
                .HasMaxLength(64)
                .HasColumnName("sModel");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
            entity.Property(e => e.SPassword)
                .HasMaxLength(64)
                .HasColumnName("sPassword");
            entity.Property(e => e.SUserId)
                .HasMaxLength(64)
                .HasColumnName("sUserID");
        });

        modelBuilder.Entity<TbCameraDept>(entity =>
        {
            entity.HasKey(e => e.NDepartmentIdn);

            entity.ToTable("TB_CAMERA_DEPT");

            entity.Property(e => e.NDepartmentIdn).HasColumnName("nDepartmentIdn");
            entity.Property(e => e.NDepth).HasColumnName("nDepth");
            entity.Property(e => e.NParentIdn).HasColumnName("nParentIdn");
            entity.Property(e => e.SDepartment)
                .HasMaxLength(255)
                .HasColumnName("sDepartment");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbCameraEvent>(entity =>
        {
            entity.HasKey(e => e.NCameraEventIdn);

            entity.ToTable("TB_CAMERA_EVENT");

            entity.Property(e => e.NCameraEventIdn).HasColumnName("nCameraEventIdn");
            entity.Property(e => e.BEventIdns)
                .HasMaxLength(2056)
                .IsFixedLength()
                .HasColumnName("bEventIdns");
            entity.Property(e => e.NCameraIdn).HasColumnName("nCameraIdn");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NReaderType).HasColumnName("nReaderType");
            entity.Property(e => e.SReaderName)
                .HasMaxLength(64)
                .HasColumnName("sReaderName");
        });

        modelBuilder.Entity<TbCameraVendor>(entity =>
        {
            entity.HasKey(e => e.NVendorIdn);

            entity.ToTable("TB_CAMERA_VENDOR");

            entity.Property(e => e.NVendorIdn).HasColumnName("nVendorIdn");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbCard>(entity =>
        {
            entity.HasKey(e => e.NCardIdn);

            entity.ToTable("TB_CARD");

            entity.Property(e => e.NCardIdn).HasColumnName("nCardIdn");
            entity.Property(e => e.NAccessgroup).HasColumnName("nAccessgroup");
            entity.Property(e => e.NIndex).HasColumnName("nIndex");
            entity.Property(e => e.NSecurityLevel).HasColumnName("nSecurityLevel");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.SCardNo)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sCardNo");
        });

        modelBuilder.Entity<TbCardMifareLayout>(entity =>
        {
            entity.HasKey(e => e.NMifareIdn);

            entity.ToTable("TB_CARD_MIFARE_LAYOUT");

            entity.Property(e => e.NMifareIdn).HasColumnName("nMifareIdn");
            entity.Property(e => e.NCisidn).HasColumnName("nCISIdn");
            entity.Property(e => e.NNumOfTemplate).HasColumnName("nNumOfTemplate");
            entity.Property(e => e.NTemplateBlock1).HasColumnName("nTemplateBlock1");
            entity.Property(e => e.NTemplateBlock2).HasColumnName("nTemplateBlock2");
            entity.Property(e => e.NTemplateBlock3).HasColumnName("nTemplateBlock3");
            entity.Property(e => e.NTemplateBlock4).HasColumnName("nTemplateBlock4");
            entity.Property(e => e.NTemplateSize).HasColumnName("nTemplateSize");
        });

        modelBuilder.Entity<TbDbExport>(entity =>
        {
            entity.ToTable("TB_DB_EXPORT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PrimaryKey).HasColumnName("primary_key");
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("table_name");
        });

        modelBuilder.Entity<TbDoor>(entity =>
        {
            entity.HasKey(e => e.NDoorIdn);

            entity.ToTable("TB_DOOR");

            entity.Property(e => e.NDoorIdn).HasColumnName("nDoorIdn");
            entity.Property(e => e.NDoorDept).HasColumnName("nDoorDept");
            entity.Property(e => e.NHoldTime).HasColumnName("nHoldTime");
            entity.Property(e => e.NInputDelay).HasColumnName("nInputDelay");
            entity.Property(e => e.NIoreaderIdn).HasColumnName("nIOReaderIdn");
            entity.Property(e => e.NOpenRelayId).HasColumnName("nOpenRelayID");
            entity.Property(e => e.NOpenTime).HasColumnName("nOpenTime");
            entity.Property(e => e.NUnlockTrigger).HasColumnName("nUnlockTrigger");
            entity.Property(e => e.NZoneIdn).HasColumnName("nZoneIdn");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbDoorActiveMode>(entity =>
        {
            entity.HasKey(e => e.NDoorIdn);

            entity.ToTable("TB_DOOR_ACTIVE_MODE");

            entity.Property(e => e.NDoorIdn)
                .ValueGeneratedNever()
                .HasColumnName("nDoorIdn");
            entity.Property(e => e.NMethod)
                .HasDefaultValue(1)
                .HasColumnName("nMethod");
            entity.Property(e => e.NMode).HasColumnName("nMode");
            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
            entity.Property(e => e.NType).HasColumnName("nType");
        });

        modelBuilder.Entity<TbDoorDept>(entity =>
        {
            entity.HasKey(e => e.NDoorDept);

            entity.ToTable("TB_DOOR_DEPT");

            entity.Property(e => e.NDoorDept).HasColumnName("nDoorDept");
            entity.Property(e => e.NDepth).HasColumnName("nDepth");
            entity.Property(e => e.NParentIdn).HasColumnName("nParentIdn");
            entity.Property(e => e.SDepartment)
                .HasMaxLength(255)
                .HasColumnName("sDepartment");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbDoorReader>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn);

            entity.ToTable("TB_DOOR_READER");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.NCloseEvent).HasColumnName("nCloseEvent");
            entity.Property(e => e.NCloseTime).HasColumnName("nCloseTime");
            entity.Property(e => e.NDoorIdn).HasColumnName("nDoorIdn");
            entity.Property(e => e.NInout).HasColumnName("nInout");
            entity.Property(e => e.NOpenEvent).HasColumnName("nOpenEvent");
            entity.Property(e => e.NOpenRelay).HasColumnName("nOpenRelay");
            entity.Property(e => e.NOpenTime).HasColumnName("nOpenTime");
            entity.Property(e => e.NRte).HasColumnName("nRTE");
            entity.Property(e => e.NRtetype).HasColumnName("nRTEType");
            entity.Property(e => e.NSensor).HasColumnName("nSensor");
            entity.Property(e => e.NSensorType).HasColumnName("nSensorType");
        });

        modelBuilder.Entity<TbEvent>(entity =>
        {
            entity.HasKey(e => e.NEventIdn);

            entity.ToTable("TB_EVENT");

            entity.Property(e => e.NEventIdn)
                .ValueGeneratedNever()
                .HasColumnName("nEventIdn");
            entity.Property(e => e.NAck).HasColumnName("nAck");
            entity.Property(e => e.NAlarmEmailIdn).HasColumnName("nAlarmEmailIdn");
            entity.Property(e => e.NPriority).HasColumnName("nPriority");
            entity.Property(e => e.NSwalarmIdn).HasColumnName("nSWAlarmIdn");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbEventDatum>(entity =>
        {
            entity.HasKey(e => e.NEventIdn);

            entity.ToTable("TB_EVENT_DATA");

            entity.Property(e => e.NEventIdn)
                .ValueGeneratedNever()
                .HasColumnName("nEventIdn");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbEventFace>(entity =>
        {
            entity.HasKey(e => new { e.NDateTime, e.NReaderIdn, e.NEventIdn, e.NUserId });

            entity.ToTable("TB_EVENT_FACE");

            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NEventIdn).HasColumnName("nEventIdn");
            entity.Property(e => e.NUserId).HasColumnName("nUserID");
            entity.Property(e => e.BFaceImage).HasColumnName("bFaceImage");
            entity.Property(e => e.NEventFaceIdn)
                .ValueGeneratedOnAdd()
                .HasColumnName("nEventFaceIdn");
            entity.Property(e => e.NFaceImageLen).HasColumnName("nFaceImageLen");
            entity.Property(e => e.NType).HasColumnName("nType");
        });

        modelBuilder.Entity<TbEventLog>(entity =>
        {
            entity.HasKey(e => new { e.NDateTime, e.NEventIdn, e.NReaderIdn, e.NUserId });

            entity.ToTable("TB_EVENT_LOG");

            entity.HasIndex(e => new { e.NDateTime, e.NUserId }, "NonClusteredIndex-20240902-141536");

            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NEventIdn).HasColumnName("nEventIdn");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NUserId).HasColumnName("nUserID");
            entity.Property(e => e.NEventLogIdn)
                .ValueGeneratedOnAdd()
                .HasColumnName("nEventLogIdn");
            entity.Property(e => e.NIsLog).HasColumnName("nIsLog");
            entity.Property(e => e.NIsUseTa).HasColumnName("nIsUseTA");
            entity.Property(e => e.NTnaevent).HasColumnName("nTNAEvent");
            entity.Property(e => e.NType).HasColumnName("nType");
        });

        modelBuilder.Entity<TbEventLogArch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_EVENT_LOG_ARCH");

            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NEventIdn).HasColumnName("nEventIdn");
            entity.Property(e => e.NEventLogIdn)
                .ValueGeneratedOnAdd()
                .HasColumnName("nEventLogIdn");
            entity.Property(e => e.NIsLog).HasColumnName("nIsLog");
            entity.Property(e => e.NIsUseTa).HasColumnName("nIsUseTA");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NTnaevent).HasColumnName("nTNAEvent");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.NUserId).HasColumnName("nUserID");
        });

        modelBuilder.Entity<TbEventLogBk>(entity =>
        {
            entity.HasKey(e => new { e.NDateTime, e.NEventIdn, e.NReaderIdn, e.NUserId });

            entity.ToTable("TB_EVENT_LOG_BK");

            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NEventIdn).HasColumnName("nEventIdn");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NUserId).HasColumnName("nUserID");
            entity.Property(e => e.NEventLogIdn)
                .ValueGeneratedOnAdd()
                .HasColumnName("nEventLogIdn");
            entity.Property(e => e.NIsLog).HasColumnName("nIsLog");
            entity.Property(e => e.NIsUseTa).HasColumnName("nIsUseTA");
            entity.Property(e => e.NTnaevent).HasColumnName("nTNAEvent");
            entity.Property(e => e.NType).HasColumnName("nType");
        });

        modelBuilder.Entity<TbEventLogManager>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn);

            entity.ToTable("TB_EVENT_LOG_MANAGER");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.NLastDate).HasColumnName("nLastDate");
            entity.Property(e => e.V2LogIndex).HasColumnName("v2LogIndex");
        });

        modelBuilder.Entity<TbEventLogModify>(entity =>
        {
            entity.HasKey(e => e.NEventLogIdn);

            entity.ToTable("TB_EVENT_LOG_MODIFY");

            entity.Property(e => e.NEventLogIdn)
                .ValueGeneratedNever()
                .HasColumnName("nEventLogIdn");
            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NEventIdn).HasColumnName("nEventIdn");
            entity.Property(e => e.NFlag).HasColumnName("nFlag");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NTnaevent).HasColumnName("nTNAEvent");
            entity.Property(e => e.NUserId).HasColumnName("nUserID");
        });

        modelBuilder.Entity<TbHoliday>(entity =>
        {
            entity.HasKey(e => e.NHoliday);

            entity.ToTable("TB_HOLIDAY");

            entity.Property(e => e.NHoliday).HasColumnName("nHoliday");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbHolidayDate>(entity =>
        {
            entity.HasKey(e => new { e.NHoliday, e.NDate });

            entity.ToTable("TB_HOLIDAY_DATE");

            entity.Property(e => e.NHoliday).HasColumnName("nHoliday");
            entity.Property(e => e.NDate).HasColumnName("nDate");
            entity.Property(e => e.NDaysLong).HasColumnName("nDaysLong");
            entity.Property(e => e.NYearRepeat).HasColumnName("nYearRepeat");
        });

        modelBuilder.Entity<TbLeave>(entity =>
        {
            entity.HasKey(e => e.NLeaveIdn);

            entity.ToTable("TB_LEAVE");

            entity.Property(e => e.NLeaveIdn).HasColumnName("nLeaveIdn");
            entity.Property(e => e.NEndTime).HasColumnName("nEndTime");
            entity.Property(e => e.NStartTime).HasColumnName("nStartTime");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbLeaveItem>(entity =>
        {
            entity.HasKey(e => e.NLeaveItemIdn);

            entity.ToTable("TB_LEAVE_ITEM");

            entity.Property(e => e.NLeaveItemIdn).HasColumnName("nLeaveItemIdn");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbLift>(entity =>
        {
            entity.HasKey(e => e.NLiftIdn);

            entity.ToTable("TB_LIFT");

            entity.Property(e => e.NLiftIdn).HasColumnName("nLiftIdn");
            entity.Property(e => e.NBaseFloor).HasColumnName("nBaseFloor");
            entity.Property(e => e.NIoreaderIdn).HasColumnName("nIOReaderIdn");
            entity.Property(e => e.NLiftDept).HasColumnName("nLiftDept");
            entity.Property(e => e.NMaxFloor).HasColumnName("nMaxFloor");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbLiftDept>(entity =>
        {
            entity.HasKey(e => e.NLiftDept);

            entity.ToTable("TB_LIFT_DEPT");

            entity.Property(e => e.NLiftDept).HasColumnName("nLiftDept");
            entity.Property(e => e.NDepth).HasColumnName("nDepth");
            entity.Property(e => e.NParentIdn).HasColumnName("nParentIdn");
            entity.Property(e => e.SDepartment)
                .HasMaxLength(255)
                .HasColumnName("sDepartment");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbLiftFloor>(entity =>
        {
            entity.HasKey(e => e.NLiftFloorIdn);

            entity.ToTable("TB_LIFT_FLOOR");

            entity.Property(e => e.NLiftFloorIdn).HasColumnName("nLiftFloorIdn");
            entity.Property(e => e.NFloor).HasColumnName("nFloor");
            entity.Property(e => e.NIndex).HasColumnName("nIndex");
            entity.Property(e => e.NLiftIdn).HasColumnName("nLiftIdn");
            entity.Property(e => e.NOutput).HasColumnName("nOutput");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbLiftReader>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn);

            entity.ToTable("TB_LIFT_READER");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.NLiftIdn).HasColumnName("nLiftIdn");
        });

        modelBuilder.Entity<TbLiftUser>(entity =>
        {
            entity.HasKey(e => e.NLiftUserIdn);

            entity.ToTable("TB_LIFT_USER");

            entity.Property(e => e.NLiftUserIdn).HasColumnName("nLiftUserIdn");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.NLiftFloorIdn).HasColumnName("nLiftFloorIdn");
            entity.Property(e => e.SDepartment)
                .HasMaxLength(64)
                .HasColumnName("sDepartment");
            entity.Property(e => e.SUserId)
                .HasMaxLength(64)
                .HasColumnName("sUserID");
            entity.Property(e => e.SUserName)
                .HasMaxLength(96)
                .HasColumnName("sUserName");
        });

        modelBuilder.Entity<TbLiftio>(entity =>
        {
            entity.HasKey(e => e.NLiftIoidn);

            entity.ToTable("TB_LIFTIO");

            entity.Property(e => e.NLiftIoidn).HasColumnName("nLiftIOIdn");
            entity.Property(e => e.NIndex).HasColumnName("nIndex");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
        });

        modelBuilder.Entity<TbLiftioInput>(entity =>
        {
            entity.HasKey(e => e.NLiftIoidn);

            entity.ToTable("TB_LIFTIO_INPUT");

            entity.Property(e => e.NLiftIoidn)
                .ValueGeneratedNever()
                .HasColumnName("nLiftIOIdn");
            entity.Property(e => e.NInput0).HasColumnName("nInput0");
            entity.Property(e => e.NInput1).HasColumnName("nInput1");
            entity.Property(e => e.NInput10).HasColumnName("nInput10");
            entity.Property(e => e.NInput11).HasColumnName("nInput11");
            entity.Property(e => e.NInput2).HasColumnName("nInput2");
            entity.Property(e => e.NInput3).HasColumnName("nInput3");
            entity.Property(e => e.NInput4).HasColumnName("nInput4");
            entity.Property(e => e.NInput5).HasColumnName("nInput5");
            entity.Property(e => e.NInput6).HasColumnName("nInput6");
            entity.Property(e => e.NInput7).HasColumnName("nInput7");
            entity.Property(e => e.NInput8).HasColumnName("nInput8");
            entity.Property(e => e.NInput9).HasColumnName("nInput9");
        });

        modelBuilder.Entity<TbLiftioOutput>(entity =>
        {
            entity.HasKey(e => e.NLiftIoidn);

            entity.ToTable("TB_LIFTIO_OUTPUT");

            entity.Property(e => e.NLiftIoidn)
                .ValueGeneratedNever()
                .HasColumnName("nLiftIOIdn");
            entity.Property(e => e.NOutput0).HasColumnName("nOutput0");
            entity.Property(e => e.NOutput1).HasColumnName("nOutput1");
            entity.Property(e => e.NOutput10).HasColumnName("nOutput10");
            entity.Property(e => e.NOutput11).HasColumnName("nOutput11");
            entity.Property(e => e.NOutput2).HasColumnName("nOutput2");
            entity.Property(e => e.NOutput3).HasColumnName("nOutput3");
            entity.Property(e => e.NOutput4).HasColumnName("nOutput4");
            entity.Property(e => e.NOutput5).HasColumnName("nOutput5");
            entity.Property(e => e.NOutput6).HasColumnName("nOutput6");
            entity.Property(e => e.NOutput7).HasColumnName("nOutput7");
            entity.Property(e => e.NOutput8).HasColumnName("nOutput8");
            entity.Property(e => e.NOutput9).HasColumnName("nOutput9");
        });

        modelBuilder.Entity<TbOperator>(entity =>
        {
            entity.HasKey(e => e.SUserId);

            entity.ToTable("TB_OPERATOR");

            entity.Property(e => e.SUserId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("sUserID");
            entity.Property(e => e.NPrivilegeIdn).HasColumnName("nPrivilegeIdn");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.SPassword)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("sPassword");
        });

        modelBuilder.Entity<TbOperatorEmail>(entity =>
        {
            entity.HasKey(e => e.NEmailIdn);

            entity.ToTable("TB_OPERATOR_EMAIL");

            entity.Property(e => e.NEmailIdn).HasColumnName("nEmailIdn");
            entity.Property(e => e.NSecurityType).HasColumnName("nSecurityType");
            entity.Property(e => e.SPassword)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("sPassword");
            entity.Property(e => e.SRecipient)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sRecipient");
            entity.Property(e => e.SSender)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sSender");
            entity.Property(e => e.SSmtpport)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sSMTPPort");
            entity.Property(e => e.SSmtpserver)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sSMTPServer");
            entity.Property(e => e.SUserId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sUserID");
        });

        modelBuilder.Entity<TbOperatorPermit>(entity =>
        {
            entity.HasKey(e => e.NPermitIdn);

            entity.ToTable("TB_OPERATOR_PERMIT");

            entity.Property(e => e.NPermitIdn).HasColumnName("nPermitIdn");
            entity.Property(e => e.NAgentIdn).HasColumnName("nAgentIdn");
            entity.Property(e => e.NAgentType).HasColumnName("nAgentType");
            entity.Property(e => e.NModuleIdn).HasColumnName("nModuleIdn");
            entity.Property(e => e.NPermit).HasColumnName("nPermit");
            entity.Property(e => e.NPrivilegeIdn).HasColumnName("nPrivilegeIdn");
        });

        modelBuilder.Entity<TbOperatorPrivilege>(entity =>
        {
            entity.HasKey(e => e.NPrivilegeIdn);

            entity.ToTable("TB_OPERATOR_PRIVILEGE");

            entity.Property(e => e.NPrivilegeIdn).HasColumnName("nPrivilegeIdn");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbReader>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn);

            entity.ToTable("TB_READER");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.NConnType).HasColumnName("nConnType");
            entity.Property(e => e.NDeptIdn).HasColumnName("nDeptIdn");
            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sDescription");
            entity.Property(e => e.SIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sIP");
            entity.Property(e => e.SMacAddress)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sMacAddress");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbReaderDept>(entity =>
        {
            entity.HasKey(e => e.NDeptIdn);

            entity.ToTable("TB_READER_DEPT");

            entity.Property(e => e.NDeptIdn).HasColumnName("nDeptIdn");
            entity.Property(e => e.NDeptType).HasColumnName("nDeptType");
            entity.Property(e => e.NDepth).HasColumnName("nDepth");
            entity.Property(e => e.NParentIdn).HasColumnName("nParentIdn");
            entity.Property(e => e.NParentReaderIdn).HasColumnName("nParentReaderIdn");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbReaderDisplay>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn);

            entity.ToTable("TB_READER_DISPLAY");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.NBackground).HasColumnName("nBackground");
            entity.Property(e => e.NDateType).HasColumnName("nDateType");
            entity.Property(e => e.NLanguage).HasColumnName("nLanguage");
            entity.Property(e => e.NMenuTimeout).HasColumnName("nMenuTimeout");
            entity.Property(e => e.NMessageTimeout).HasColumnName("nMessageTimeout");
            entity.Property(e => e.NPrivateAuth).HasColumnName("nPrivateAuth");
            entity.Property(e => e.NSubInfo).HasColumnName("nSubInfo");
            entity.Property(e => e.NTimeSync).HasColumnName("nTimeSync");
            entity.Property(e => e.NVolume).HasColumnName("nVolume");
        });

        modelBuilder.Entity<TbReaderFinger>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn).HasName("PK_TB_READER_FINGER2");

            entity.ToTable("TB_READER_FINGER");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.NCheckDuplicate).HasColumnName("nCheckDuplicate");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.NFastMode).HasColumnName("nFastMode");
            entity.Property(e => e.NFreeScanDelay).HasColumnName("nFreeScanDelay");
            entity.Property(e => e.NImageQuality).HasColumnName("nImageQuality");
            entity.Property(e => e.NMatchTimeout).HasColumnName("nMatchTimeout");
            entity.Property(e => e.NSecurity).HasColumnName("nSecurity");
            entity.Property(e => e.NTimeout).HasColumnName("nTimeout");
            entity.Property(e => e.NViewImage).HasColumnName("nViewImage");
        });

        modelBuilder.Entity<TbReaderHw>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn);

            entity.ToTable("TB_READER_HW");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.SBlackfinVersion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sBlackfinVersion");
            entity.Property(e => e.SBoardVersion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sBoardVersion");
            entity.Property(e => e.SFirmwareVersion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sFirmwareVersion");
            entity.Property(e => e.SKernelVersion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sKernelVersion");
            entity.Property(e => e.SPrivateKey)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sPrivateKey");
            entity.Property(e => e.SProductName)
                .HasMaxLength(32)
                .HasColumnName("sProductName");
        });

        modelBuilder.Entity<TbReaderInput>(entity =>
        {
            entity.HasKey(e => e.NReaderIoidn).HasName("PK_TB_READER_IO");

            entity.ToTable("TB_READER_INPUT");

            entity.Property(e => e.NReaderIoidn).HasColumnName("nReaderIOIdn");
            entity.Property(e => e.NDurationTime).HasColumnName("nDurationTime");
            entity.Property(e => e.NFunctionType).HasColumnName("nFunctionType");
            entity.Property(e => e.NInputType).HasColumnName("nInputType");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NSwitchType).HasColumnName("nSwitchType");
            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
        });

        modelBuilder.Entity<TbReaderIoEvent>(entity =>
        {
            entity.HasKey(e => e.NReaderIoidn).HasName("PK_TB_EVENT_READER_IO");

            entity.ToTable("TB_READER_IO_EVENT");

            entity.Property(e => e.NReaderIoidn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIOIdn");
            entity.Property(e => e.NEventIdn).HasColumnName("nEventIdn");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
        });

        modelBuilder.Entity<TbReaderNetwork>(entity =>
        {
            entity.HasKey(e => new { e.NReaderIdn, e.NUpdateDate });

            entity.ToTable("TB_READER_NETWORK");

            entity.HasIndex(e => new { e.NReaderIdn, e.NIsHistory }, "IX_TB_READER_NETWORK");

            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NUpdateDate).HasColumnName("nUpdateDate");
            entity.Property(e => e.NDhcp).HasColumnName("nDHCP");
            entity.Property(e => e.NIsHistory).HasColumnName("nIsHistory");
            entity.Property(e => e.NMaxConnection).HasColumnName("nMaxConnection");
            entity.Property(e => e.NPort).HasColumnName("nPort");
            entity.Property(e => e.NRs232baudrate).HasColumnName("nRS232Baudrate");
            entity.Property(e => e.NRs485baudrate).HasColumnName("nRS485Baudrate");
            entity.Property(e => e.NRs485mode).HasColumnName("nRS485Mode");
            entity.Property(e => e.NSecureIo).HasColumnName("nSecureIO");
            entity.Property(e => e.NSsl).HasColumnName("nSSL");
            entity.Property(e => e.NTimeSync).HasColumnName("nTimeSync");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.SComPort)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("sComPort");
            entity.Property(e => e.SGateway)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sGateway");
            entity.Property(e => e.SIpaddress)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sIPAddress");
            entity.Property(e => e.SServerIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sServerIP");
            entity.Property(e => e.SSubnetMask)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sSubnetMask");
        });

        modelBuilder.Entity<TbReaderNetworkHistory>(entity =>
        {
            entity.HasKey(e => new { e.NReaderIdn, e.NUpdateDate });

            entity.ToTable("TB_READER_NETWORK_HISTORY");

            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NUpdateDate).HasColumnName("nUpdateDate");
            entity.Property(e => e.SAdminId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sAdminID");
            entity.Property(e => e.SIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sIP");
        });

        modelBuilder.Entity<TbReaderOutput>(entity =>
        {
            entity.HasKey(e => e.NReaderIoidn);

            entity.ToTable("TB_READER_OUTPUT");

            entity.Property(e => e.NReaderIoidn).HasColumnName("nReaderIOIdn");
            entity.Property(e => e.NDeviceId).HasColumnName("nDeviceID");
            entity.Property(e => e.NEvent).HasColumnName("nEvent");
            entity.Property(e => e.NOutputWaveIdn).HasColumnName("nOutputWaveIdn");
            entity.Property(e => e.NPriority).HasColumnName("nPriority");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NRelayOn).HasColumnName("nRelayOn");
            entity.Property(e => e.NRelayPort).HasColumnName("nRelayPort");
        });

        modelBuilder.Entity<TbReaderWiegand>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn);

            entity.ToTable("TB_READER_WIEGAND");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.NCardIdsize).HasColumnName("nCardIDSize");
            entity.Property(e => e.NCustomIdsize).HasColumnName("nCustomIDSize");
            entity.Property(e => e.NReserved).HasColumnName("nReserved");
        });

        modelBuilder.Entity<TbReaderWlan>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn);

            entity.ToTable("TB_READER_WLAN");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.NAuthType).HasColumnName("nAuthType");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.NKeyType).HasColumnName("nKeyType");
            entity.Property(e => e.NOperationMode).HasColumnName("nOperationMode");
            entity.Property(e => e.NPresetIndex).HasColumnName("nPresetIndex");
            entity.Property(e => e.SEssid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sEssid");
            entity.Property(e => e.SKey)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sKey");
            entity.Property(e => e.SName)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbSecureio>(entity =>
        {
            entity.HasKey(e => e.NSecureIoidn);

            entity.ToTable("TB_SECUREIO");

            entity.Property(e => e.NSecureIoidn).HasColumnName("nSecureIOIdn");
            entity.Property(e => e.NIndex).HasColumnName("nIndex");
            entity.Property(e => e.NInput0).HasColumnName("nInput0");
            entity.Property(e => e.NInput1).HasColumnName("nInput1");
            entity.Property(e => e.NInput2).HasColumnName("nInput2");
            entity.Property(e => e.NInput3).HasColumnName("nInput3");
            entity.Property(e => e.NOutput0).HasColumnName("nOutput0");
            entity.Property(e => e.NOutput1).HasColumnName("nOutput1");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
        });

        modelBuilder.Entity<TbSitegraphic>(entity =>
        {
            entity.HasKey(e => e.NSiteGraphicsIdn).HasName("PK_TB_SITEGRAPHICS_SITEGRAPHICS");

            entity.ToTable("TB_SITEGRAPHICS");

            entity.Property(e => e.NSiteGraphicsIdn)
                .ValueGeneratedNever()
                .HasColumnName("nSiteGraphicsIdn");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbSitegraphicsDoor>(entity =>
        {
            entity.HasKey(e => new { e.NSiteGraphicsIdn, e.NDoorIdn });

            entity.ToTable("TB_SITEGRAPHICS_DOORS");

            entity.Property(e => e.NSiteGraphicsIdn).HasColumnName("nSiteGraphicsIdn");
            entity.Property(e => e.NDoorIdn).HasColumnName("nDoorIdn");
            entity.Property(e => e.NObjectIdn).HasColumnName("nObjectIdn");
        });

        modelBuilder.Entity<TbSitegraphicsImageinfo>(entity =>
        {
            entity.HasKey(e => e.NSiteGraphicsIdn);

            entity.ToTable("TB_SITEGRAPHICS_IMAGEINFO");

            entity.Property(e => e.NSiteGraphicsIdn)
                .ValueGeneratedNever()
                .HasColumnName("nSiteGraphicsIdn");
            entity.Property(e => e.BBgimage).HasColumnName("bBGImage");
            entity.Property(e => e.NBgimageLen).HasColumnName("nBGImageLen");
        });

        modelBuilder.Entity<TbSitegraphicsObjectinfo>(entity =>
        {
            entity.HasKey(e => e.NSiteGraphicsIdn);

            entity.ToTable("TB_SITEGRAPHICS_OBJECTINFO");

            entity.Property(e => e.NSiteGraphicsIdn)
                .ValueGeneratedNever()
                .HasColumnName("nSiteGraphicsIdn");
            entity.Property(e => e.BDoorsObject).HasColumnName("bDoorsObject");
            entity.Property(e => e.NDoorsObjectLen).HasColumnName("nDoorsObjectLen");
        });

        modelBuilder.Entity<TbTaDailyschedule>(entity =>
        {
            entity.HasKey(e => e.NDailyScheduleIdn);

            entity.ToTable("TB_TA_DAILYSCHEDULE");

            entity.Property(e => e.NDailyScheduleIdn).HasColumnName("nDailyScheduleIdn");
            entity.Property(e => e.NDateStartTime).HasColumnName("nDateStartTime");
            entity.Property(e => e.NIsFirstAndLastAuth).HasColumnName("nIsFirstAndLastAuth");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbTaDevice>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn).HasName("PK_TB_TA_DEVIC");

            entity.ToTable("TB_TA_DEVICE");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbTaDeviceEventKey>(entity =>
        {
            entity.HasKey(e => e.NDeviceEventKeyIdn);

            entity.ToTable("TB_TA_DEVICE_EVENT_KEY");

            entity.Property(e => e.NDeviceEventKeyIdn).HasColumnName("nDeviceEventKeyIdn");
            entity.Property(e => e.NIsOnlyResult).HasColumnName("nIsOnlyResult");
            entity.Property(e => e.NIsWorkTime).HasColumnName("nIsWorkTime");
            entity.Property(e => e.NKeyEvent).HasColumnName("nKeyEvent");
            entity.Property(e => e.NKeyIdn).HasColumnName("nKeyIdn");
            entity.Property(e => e.NNoLate).HasColumnName("nNoLate");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.SEventName)
                .HasMaxLength(32)
                .HasColumnName("sEventName");
        });

        modelBuilder.Entity<TbTaHolidayRule>(entity =>
        {
            entity.HasKey(e => e.NHolidayRuleIdn);

            entity.ToTable("TB_TA_HOLIDAY_RULE");

            entity.Property(e => e.NHolidayRuleIdn).HasColumnName("nHolidayRuleIdn");
            entity.Property(e => e.NDailyScheduleIdn).HasColumnName("nDailyScheduleIdn");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbTaHolidayRuleDatum>(entity =>
        {
            entity.HasKey(e => e.NHolidayRuleDataIdn);

            entity.ToTable("TB_TA_HOLIDAY_RULE_DATA");

            entity.Property(e => e.NHolidayRuleDataIdn).HasColumnName("nHolidayRuleDataIdn");
            entity.Property(e => e.NHolidayIdn).HasColumnName("nHolidayIdn");
            entity.Property(e => e.NHolidayRuleIdn).HasColumnName("nHolidayRuleIdn");
        });

        modelBuilder.Entity<TbTaLogHistory>(entity =>
        {
            entity.HasKey(e => e.NHistroryIdn);

            entity.ToTable("TB_TA_LOG_HISTORY");

            entity.Property(e => e.NHistroryIdn).HasColumnName("nHistroryIdn");
            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NFirstInTime).HasColumnName("nFirstInTime");
            entity.Property(e => e.NFlag).HasColumnName("nFlag");
            entity.Property(e => e.NLastOutTime).HasColumnName("nLastOutTime");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NTaresult).HasColumnName("nTAResult");
            entity.Property(e => e.NTimeCategoryIdn).HasColumnName("nTimeCategoryIdn");
            entity.Property(e => e.NTnaevent).HasColumnName("nTNAEvent");
            entity.Property(e => e.NUpdateTime).HasColumnName("nUpdateTime");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NWorkTime).HasColumnName("nWorkTime");
            entity.Property(e => e.SFirstInEvent)
                .HasMaxLength(16)
                .HasColumnName("sFirstInEvent");
            entity.Property(e => e.SIp)
                .HasMaxLength(32)
                .HasColumnName("sIP");
            entity.Property(e => e.SLastOutEvent)
                .HasMaxLength(16)
                .HasColumnName("sLastOutEvent");
            entity.Property(e => e.SUserId)
                .HasMaxLength(32)
                .HasColumnName("sUserID");
        });

        modelBuilder.Entity<TbTaResult>(entity =>
        {
            entity.HasKey(e => new { e.NDateTime, e.NUserIdn, e.NShiftIdn });

            entity.ToTable("TB_TA_RESULT");

            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NShiftIdn).HasColumnName("nShiftIdn");
            entity.Property(e => e.NDailyScheduleIdn).HasColumnName("nDailyScheduleIdn");
            entity.Property(e => e.NEarlyOutTime).HasColumnName("nEarlyOutTime");
            entity.Property(e => e.NEndTime).HasColumnName("nEndTime");
            entity.Property(e => e.NIsModify).HasColumnName("nIsModify");
            entity.Property(e => e.NLateInTime).HasColumnName("nLateInTime");
            entity.Property(e => e.NStartTime).HasColumnName("nStartTime");
            entity.Property(e => e.NTaresult).HasColumnName("nTAResult");
            entity.Property(e => e.NWorkTime).HasColumnName("nWorkTime");
            entity.Property(e => e.SEndEvent)
                .HasMaxLength(32)
                .HasColumnName("sEndEvent");
            entity.Property(e => e.SStartEvent)
                .HasMaxLength(32)
                .HasColumnName("sStartEvent");
        });

        modelBuilder.Entity<TbTaResultCategory>(entity =>
        {
            entity.HasKey(e => new { e.NDateTime, e.NUserIdn, e.NTimeCategoryIdn });

            entity.ToTable("TB_TA_RESULT_CATEGORY");

            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NTimeCategoryIdn).HasColumnName("nTimeCategoryIdn");
            entity.Property(e => e.NEarlyOutTime).HasColumnName("nEarlyOutTime");
            entity.Property(e => e.NIsModify).HasColumnName("nIsModify");
            entity.Property(e => e.NLateInTime).HasColumnName("nLateInTime");
            entity.Property(e => e.NTaresult).HasColumnName("nTAResult");
            entity.Property(e => e.NWorkTime).HasColumnName("nWorkTime");
        });

        modelBuilder.Entity<TbTaShift>(entity =>
        {
            entity.HasKey(e => e.NShiftIdn);

            entity.ToTable("TB_TA_SHIFT");

            entity.Property(e => e.NShiftIdn).HasColumnName("nShiftIdn");
            entity.Property(e => e.NCyclePeriod).HasColumnName("nCyclePeriod");
            entity.Property(e => e.NCycleType).HasColumnName("nCycleType");
            entity.Property(e => e.NEndTime).HasColumnName("nEndTime");
            entity.Property(e => e.NStartTime).HasColumnName("nStartTime");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbTaShiftDaily>(entity =>
        {
            entity.HasKey(e => e.NShiftDailyIdn);

            entity.ToTable("TB_TA_SHIFT_DAILY");

            entity.Property(e => e.NShiftDailyIdn).HasColumnName("nShiftDailyIdn");
            entity.Property(e => e.NDailyScheduleIdn).HasColumnName("nDailyScheduleIdn");
            entity.Property(e => e.NShiftIdn).HasColumnName("nShiftIdn");
        });

        modelBuilder.Entity<TbTaShiftHour>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_TA_SHIFT_HOURS");

            entity.Property(e => e.HoursPerDay).HasMaxLength(50);
            entity.Property(e => e.NShiftIdn).HasColumnName("nShiftIdn");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbTaShiftOverride>(entity =>
        {
            entity.HasKey(e => e.NShiftOverrideIdn);

            entity.ToTable("TB_TA_SHIFT_OVERRIDE");

            entity.Property(e => e.NShiftOverrideIdn).HasColumnName("nShiftOverrideIdn");
            entity.Property(e => e.NEndTime).HasColumnName("nEndTime");
            entity.Property(e => e.NShiftIdn).HasColumnName("nShiftIdn");
            entity.Property(e => e.NStartTime).HasColumnName("nStartTime");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
        });

        modelBuilder.Entity<TbTaTimecategory>(entity =>
        {
            entity.HasKey(e => e.NTimeCategoryIdn);

            entity.ToTable("TB_TA_TIMECATEGORY");

            entity.Property(e => e.NTimeCategoryIdn).HasColumnName("nTimeCategoryIdn");
            entity.Property(e => e.NDisplayColor).HasColumnName("nDisplayColor");
            entity.Property(e => e.NRoundingType).HasColumnName("nRoundingType");
            entity.Property(e => e.NRoundingUnit).HasColumnName("nRoundingUnit");
            entity.Property(e => e.NTimeRate).HasColumnName("nTimeRate");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbTaTimeslot>(entity =>
        {
            entity.HasKey(e => e.NTimeSlotIdn);

            entity.ToTable("TB_TA_TIMESLOT");

            entity.Property(e => e.NTimeSlotIdn).HasColumnName("nTimeSlotIdn");
            entity.Property(e => e.NAffectingResult).HasColumnName("nAffectingResult");
            entity.Property(e => e.NAutoCheckIn).HasColumnName("nAutoCheckIn");
            entity.Property(e => e.NAutoCheckOut).HasColumnName("nAutoCheckOut");
            entity.Property(e => e.NDailyScheduleIdn).HasColumnName("nDailyScheduleIdn");
            entity.Property(e => e.NEndGrace).HasColumnName("nEndGrace");
            entity.Property(e => e.NEndTime).HasColumnName("nEndTime");
            entity.Property(e => e.NInRounding).HasColumnName("nInRounding");
            entity.Property(e => e.NMinimumDuration).HasColumnName("nMinimumDuration");
            entity.Property(e => e.NMustCheckIn).HasColumnName("nMustCheckIn");
            entity.Property(e => e.NMustCheckOut).HasColumnName("nMustCheckOut");
            entity.Property(e => e.NOutRounding).HasColumnName("nOutRounding");
            entity.Property(e => e.NStartGrace).HasColumnName("nStartGrace");
            entity.Property(e => e.NStartTime).HasColumnName("nStartTime");
            entity.Property(e => e.NTimeCategoryIdn).HasColumnName("nTimeCategoryIdn");
        });

        modelBuilder.Entity<TbTaUser>(entity =>
        {
            entity.HasKey(e => e.NUserTaidn);

            entity.ToTable("TB_TA_USER");

            entity.Property(e => e.NUserTaidn).HasColumnName("nUserTAIdn");
            entity.Property(e => e.NTaidn).HasColumnName("nTAIdn");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
        });

        modelBuilder.Entity<TbTimecode>(entity =>
        {
            entity.HasKey(e => e.NTimecode);

            entity.ToTable("TB_TIMECODE");

            entity.Property(e => e.NTimecode)
                .ValueGeneratedNever()
                .HasColumnName("nTimecode");
            entity.Property(e => e.NEndTime1).HasColumnName("nEndTime1");
            entity.Property(e => e.NEndTime2).HasColumnName("nEndTime2");
            entity.Property(e => e.NEndTime3).HasColumnName("nEndTime3");
            entity.Property(e => e.NEndTime4).HasColumnName("nEndTime4");
            entity.Property(e => e.NEndTime5).HasColumnName("nEndTime5");
            entity.Property(e => e.NStartTime1).HasColumnName("nStartTime1");
            entity.Property(e => e.NStartTime2).HasColumnName("nStartTime2");
            entity.Property(e => e.NStartTime3).HasColumnName("nStartTime3");
            entity.Property(e => e.NStartTime4).HasColumnName("nStartTime4");
            entity.Property(e => e.NStartTime5).HasColumnName("nStartTime5");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sDescription");
        });

        modelBuilder.Entity<TbTimezone>(entity =>
        {
            entity.HasKey(e => e.NTimezone);

            entity.ToTable("TB_TIMEZONE");

            entity.Property(e => e.NTimezone)
                .ValueGeneratedNever()
                .HasColumnName("nTimezone");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbTimezoneDay>(entity =>
        {
            entity.HasKey(e => new { e.NTimezone, e.NDay }).HasName("PK_TB_TIEMZONE_DAY");

            entity.ToTable("TB_TIMEZONE_DAY");

            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
            entity.Property(e => e.NDay).HasColumnName("nDay");
            entity.Property(e => e.NHolidayIdn).HasColumnName("nHolidayIdn");
            entity.Property(e => e.NTimecode).HasColumnName("nTimecode");
        });

        modelBuilder.Entity<TbTraceAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_TRACE_ADMIN");

            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NLogIdn)
                .ValueGeneratedOnAdd()
                .HasColumnName("nLogIdn");
            entity.Property(e => e.NPrivilegeIdn).HasColumnName("nPrivilegeIdn");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.SAccessType)
                .HasMaxLength(32)
                .HasColumnName("sAccessType");
            entity.Property(e => e.SAdminId)
                .HasMaxLength(64)
                .HasColumnName("sAdminID");
            entity.Property(e => e.SAdminIp)
                .HasMaxLength(32)
                .HasColumnName("sAdminIP");
            entity.Property(e => e.SPassword)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("sPassword");
            entity.Property(e => e.SUserId)
                .HasMaxLength(64)
                .HasColumnName("sUserID");
        });

        modelBuilder.Entity<TbTraceTpl>(entity =>
        {
            entity.HasKey(e => e.NTraceTplIdn);

            entity.ToTable("TB_TRACE_TPL");

            entity.Property(e => e.NTraceTplIdn).HasColumnName("nTraceTplIdn");
            entity.Property(e => e.BData).HasColumnName("bData");
            entity.Property(e => e.NDataLen).HasColumnName("nDataLen");
            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NType).HasColumnName("nType");
        });

        modelBuilder.Entity<TbTraceUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_TRACE_USER");

            entity.Property(e => e.NAdminLevel).HasColumnName("nAdminLevel");
            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NEndDate).HasColumnName("nEndDate");
            entity.Property(e => e.NLogIdn)
                .ValueGeneratedOnAdd()
                .HasColumnName("nLogIdn");
            entity.Property(e => e.NStartDate).HasColumnName("nStartDate");
            entity.Property(e => e.SAccessType)
                .HasMaxLength(32)
                .HasColumnName("sAccessType");
            entity.Property(e => e.SAdminId)
                .HasMaxLength(64)
                .HasColumnName("sAdminID");
            entity.Property(e => e.SAdminIp)
                .HasMaxLength(32)
                .HasColumnName("sAdminIP");
            entity.Property(e => e.SDepartment)
                .HasMaxLength(64)
                .HasColumnName("sDepartment");
            entity.Property(e => e.SEmail)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("sEmail");
            entity.Property(e => e.SPassword)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("sPassword");
            entity.Property(e => e.STelNumber)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("sTelNumber");
            entity.Property(e => e.SUserId)
                .HasMaxLength(32)
                .HasColumnName("sUserID");
            entity.Property(e => e.SUserName)
                .HasMaxLength(48)
                .IsFixedLength()
                .HasColumnName("sUserName");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.NUserIdn).HasName("PK_TB_USERINFO");

            entity.ToTable("TB_USER");

            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.BPassword2)
                .HasMaxLength(32)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("bPassword2");
            entity.Property(e => e.NAdminLevel)
                .HasDefaultValue(241)
                .HasColumnName("nAdminLevel");
            entity.Property(e => e.NAuthLimitCount).HasColumnName("nAuthLimitCount");
            entity.Property(e => e.NAuthMode).HasColumnName("nAuthMode");
            entity.Property(e => e.NDepartmentIdn).HasColumnName("nDepartmentIdn");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.NEndDate).HasColumnName("nEndDate");
            entity.Property(e => e.NStartDate).HasColumnName("nStartDate");
            entity.Property(e => e.NTimedApb).HasColumnName("nTimedAPB");
            entity.Property(e => e.SEmail)
                .HasMaxLength(100)
                .HasDefaultValue("")
                .HasColumnName("sEmail");
            entity.Property(e => e.SPassword)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("sPassword");
            entity.Property(e => e.STelNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sTelNumber");
            entity.Property(e => e.SUserId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sUserID");
            entity.Property(e => e.SUserName)
                .HasMaxLength(96)
                .HasColumnName("sUserName");
        });

        modelBuilder.Entity<TbUserAc>(entity =>
        {
            entity.HasKey(e => new { e.NUserIdn, e.NDoorIdn }).HasName("PK_TB_ACCESS_USER");

            entity.ToTable("TB_USER_AC");

            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NDoorIdn).HasColumnName("nDoorIdn");
            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
        });

        modelBuilder.Entity<TbUserCard>(entity =>
        {
            entity.HasKey(e => e.NCardIdn);

            entity.ToTable("TB_USER_CARD");

            entity.Property(e => e.NCardIdn).HasColumnName("nCardIdn");
            entity.Property(e => e.NBypass).HasColumnName("nBypass");
            entity.Property(e => e.NDateTime).HasColumnName("nDateTime");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.NExpiryDateTime).HasColumnName("nExpiryDateTime");
            entity.Property(e => e.NLatest).HasColumnName("nLatest");
            entity.Property(e => e.NSecurityLevel).HasColumnName("nSecurityLevel");
            entity.Property(e => e.NStatus).HasColumnName("nStatus");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NV2cardType).HasColumnName("nV2CardType");
            entity.Property(e => e.SCardNo)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("sCardNo");
            entity.Property(e => e.SCustomNo)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("sCustomNo");
        });

        modelBuilder.Entity<TbUserCustomfield>(entity =>
        {
            entity.HasKey(e => e.NFieldIdn).HasName("PK_TB_CUSTOMFIELD");

            entity.ToTable("TB_USER_CUSTOMFIELD");

            entity.Property(e => e.NFieldIdn)
                .ValueGeneratedNever()
                .HasColumnName("nFieldIdn");
            entity.Property(e => e.NDataType).HasColumnName("nDataType");
            entity.Property(e => e.NEssential).HasColumnName("nEssential");
            entity.Property(e => e.NFieldType).HasColumnName("nFieldType");
            entity.Property(e => e.NValueIdn).HasColumnName("nValueIdn");
            entity.Property(e => e.SData)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sData");
            entity.Property(e => e.SFieldName)
                .HasMaxLength(32)
                .HasColumnName("sFieldName");
        });

        modelBuilder.Entity<TbUserCustominfo>(entity =>
        {
            entity.HasKey(e => e.NUserIdn).HasName("PK_TB_USERINFO_CUSTOM");

            entity.ToTable("TB_USER_CUSTOMINFO");

            entity.Property(e => e.NUserIdn)
                .ValueGeneratedNever()
                .HasColumnName("nUserIdn");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.SFieldValue1)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue1");
            entity.Property(e => e.SFieldValue10)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue10");
            entity.Property(e => e.SFieldValue11)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue11");
            entity.Property(e => e.SFieldValue12)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue12");
            entity.Property(e => e.SFieldValue13)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue13");
            entity.Property(e => e.SFieldValue14)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue14");
            entity.Property(e => e.SFieldValue15)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue15");
            entity.Property(e => e.SFieldValue16)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue16");
            entity.Property(e => e.SFieldValue17)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue17");
            entity.Property(e => e.SFieldValue18)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue18");
            entity.Property(e => e.SFieldValue19)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue19");
            entity.Property(e => e.SFieldValue2)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue2");
            entity.Property(e => e.SFieldValue20)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue20");
            entity.Property(e => e.SFieldValue3)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue3");
            entity.Property(e => e.SFieldValue4)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue4");
            entity.Property(e => e.SFieldValue5)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue5");
            entity.Property(e => e.SFieldValue6)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue6");
            entity.Property(e => e.SFieldValue7)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue7");
            entity.Property(e => e.SFieldValue8)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue8");
            entity.Property(e => e.SFieldValue9)
                .HasMaxLength(128)
                .HasColumnName("sFieldValue9");
        });

        modelBuilder.Entity<TbUserDept>(entity =>
        {
            entity.HasKey(e => e.NDepartmentIdn);

            entity.ToTable("TB_USER_DEPT");

            entity.Property(e => e.NDepartmentIdn).HasColumnName("nDepartmentIdn");
            entity.Property(e => e.NDepth).HasColumnName("nDepth");
            entity.Property(e => e.NParentIdn).HasColumnName("nParentIdn");
            entity.Property(e => e.SDepartment)
                .HasMaxLength(255)
                .HasColumnName("sDepartment");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbUserDevice>(entity =>
        {
            entity.HasKey(e => e.NUserDeviceIdn);

            entity.ToTable("TB_USER_DEVICE");

            entity.Property(e => e.NUserDeviceIdn).HasColumnName("nUserDeviceIdn");
            entity.Property(e => e.NDeviceId).HasColumnName("nDeviceID");
            entity.Property(e => e.NIsDelete).HasColumnName("nIsDelete");
            entity.Property(e => e.NIsUpdated).HasColumnName("nIsUpdated");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
        });

        modelBuilder.Entity<TbUserEx>(entity =>
        {
            entity.HasKey(e => e.NUserIdn);

            entity.ToTable("TB_USER_EX");

            entity.Property(e => e.NUserIdn)
                .ValueGeneratedNever()
                .HasColumnName("nUserIdn");
            entity.Property(e => e.NCountPerDay).HasColumnName("nCountPerDay");
            entity.Property(e => e.NDuration).HasColumnName("nDuration");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.NImageSize).HasColumnName("nImageSize");
            entity.Property(e => e.NUsePrivateImage).HasColumnName("nUsePrivateImage");
            entity.Property(e => e.SFirstName)
                .HasMaxLength(64)
                .HasDefaultValue("")
                .HasColumnName("sFirstName");
            entity.Property(e => e.SGreetingMsg)
                .HasMaxLength(64)
                .HasDefaultValue("")
                .HasColumnName("sGreetingMsg");
            entity.Property(e => e.SImageFilePath)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sImageFilePath");
            entity.Property(e => e.SMiddleName)
                .HasMaxLength(64)
                .HasDefaultValue("")
                .HasColumnName("sMiddleName");
            entity.Property(e => e.SSurName)
                .HasMaxLength(64)
                .HasColumnName("sSurName");
        });

        modelBuilder.Entity<TbUserFace>(entity =>
        {
            entity.HasKey(e => new { e.NUserIdn, e.NIndex });

            entity.ToTable("TB_USER_FACE");

            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NIndex).HasColumnName("nIndex");
            entity.Property(e => e.BImage).HasColumnName("bImage");
            entity.Property(e => e.BTemplate)
                .HasMaxLength(2284)
                .IsFixedLength()
                .HasColumnName("bTemplate");
            entity.Property(e => e.NAuthLimitCount).HasColumnName("nAuthLimitCount");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.NImageLen).HasColumnName("nImageLen");
            entity.Property(e => e.NSecurityLevel).HasColumnName("nSecurityLevel");
            entity.Property(e => e.NTemplatecs).HasColumnName("nTemplatecs");
        });

        modelBuilder.Entity<TbUserFaceRaw>(entity =>
        {
            entity.HasKey(e => new { e.NUserIdn, e.NType, e.NIndex });

            entity.ToTable("TB_USER_FACE_RAW");

            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NType)
                .HasDefaultValue(1)
                .HasColumnName("nType");
            entity.Property(e => e.NIndex).HasColumnName("nIndex");
            entity.Property(e => e.BTemplate).HasColumnName("bTemplate");
            entity.Property(e => e.NTemplateLen).HasColumnName("nTemplateLen");
        });

        modelBuilder.Entity<TbUserFaceStillcut>(entity =>
        {
            entity.HasKey(e => new { e.NUserIdn, e.NType });

            entity.ToTable("TB_USER_FACE_STILLCUT");

            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.BImage).HasColumnName("bImage");
            entity.Property(e => e.NImageLen).HasColumnName("nImageLen");
        });

        modelBuilder.Entity<TbUserFaceTemplate>(entity =>
        {
            entity.HasKey(e => new { e.NUserIdn, e.NType, e.NIndex });

            entity.ToTable("TB_USER_FACE_TEMPLATE");

            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NType)
                .HasDefaultValue(1)
                .HasColumnName("nType");
            entity.Property(e => e.NIndex).HasColumnName("nIndex");
            entity.Property(e => e.BTemplate).HasColumnName("bTemplate");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.NTemplateLen).HasColumnName("nTemplateLen");
            entity.Property(e => e.NTemplatecs).HasColumnName("nTemplatecs");
            entity.Property(e => e.NUpdateIndex).HasColumnName("nUpdateIndex");
            entity.Property(e => e.NUpdated).HasColumnName("nUpdated");
        });

        modelBuilder.Entity<TbUserTemplate>(entity =>
        {
            entity.HasKey(e => new { e.NUserIdn, e.NIndex, e.NTemplateIndex });

            entity.ToTable("TB_USER_TEMPLATE");

            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NIndex).HasColumnName("nIndex");
            entity.Property(e => e.NTemplateIndex).HasColumnName("nTemplateIndex");
            entity.Property(e => e.BTemplate)
                .HasMaxLength(384)
                .IsFixedLength()
                .HasColumnName("bTemplate");
            entity.Property(e => e.NDuress).HasColumnName("nDuress");
            entity.Property(e => e.NEncryption).HasColumnName("nEncryption");
            entity.Property(e => e.NEnrollQuality).HasColumnName("nEnrollQuality");
            entity.Property(e => e.NFingerIndex).HasColumnName("nFingerIndex");
            entity.Property(e => e.NSecurityLevel).HasColumnName("nSecurityLevel");
            entity.Property(e => e.NTemplatecs).HasColumnName("nTemplatecs");
        });

        modelBuilder.Entity<TbUserUpdate>(entity =>
        {
            entity.HasKey(e => new { e.NUserIdn, e.NDeviceId });

            entity.ToTable("TB_USER_UPDATE");

            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NDeviceId).HasColumnName("nDeviceID");
            entity.Property(e => e.NDeviceUpdate).HasColumnName("nDeviceUpdate");
            entity.Property(e => e.NUserUpdateIdn)
                .ValueGeneratedOnAdd()
                .HasColumnName("nUserUpdateIdn");
        });

        modelBuilder.Entity<TbV2readerStatus>(entity =>
        {
            entity.HasKey(e => e.NReaderIdn);

            entity.ToTable("TB_V2READER_STATUS");

            entity.Property(e => e.NReaderIdn)
                .ValueGeneratedNever()
                .HasColumnName("nReaderIdn");
            entity.Property(e => e.NReserved).HasColumnName("nReserved");
            entity.Property(e => e.NStatus).HasColumnName("nStatus");
        });

        modelBuilder.Entity<TbZone>(entity =>
        {
            entity.HasKey(e => e.NZoneIdn);

            entity.ToTable("TB_ZONE");

            entity.Property(e => e.NZoneIdn).HasColumnName("nZoneIdn");
            entity.Property(e => e.NAttribute).HasColumnName("nAttribute");
            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.SDescription)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbZoneAccesszone>(entity =>
        {
            entity.HasKey(e => e.NZoneIdn);

            entity.ToTable("TB_ZONE_ACCESSZONE");

            entity.Property(e => e.NZoneIdn)
                .ValueGeneratedNever()
                .HasColumnName("nZoneIdn");
            entity.Property(e => e.NSyncLog).HasColumnName("nSyncLog");
            entity.Property(e => e.NSyncTime).HasColumnName("nSyncTime");
            entity.Property(e => e.NSyncUser).HasColumnName("nSyncUser");
        });

        modelBuilder.Entity<TbZoneAlarm>(entity =>
        {
            entity.HasKey(e => e.NZoneIdn);

            entity.ToTable("TB_ZONE_ALARM");

            entity.Property(e => e.NZoneIdn)
                .ValueGeneratedNever()
                .HasColumnName("nZoneIdn");
            entity.Property(e => e.NInputEvent).HasColumnName("nInputEvent");
            entity.Property(e => e.NOutputEvent).HasColumnName("nOutputEvent");
        });

        modelBuilder.Entity<TbZoneAlarmzone>(entity =>
        {
            entity.HasKey(e => e.NZoneIdn);

            entity.ToTable("TB_ZONE_ALARMZONE");

            entity.Property(e => e.NZoneIdn)
                .ValueGeneratedNever()
                .HasColumnName("nZoneIdn");
            entity.Property(e => e.NArmCardId).HasColumnName("nArmCardID");
            entity.Property(e => e.NArmCustomId).HasColumnName("nArmCustomID");
            entity.Property(e => e.NArmKey).HasColumnName("nArmKey");
            entity.Property(e => e.NDisarmCardId).HasColumnName("nDisarmCardID");
            entity.Property(e => e.NDisarmCustomId).HasColumnName("nDisarmCustomID");
            entity.Property(e => e.NDisarmKey).HasColumnName("nDisarmKey");
            entity.Property(e => e.NLockDelayTime)
                .HasDefaultValue(15)
                .HasColumnName("nLockDelayTime");
            entity.Property(e => e.NSoundStatus).HasColumnName("nSoundStatus");
            entity.Property(e => e.NStatus).HasColumnName("nStatus");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.NUnlockDelayTime)
                .HasDefaultValue(15)
                .HasColumnName("nUnlockDelayTime");
        });

        modelBuilder.Entity<TbZoneApbzone>(entity =>
        {
            entity.HasKey(e => e.NZoneIdn);

            entity.ToTable("TB_ZONE_APBZONE");

            entity.Property(e => e.NZoneIdn)
                .ValueGeneratedNever()
                .HasColumnName("nZoneIdn");
            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.NUnlockTime).HasColumnName("nUnlockTime");
        });

        modelBuilder.Entity<TbZoneCard>(entity =>
        {
            entity.HasKey(e => e.NZoneCardIdn);

            entity.ToTable("TB_ZONE_CARD");

            entity.Property(e => e.NZoneCardIdn).HasColumnName("nZoneCardIdn");
            entity.Property(e => e.NCardId).HasColumnName("nCardID");
            entity.Property(e => e.NCustomId).HasColumnName("nCustomID");
            entity.Property(e => e.NZoneIdn).HasColumnName("nZoneIdn");
        });

        modelBuilder.Entity<TbZoneControl>(entity =>
        {
            entity.HasKey(e => new { e.NZoneIdn, e.NUserIdn });

            entity.ToTable("TB_ZONE_CONTROL");

            entity.Property(e => e.NZoneIdn).HasColumnName("nZoneIdn");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.NFlag).HasColumnName("nFlag");
            entity.Property(e => e.NNumOfEntrance).HasColumnName("nNumOfEntrance");
            entity.Property(e => e.NTime).HasColumnName("nTime");
        });

        modelBuilder.Entity<TbZoneDoor>(entity =>
        {
            entity.HasKey(e => e.NZoneDoorIdn);

            entity.ToTable("TB_ZONE_DOOR");

            entity.Property(e => e.NZoneDoorIdn).HasColumnName("nZoneDoorIdn");
            entity.Property(e => e.NDoorDept).HasColumnName("nDoorDept");
            entity.Property(e => e.NDoorIdn).HasColumnName("nDoorIdn");
            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
            entity.Property(e => e.NZoneIdn).HasColumnName("nZoneIdn");
        });

        modelBuilder.Entity<TbZoneElzone>(entity =>
        {
            entity.HasKey(e => e.NZoneIdn);

            entity.ToTable("TB_ZONE_ELZONE");

            entity.Property(e => e.NZoneIdn)
                .ValueGeneratedNever()
                .HasColumnName("nZoneIdn");
            entity.Property(e => e.NEndTime1).HasColumnName("nEndTime1");
            entity.Property(e => e.NEndTime2).HasColumnName("nEndTime2");
            entity.Property(e => e.NEndTime3).HasColumnName("nEndTime3");
            entity.Property(e => e.NEndTime4).HasColumnName("nEndTime4");
            entity.Property(e => e.NLimitNumber1).HasColumnName("nLimitNumber1");
            entity.Property(e => e.NLimitNumber2).HasColumnName("nLimitNumber2");
            entity.Property(e => e.NLimitNumber3).HasColumnName("nLimitNumber3");
            entity.Property(e => e.NLimitNumber4).HasColumnName("nLimitNumber4");
            entity.Property(e => e.NLimitTime).HasColumnName("nLimitTime");
            entity.Property(e => e.NStartTime1).HasColumnName("nStartTime1");
            entity.Property(e => e.NStartTime2).HasColumnName("nStartTime2");
            entity.Property(e => e.NStartTime3).HasColumnName("nStartTime3");
            entity.Property(e => e.NStartTime4).HasColumnName("nStartTime4");
            entity.Property(e => e.NTimezone).HasColumnName("nTimezone");
        });

        modelBuilder.Entity<TbZoneFirezone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_ZONE_FIREZONE");

            entity.Property(e => e.NType).HasColumnName("nType");
            entity.Property(e => e.NZoneIdn).HasColumnName("nZoneIdn");
        });

        modelBuilder.Entity<TbZoneInput>(entity =>
        {
            entity.HasKey(e => new { e.NZoneIdn, e.NReaderIoidn }).HasName("PK_TB_ZONE_IO");

            entity.ToTable("TB_ZONE_INPUT");

            entity.Property(e => e.NZoneIdn).HasColumnName("nZoneIdn");
            entity.Property(e => e.NReaderIoidn).HasColumnName("nReaderIOIdn");
            entity.Property(e => e.NInputFlag).HasColumnName("nInputFlag");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<TbZoneMusterzone>(entity =>
        {
            entity.HasKey(e => e.NZoneIdn);

            entity.ToTable("TB_ZONE_MUSTERZONE");

            entity.Property(e => e.NZoneIdn)
                .ValueGeneratedNever()
                .HasColumnName("nZoneIdn");
            entity.Property(e => e.NTimeZone).HasColumnName("nTimeZone");
            entity.Property(e => e.NTrackingTime).HasColumnName("nTrackingTime");
            entity.Property(e => e.NType).HasColumnName("nType");
        });

        modelBuilder.Entity<TbZoneOutput>(entity =>
        {
            entity.HasKey(e => new { e.NZoneIdn, e.NReaderIoidn });

            entity.ToTable("TB_ZONE_OUTPUT");

            entity.Property(e => e.NZoneIdn).HasColumnName("nZoneIdn");
            entity.Property(e => e.NReaderIoidn).HasColumnName("nReaderIOIdn");
            entity.Property(e => e.NOutputFlag).HasColumnName("nOutputFlag");
        });

        modelBuilder.Entity<TbZoneReader>(entity =>
        {
            entity.HasKey(e => new { e.NZoneIdn, e.NReaderIdn });

            entity.ToTable("TB_ZONE_READER");

            entity.Property(e => e.NZoneIdn).HasColumnName("nZoneIdn");
            entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");
            entity.Property(e => e.NAttribute).HasColumnName("nAttribute");
            entity.Property(e => e.NAttribute2).HasColumnName("nAttribute2");
            entity.Property(e => e.NNodeType).HasColumnName("nNodeType");
        });

        modelBuilder.Entity<ViewDeptEmpCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Dept_emp_count");

            entity.Property(e => e.EmpCount).HasColumnName("emp_count");
            entity.Property(e => e.NDepartmentIdn).HasColumnName("nDepartmentIdn");
            entity.Property(e => e.SDepartment)
                .HasMaxLength(255)
                .HasColumnName("sDepartment");
        });

        modelBuilder.Entity<ViewLogDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LogData");

            entity.Property(e => e.NEventIdn).HasColumnName("nEventIdn");
            entity.Property(e => e.NUserId).HasColumnName("nUserID");
            entity.Property(e => e.SLogTime)
                .HasMaxLength(32)
                .HasColumnName("sLogTime");
            entity.Property(e => e.SName)
                .HasMaxLength(64)
                .HasColumnName("sName");
        });

        modelBuilder.Entity<ViewNotEnrolledEmpDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Not_enrolled_emp_dept");

            entity.Property(e => e.CountEmps).HasColumnName("Count_emps");
            entity.Property(e => e.NDepartmentIdn).HasColumnName("nDepartmentIdn");
            entity.Property(e => e.SDepartment)
                .HasMaxLength(255)
                .HasColumnName("sDepartment");
        });

        modelBuilder.Entity<ViewNotEnrolledEmployess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Not_Enrolled_Employess");

            entity.Property(e => e.BTemplate)
                .HasMaxLength(384)
                .IsFixedLength()
                .HasColumnName("bTemplate");
            entity.Property(e => e.Position).HasMaxLength(64);
            entity.Property(e => e.SDepartment)
                .HasMaxLength(255)
                .HasColumnName("sDepartment");
            entity.Property(e => e.SUserId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sUserID");
            entity.Property(e => e.SUserName)
                .HasMaxLength(32)
                .HasColumnName("sUserName");
        });

        modelBuilder.Entity<ViewTbTaResultModified>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TB_TA_RESULT_Modified");

            entity.Property(e => e.HoursPerDay).HasMaxLength(50);
            entity.Property(e => e.MDateTime)
                .HasColumnType("datetime")
                .HasColumnName("mDateTime");
            entity.Property(e => e.MEarlyOutTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mEarlyOutTime");
            entity.Property(e => e.MEndTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mEndTime");
            entity.Property(e => e.MHoursPerDay)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("mHoursPerDay");
            entity.Property(e => e.MLateInTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mLateInTime");
            entity.Property(e => e.MStartTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mStartTime");
            entity.Property(e => e.MWorkTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mWorkTime");
            entity.Property(e => e.NIsModify).HasColumnName("nIsModify");
            entity.Property(e => e.NShiftIdn).HasColumnName("nShiftIdn");
            entity.Property(e => e.NTaresult).HasColumnName("nTAResult");
            entity.Property(e => e.NUserIdn).HasColumnName("nUserIdn");
            entity.Property(e => e.SDepartment)
                .HasMaxLength(255)
                .HasColumnName("sDepartment");
            entity.Property(e => e.SUserId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sUserID");
            entity.Property(e => e.SUserName)
                .HasMaxLength(32)
                .HasColumnName("sUserName");
            entity.Property(e => e.ShiftHr).HasMaxLength(2);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
