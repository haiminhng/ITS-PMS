using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Genehmigtstatus
{
    public int Wert { get; set; }

    public string Beschreibung { get; set; } = null!;

    public virtual ICollection<Parkplatzantrag> Parkplatzantrags { get; } = new List<Parkplatzantrag>();
}
