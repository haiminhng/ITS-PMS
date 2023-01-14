namespace Models.Models;

public partial class Antragsteuerung
{
    public DateTime? AntragStartzeit { get; set; }

    public DateTime? AntragEndzeit { get; set; }

    public DateTime? MietBeginn { get; set; }

    public DateTime? MietEnde { get; set; }

    public bool? IsActive { get; set; }

    public int? AnzahlMax { get; set; }

    public int? AnzahlGenehmigt { get; set; }

    public int? AnzahlAbgelehnt { get; set; }

    public DateTime? NexteStartzeit { get; set; }
}
