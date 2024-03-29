﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Models.Models;

public partial class Parkplatzantrag : INotifyPropertyChanged
{
    public double? EntfernungKm { get; set; }

    public int ParkplatzantragsId { get; set; }

    public string? KfzKennzeichen { get; set; }

    public bool? Besonderefall { get; set; }

    public string? Grund { get; set; }

    public bool? Mitfahrgelegenheit { get; set; }

    public string? Moeglichkeit { get; set; }

    public DateTime? Antragsdatum { get; set; }

    public TimeSpan? Fahrzeit { get; set; }

    public int? SchuelerId { get; set; }

    public TimeSpan? Antragszeit { get; set; }

    public TimeSpan? Reisezeit { get; set; }

    public int Genehmigt { get; set; }

    public int Punkte { get; set; }

    public virtual Genehmigtstatus GenehmigtNavigation { get; set; } = null!;

    public virtual Schueler? Schueler { get; set; }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
