namespace Models.Models;

public partial class Schueler
{
    public int SchuelerId { get; set; }

    public string? Vorname { get; set; }

    public string? Nachname { get; set; }

    public string? Email { get; set; }

    public string? KlassenName { get; set; }

    public virtual Adressen? Adressen { get; set; }

    public virtual Parkplatzantrag? Parkplatzantrag { get; set; }
}
