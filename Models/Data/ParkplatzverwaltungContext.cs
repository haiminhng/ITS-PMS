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

    public virtual DbSet<Antragsteuerung> Antragsteuerungs { get; set; }

    public virtual DbSet<Genehmigtstatus> Genehmigtstatuses { get; set; }

    public virtual DbSet<Parkplatzantrag> Parkplatzantrags { get; set; }

    public virtual DbSet<Schueler> Schuelers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=130.61.200.85;Database=Parkplatzverwaltung;Persist Security Info=True;TrustServerCertificate=True;User ID=sa;Password=Minh@1996");

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

        modelBuilder.Entity<Antragsteuerung>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("antragsteuerung");

            entity.Property(e => e.AntragEndzeit)
                .HasColumnType("date")
                .HasColumnName("antrag_endzeit");
            entity.Property(e => e.AntragStartzeit)
                .HasColumnType("date")
                .HasColumnName("antrag_startzeit");
            entity.Property(e => e.AnzahlAbgelehnt).HasColumnName("anzahl_abgelehnt");
            entity.Property(e => e.AnzahlGenehmigt).HasColumnName("anzahl_genehmigt");
            entity.Property(e => e.AnzahlMax).HasColumnName("anzahl_max");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MietBeginn)
                .HasColumnType("date")
                .HasColumnName("miet_beginn");
            entity.Property(e => e.MietEnde)
                .HasColumnType("date")
                .HasColumnName("miet_ende");
            entity.Property(e => e.NexteStartzeit)
                .HasColumnType("date")
                .HasColumnName("nexte_startzeit");
        });

        modelBuilder.Entity<Genehmigtstatus>(entity =>
        {
            entity.HasKey(e => e.Wert).HasName("PK__genehmig__1110996E7DEFED05");

            entity.ToTable("genehmigtstatus");

            entity.Property(e => e.Wert)
                .ValueGeneratedNever()
                .HasColumnName("wert");
            entity.Property(e => e.Beschreibung)
                .HasMaxLength(50)
                .HasColumnName("beschreibung");
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
            entity.Property(e => e.EntfernungKm).HasColumnName("entfernung_km");
            entity.Property(e => e.Fahrzeit).HasColumnName("fahrzeit");
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
            entity.Property(e => e.Punkte).HasColumnName("punkte");
            entity.Property(e => e.Reisezeit).HasColumnName("reisezeit");
            entity.Property(e => e.SchuelerId).HasColumnName("schueler_id");

            entity.HasOne(d => d.GenehmigtNavigation).WithMany(p => p.Parkplatzantrags)
                .HasForeignKey(d => d.Genehmigt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("genehmigt_fk");

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
