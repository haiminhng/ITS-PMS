using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Data;
using Models.Models;
using Interface;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ViewModels
{
    public class AntragViewModel : INotifyPropertyChanged, IAntragViewModel
    {
        private readonly ParkplatzverwaltungContext _context = new ParkplatzverwaltungContext();

        public event PropertyChangedEventHandler? PropertyChanged;

        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }

        public void Load()
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

        }

        public void New()
        {
            var parkplatzAntrag = AntragBindingSource.AddNew() as Parkplatzantrag;
            parkplatzAntrag.Antragsdatum = DateTime.Now;

        }

        public void Save()
        {
            // wird geprüft ob über 1 record gespeichert wird;
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
            if (AntragBindingSource.Current is Parkplatzantrag parkplatzantrag)
            {
                if (parkplatzantrag.SchuelerId > 0) {
                    BindingList<Schueler> schuelerData = new BindingList<Schueler>();
                    BindingList<Adressen> adressenData = new BindingList<Adressen>();
                    Schueler schueler = _context.Schuelers.Find(parkplatzantrag.SchuelerId);
                    schuelerData.Add(schueler);
                    adressenData.Add(schueler.Adressen);
                    SchuelerBindingSource.DataSource = schuelerData;
                    AdresseBindingSource.DataSource = adressenData;
                }

            }
        }
    }
}
