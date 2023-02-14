using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Models.Models;

public partial class Schueler : INotifyPropertyChanged
{
    public int SchuelerId { get; set; }

    public string? Vorname { get; set; }

    public string? Nachname { get; set; }

    public string? Email { get; set; }

    public string? KlassenName { get; set; }

    //public virtual Adressen? Adressen { get; set; }

    public virtual Parkplatzantrag? Parkplatzantrag { get; set; }

    private Adressen? _adressen;
    public virtual Adressen? Adressen
    {
        get => _adressen;
        set
        {
            _adressen = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
