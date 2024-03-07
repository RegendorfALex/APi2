using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API;

public partial class MedBaseContext : DbContext
{
    public MedBaseContext()
    {
    }

    public MedBaseContext(DbContextOptions<MedBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Diagnosis> Diagnoses { get; set; }

    public virtual DbSet<Gospitalisation> Gospitalisations { get; set; }

    public virtual DbSet<MedCard> MedCards { get; set; }

    public virtual DbSet<Pacient> Pacients { get; set; }

    public virtual DbSet<Procedur> Procedurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlServer("Data Source = 314-13; Initial Catalog = MedBase; Integrated Security = true; encrypt = false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Diagnosis>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdPacient).HasColumnName("idPacient");
            entity.Property(e => e.NameDiagnose)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.TypeDiagnose)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Gospitalisation>(entity =>
        {
            entity.ToTable("Gospitalisation");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Diagnos)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PolisCompany)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PolisEnd).HasColumnType("smalldatetime");
            entity.Property(e => e.PolisNumber)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.PolisStart).HasColumnType("smalldatetime");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsFixedLength();
        });

        modelBuilder.Entity<MedCard>(entity =>
        {
            entity.ToTable("MedCard");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdPacient).HasColumnName("idPacient");
            entity.Property(e => e.PolisCompany)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PolisNumber)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.PolisStart).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Pacient>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateBorn).HasColumnType("smalldatetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.F)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.I)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Job)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.O)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PasportAdres)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PasportSeria)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Phone)
                .HasMaxLength(13)
                .IsFixedLength();
        });

        modelBuilder.Entity<Procedur>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Doctor)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.IdPacient).HasColumnName("idPacient");
            entity.Property(e => e.Procedure)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.TypeProcedure)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
