using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace Models.Data;

public partial class ParkplatzverwaltungContext : DbContext
{
    public ParkplatzverwaltungContext()
    {
    }

    public ParkplatzverwaltungContext(DbContextOptions<ParkplatzverwaltungContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adressen> Adressens { get; set; }

    public virtual DbSet<Parkplatzantrag> Parkplatzantrags { get; set; }

    public virtual DbSet<Schueler> Schuelers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=130.61.200.85;Initial Catalog=Parkplatzverwaltung;Persist Security Info=True;TrustServerCertificate=True;User ID=sa;Password=Minh@1996");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adressen>(entity =>
        {
            entity.HasKey(e => e.AdresseId);

            entity.ToTable("adressen");

            entity.HasIndex(e => e.SchuelerId, "IX_adressen_schueler_id")
                .IsUnique()
                .HasFilter("([schueler_id] IS NOT NULL)");

            entity.HasIndex(e => e.SchuelerId, "IX_adressen_schueler_id1");

            entity.Property(e => e.AdresseId)
                .ValueGeneratedNever()
                .HasColumnName("adresse_id");
            entity.Property(e => e.Hausnr)
                .HasMaxLength(50)
                .HasColumnName("hausnr");
            entity.Property(e => e.Land)
                .HasMaxLength(50)
                .HasColumnName("land");
            entity.Property(e => e.Ort)
                .HasMaxLength(50)
                .HasColumnName("ort");
            entity.Property(e => e.Plz).HasColumnName("plz");
            entity.Property(e => e.SchuelerId).HasColumnName("schueler_id");
            entity.Property(e => e.Strasse)
                .HasMaxLength(50)
                .HasColumnName("strasse");

            entity.HasOne(d => d.Schueler).WithOne(p => p.Adressen)
                .HasForeignKey<Adressen>(d => d.SchuelerId)
                .HasConstraintName("adresse_schueler_null_fk");
        });

        modelBuilder.Entity<Parkplatzantrag>(entity =>
        {
            entity.HasKey(e => e.ParkplatzantragsId).HasName("parkplatzantrag_pk");

            entity.ToTable("parkplatzantrag");

            entity.HasIndex(e => e.SchuelerId, "IX_parkplatzantrag_schueler_id")
                .IsUnique()
                .HasFilter("([schueler_id] IS NOT NULL)");

            entity.Property(e => e.ParkplatzantragsId)
                .ValueGeneratedNever()
                .HasColumnName("parkplatzantrags_id");
            entity.Property(e => e.Antragsdatum)
                .HasColumnType("date")
                .HasColumnName("antragsdatum");
            entity.Property(e => e.Antragszeit).HasColumnName("antragszeit");
            entity.Property(e => e.Besonderefall).HasColumnName("besonderefall");
            entity.Property(e => e.EntfernungKm)
                .HasMaxLength(20)
                .HasColumnName("entfernung_km");
            entity.Property(e => e.Fahrzeit)
                .HasMaxLength(50)
                .HasColumnName("fahrzeit");
            entity.Property(e => e.Genehmigt).HasColumnName("genehmigt");
            entity.Property(e => e.Grund)
                .HasMaxLength(120)
                .HasColumnName("grund");
            entity.Property(e => e.KfzKennzeichen)
                .HasMaxLength(60)
                .HasColumnName("kfz_kennzeichen");
            entity.Property(e => e.Mitfahrgelegenheit).HasColumnName("mitfahrgelegenheit");
            entity.Property(e => e.Moeglichkeit)
                .HasMaxLength(120)
                .HasColumnName("moeglichkeit");
            entity.Property(e => e.SchuelerId).HasColumnName("schueler_id");

            entity.HasOne(d => d.Schueler).WithOne(p => p.Parkplatzantrag)
                .HasForeignKey<Parkplatzantrag>(d => d.SchuelerId)
                .HasConstraintName("parkplatzantrag_schueler_null_fk");
        });

        modelBuilder.Entity<Schueler>(entity =>
        {
            entity.ToTable("schueler");

            entity.Property(e => e.SchuelerId)
                .ValueGeneratedNever()
                .HasColumnName("schueler_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.KlassenName)
                .HasMaxLength(10)
                .HasColumnName("klassen_name");
            entity.Property(e => e.Nachname)
                .HasMaxLength(50)
                .HasColumnName("nachname");
            entity.Property(e => e.Vorname)
                .HasMaxLength(50)
                .HasColumnName("vorname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
