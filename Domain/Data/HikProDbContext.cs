using System;
using System.Collections.Generic;
using Domain.HikProModels;
using Microsoft.EntityFrameworkCore;

namespace Domain.Data;

public partial class HikProDbContext : DbContext
{
    public HikProDbContext()
    {
    }

    public HikProDbContext(DbContextOptions<HikProDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessLog> AccessLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=phc-taacs-proddb.cqpw79y6zq7h.me-south-1.rds.amazonaws.com;Database=hikpro;Username=hikpro;Password=hikpro");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccessLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("access_logs");

            entity.Property(e => e.AccessDate).HasColumnName("ACCESS_DATE");
            entity.Property(e => e.AccessDateTime).HasColumnName("ACCESS_DATE_TIME");
            entity.Property(e => e.AccessTime).HasColumnName("ACCESS_TIME");
            entity.Property(e => e.DevName)
                .HasMaxLength(255)
                .HasColumnName("DEV_NAME");
            entity.Property(e => e.DevSn)
                .HasMaxLength(100)
                .HasColumnName("DEV_SN");
            entity.Property(e => e.EmpFirstName)
                .HasMaxLength(255)
                .HasColumnName("EMP_FIRST_NAME");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.EmpLastName)
                .HasMaxLength(255)
                .HasColumnName("EMP_LAST_NAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
