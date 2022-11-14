using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Adressen
{
    public short AdresseId { get; set; }

    public string? Strasse { get; set; }

    public string? Hausnr { get; set; }

    public int? Plz { get; set; }

    public string? Ort { get; set; }

    public string? Land { get; set; }

    public int? SchuelerId { get; set; }

    public virtual Schueler? Schueler { get; set; }
}
