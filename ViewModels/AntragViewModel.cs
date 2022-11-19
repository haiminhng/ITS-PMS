using System;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Models.Data;
using Models.Models;
using Interface;
using Framework;


namespace ViewModels
{
    public class AntragViewModel : INotifyPropertyChanged, IAntragViewModel
    {
        private readonly ParkplatzverwaltungContext _context = new ParkplatzverwaltungContext();

        private IGoogleService _googleService = new GoogleService();

        public event PropertyChangedEventHandler? PropertyChanged;

        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }

        public async Task LoadAsync( )
        {
            _context
                .Parkplatzantrags
                .Include(e => e.Schueler)
                .Include(e => e.Schueler.Adressen)
                .Load();
            AntragBindingSource.ResetBindings(false);
            AntragBindingSource.DataSource = _context.Parkplatzantrags.Local.ToBindingList();
            SchuelerBindingSource.DataSource = _context.Schuelers.Local.ToBindingList();
            AdresseBindingSource.DataSource = _context.Adressens.Local.ToBindingList();            
            await InitParkPlatzAntragAsync();

        }

        public void New()
        {
            var parkplatzAntrag = AntragBindingSource.AddNew() as Parkplatzantrag;
            parkplatzAntrag.Antragsdatum = DateTime.Now;

        }

        public void Save()
        {
            // wird geprüft ob record gespeichert wird;
            Int32 record;
            record = _context.SaveChanges();
            if (record != 0)
            {
                MessageBox.Show("Erfolgreich gespeichert");
            }
            else
            {
                MessageBox.Show("Fehler");
            }
        }

        public void Delete() => AntragBindingSource.RemoveCurrent();
        public void First() => AntragBindingSource.MoveFirst(); 
        public void Last() => AntragBindingSource.MoveLast();
        public void Previous() => AntragBindingSource.MovePrevious();
        public void Next() => AntragBindingSource.MoveNext();

        public void DataGridClick()
        {
        BindingList<Schueler> schuelerData = new BindingList<Schueler>();
        BindingList<Adressen> adressenData = new BindingList<Adressen>();

            if (AntragBindingSource.Current is Parkplatzantrag parkplatzantrag)
            {
                if (parkplatzantrag.SchuelerId > 0)
                {
                    Schueler schueler = _context.Schuelers.Find(parkplatzantrag.SchuelerId);
                    schuelerData.Add(schueler);
                    adressenData.Add(schueler.Adressen);
                    SchuelerBindingSource.DataSource = schuelerData;
                    AdresseBindingSource.DataSource = adressenData;
                }
            }
        }

        private async Task InitParkPlatzAntragAsync()
        {
              BindingList<Parkplatzantrag> _parkplatzantrags = new BindingList<Parkplatzantrag>();
            {
                _parkplatzantrags = _context.Parkplatzantrags.Local.ToBindingList();

                foreach (var parkplatzantrag in _parkplatzantrags)
                {
                    Schueler schueler = _context.Schuelers.Find(parkplatzantrag.SchuelerId);

                    if (schueler.Adressen != null && schueler.Parkplatzantrag != null)
                    {
                        parkplatzantrag.EntfernungKm = await _googleService.GetDistance(schueler.Adressen);
                        parkplatzantrag.Fahrzeit = await _googleService.GetDriveTime(schueler.Adressen);
                    }
                }
                _context.SaveChanges();
                AntragBindingSource.DataSource = _parkplatzantrags;
            }
        }
    }
}
