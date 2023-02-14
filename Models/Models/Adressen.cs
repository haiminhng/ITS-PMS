using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Models.Models;

public partial class Adressen : INotifyPropertyChanged
{
    private string? _strasse;
    private string? _hausnr;
    private int? _plz;
    private string? _ort;
    private string? _land;

    public short AdresseId { get; set; }

    public string? Strasse
    {
        get => _strasse;
        set
        {
            _strasse = value;
            OnPropertyChanged();
        }
    }

    public string? Hausnr
    {
        get => _hausnr;
        set
        {
            _hausnr = value;
            OnPropertyChanged();
        }
    }

    public int? Plz
    {
        get => _plz;
        set
        {
            _plz = value;
            OnPropertyChanged();
        }
    }

    public string? Ort
    {
        get => _ort;
        set
        {
            _ort = value;
            OnPropertyChanged();
        }
    }

    public string? Land
    {
        get => _land;
        set
        {
            _land = value;
            OnPropertyChanged();
        }
    }

    public int? SchuelerId { get; set; }

    public virtual Schueler? Schueler { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
