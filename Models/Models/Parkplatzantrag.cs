using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Models.Models;

public partial class Parkplatzantrag
{
    public int ParkplatzantragsId { get; set; }

    public string? KfzKennzeichen { get; set; }

    public double? EntfernungKm { get; set; }

    public bool? Besonderefall { get; set; }

    public string? Grund { get; set; }

    public bool? Mitfahrgelegenheit { get; set; }

    public string? Moeglichkeit { get; set; }

    public DateTime? Antragsdatum { get; set; }

    public bool? Genehmigt { get; set; }

    public TimeSpan? Fahrzeit { get; set; }

    public int? SchuelerId { get; set; }

    public TimeSpan? Antragszeit { get; set; }

    public virtual Schueler? Schueler { get; set; }

}
