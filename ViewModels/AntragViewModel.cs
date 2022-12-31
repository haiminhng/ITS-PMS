using Framework;
using Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Web.WebView2.WinForms;
using Models.Data;
using Models.Models;
using System.ComponentModel;
using System.Windows.Forms;


namespace ViewModels
{
    public class AntragViewModel : IAntragViewModel
    {
        private readonly IGoogleService _googleService = new GoogleService();
        private readonly ParkplatzverwaltungContext _context = new ParkplatzverwaltungContext();
        private string _navUrl { get; set; }

        public WebView2 webView { get; set; }
        public TextBox searchBox { get; set; }
        public DataGridView parkPlatzAntragView { get; set; }
        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }
        public BindingSource GenehmigtStatus { get; set; }


        public async Task LoadAsync()
        {
            _context
                .Parkplatzantrags
                .Include(e => e.Schueler)
                .Include(e => e.Schueler.Adressen)
                .Load();
            _context.Genehmigtstatuses.Load();

            AntragBindingSource.Sort = "ParkplatzantragsId ASC";
            AntragBindingSource.ResetBindings(false);
            AntragBindingSource.DataSource = _context.Parkplatzantrags.Local.ToBindingList();
            await InitParkPlatzAntragAsync();

            GenehmigtStatus.DataSource = _context.Genehmigtstatuses.Local.ToBindingList();


            /*
            BindingList<Genehmigtstatus> genehmigtStatusList = new BindingList<Genehmigtstatus>
            {
                new Genehmigtstatus { Wert = 0, Beschreibung = "Bearbeitung" },
                new Genehmigtstatus { Wert = 1, Beschreibung = "Genehmigt" },
                new Genehmigtstatus { Wert = 2, Beschreibung = "Abgelehnt" },
                new Genehmigtstatus { Wert = 3, Beschreibung = "Wartelist" },
            };
            GenehmigtStatus.DataSource = genehmigtStatusList;
            */



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
            AntragBindingSource.EndEdit();
            SchuelerBindingSource.EndEdit();
            AdresseBindingSource.EndEdit();
            // wird geprüft ob record gespeichert wird;
            Int32 record;
            record = _context.SaveChanges();
            if (record != 0)
            {
                MessageBox.Show("Erfolgreich gespeichert");
                NavWebView();
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

        
        public void DataGridView_CellClick()
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

                    //Change Data of WebView
                    _navUrl =
                        "https://www.google.de/maps/dir/"
                        + schueler.Adressen.Strasse + " "
                        + schueler.Adressen.Hausnr + " ,"
                        + schueler.Adressen.Plz + " "
                        + schueler.Adressen.Ort + " "
                        + schueler.Adressen.Land +
                        "/it.schule,+Breitwiesenstra%C3%9Fe+20-22,+70565+Stuttgart/";
                    NavWebView();

                }
            }
        }
        

        /*
         Es gibt ein paar Probleme mit diesem Code. 
        Eines der Hauptprobleme besteht darin, dass Sie bei jedem Aufruf der DataGridView_CellClick-Methode neue BindingList-Objekte erstellen. 
        Das bedeutet, dass SchuelerBindingSource und AdresseBindingSource immer an leere Listen gebunden sind und die Daten nicht aktualisiert werden, wenn mann auf eine neue Zeile klicken.

        Problem gelöst durch null setzen von Datasource
         */
        /*
        public void DataGridView_CellClick()
        {
            if (AntragBindingSource.Current is Parkplatzantrag parkplatzantrag)
            {
                if (parkplatzantrag.SchuelerId > 0)
                {
                    Schueler schueler = _context.Schuelers
                        .Include(s => s.Adressen)
                        .Single(s => s.SchuelerId == parkplatzantrag.SchuelerId);

                    SchuelerBindingSource.DataSource = schueler;
                    AdresseBindingSource.DataSource = schueler.Adressen;

                    //Change Data of WebView
                    _navUrl =
                        "https://www.google.de/maps/dir/"
                        + schueler.Adressen.Strasse + " "
                        + schueler.Adressen.Hausnr + " ,"
                        + schueler.Adressen.Plz + " "
                        + schueler.Adressen.Ort + " "
                        + schueler.Adressen.Land +
                        "/it.schule,+Breitwiesenstra%C3%9Fe+20-22,+70565+Stuttgart/";
                    NavWebView();
                }
                else
                {
                    SchuelerBindingSource.DataSource = null;
                    AdresseBindingSource.DataSource = null;
                }
            }
        }
        */
        public void DataGridView_CellFormatting()
        {

        }

        private async Task InitParkPlatzAntragAsync()
        {

            BindingList<Parkplatzantrag> _parkplatzantrags = new BindingList<Parkplatzantrag>();
            {
                _parkplatzantrags = _context.Parkplatzantrags.Local.ToBindingList();

                foreach (var parkplatzantrag in _parkplatzantrags)
                {
                    Schueler schueler = _context.Schuelers.Find(parkplatzantrag.SchuelerId);

                    if (
                        schueler != null && 
                        schueler.Adressen != null && 
                        schueler.Parkplatzantrag != null && 
                        schueler.Parkplatzantrag.EntfernungKm == null)
                    {
                        // problem* _googleService musst initialisiert werden new GoogleService(); ansonsten null reference exception
                        parkplatzantrag.EntfernungKm = await _googleService.GetDistance(schueler.Adressen);
                        parkplatzantrag.Fahrzeit = await _googleService.GetDriveTime(schueler.Adressen);
                        parkplatzantrag.Reisezeit = await _googleService.GetTravelTime(schueler.Adressen);

                        _context.SaveChanges();
                        parkPlatzAntragView.Refresh();
                    }
                }
                AntragBindingSource.DataSource = _parkplatzantrags;
            }
        }

        private void NavWebView()
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                //SchuelerBindingSource.Current is Schueler schueler;
                webView.CoreWebView2.Navigate(_navUrl);
            }
        }

        public async Task CalcNewRouteData()
        {

                // Durchlaufen alle ausgewählten Zeilen in DataGridView
                foreach (DataGridViewRow row in parkPlatzAntragView.SelectedRows)
                {
                    // jeder Objekt neu berechnen
                    Parkplatzantrag parkplatzantrag = (Parkplatzantrag)row.DataBoundItem;

                    parkplatzantrag.EntfernungKm = await _googleService.GetDistance(parkplatzantrag.Schueler.Adressen);
                    parkplatzantrag.Fahrzeit = await _googleService.GetDriveTime(parkplatzantrag.Schueler.Adressen);
                    parkplatzantrag.Reisezeit = await _googleService.GetTravelTime(parkplatzantrag.Schueler.Adressen);

                _context.SaveChanges();
                }
            parkPlatzAntragView.Refresh();
            MessageBox.Show("Erfolgreich ausgerechnet!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*
                Parkplatzantrag parkplatzantrag = (Parkplatzantrag)AntragBindingSource.Current;

                    Schueler schueler = parkplatzantrag.Schueler;

                    if (schueler != null && schueler.Adressen != null && schueler.Parkplatzantrag != null)
                    {
                        // problem* _googleService musst initialisiert werden new GoogleService(); ansonsten null reference exception
                        parkplatzantrag.EntfernungKm = await _googleService.GetDistance(schueler.Adressen);
                        parkplatzantrag.Fahrzeit = await _googleService.GetDriveTime(schueler.Adressen);
                        _context.SaveChanges();
                    }
                */
        }

        public void Search()
        {

            // Get the value to search for from the text box

            string searchText = searchBox.Text.ToLower();

            foreach (DataGridViewRow row in parkPlatzAntragView.Rows)
            {
                if (row.IsNewRow) continue; // Skip new rows

                row.Visible = true; // Make the row visible again
                string cellValue = row.Cells[1].Value?.ToString().ToLower() ?? "";
                if (!cellValue.Contains(searchText))
                {
                    parkPlatzAntragView.EndEdit(); // Commit any pending changes to the data source
                    int rowIndex = row.Index;
                    CurrencyManager cm = (CurrencyManager)parkPlatzAntragView.BindingContext[parkPlatzAntragView.DataSource]; ;
                    cm.SuspendBinding(); // Suspend updates to the data source
                    parkPlatzAntragView.Rows[rowIndex].Visible = false; // Set the row to be invisible
                    cm.ResumeBinding(); // Resume updates to the data source
                }
            }
        }
        
        public void ShowDetail(IDetailView detailView)
        {
            detailView.BindingSource.DataSource = SchuelerBindingSource.Current;
            detailView.ShowDetail();

        }

        public void ShowMailSender(IMailSender mailSender)
        {
            mailSender.ShowMailSender();
        }

        public void ShowEmailSetting(IEmailSetting emailSetting)
        {
            emailSetting.ShowEmailSetting();
        }
    }

}
