using Interface;
using Microsoft.EntityFrameworkCore;
using Models.Data;
using Models.Models;
using Unity;

namespace App.Forms
{
    public partial class Detail : Form, IDetailView
    {
        private ParkplatzverwaltungContext _context = UnityConfig.container.Resolve<ParkplatzverwaltungContext>();
        private IMailSender _mailServer = UnityConfig.container.Resolve<IMailSender>();

        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }
        public BindingSource AntragBinDingSource { get; set; }
        public BindingSource GenehmigtStatus { get; set; }

        public Detail()
        {
            InitializeComponent();
            SchuelerBindingSource = schuelerBindingSource;
            AdresseBindingSource = adressenBindingSource;
            AntragBinDingSource = parkplatzantragBindingSource;
            GenehmigtStatus = genehmigtstatusBindingSource;

            btnSave.Click += delegate { SaveDetails(); };
            btnCancle.Click += delegate { this.Hide(); };
            btnEmail.Click += delegate { _mailServer.ShowMailSender(); };
        }


        public void ShowDetail()
        {
            this.ShowDialog();
        }

        public void SaveDetails()
        {
            SchuelerBindingSource.EndEdit();
            AdresseBindingSource.EndEdit();
            AntragBinDingSource.EndEdit();
            GenehmigtStatus.EndEdit();

            var schueler = (Schueler)SchuelerBindingSource.Current;
            var adresse = (Adressen)AdresseBindingSource.Current;
            var antrag = (Parkplatzantrag)AntragBinDingSource.Current;
            var genehmigt = (Genehmigtstatus)GenehmigtStatus.Current;

            // Attach modified entities to the DbContext
            _context.Attach(schueler);
            _context.Attach(adresse);
            _context.Attach(antrag);
            _context.Attach(genehmigt);

            // Mark entities as modified
            _context.Entry(schueler).State = EntityState.Modified;
            _context.Entry(adresse).State = EntityState.Modified;
            _context.Entry(antrag).State = EntityState.Modified;
            _context.Entry(genehmigt).State = EntityState.Modified;

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
            _context.SaveChanges();
        }


    }
}
