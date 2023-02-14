using Framework;
using Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.Web.WebView2.WinForms;
using Models.Data;
using Models.Models;
using Models.Models.utilities;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModels
{
    public class AntragViewModel : IAntragViewModel, INotifyPropertyChanged
    {
        private readonly IGoogleService _googleService = new GoogleService();
        private readonly IAntragService _antragService = new WeightedScoring();
        private readonly ParkplatzverwaltungContext _context = new ParkplatzverwaltungContext();

        public event PropertyChangedEventHandler? PropertyChanged;

        private string _navUrl { get; set; }

        public WebView2 webView { get; set; }
        public TextBox searchBox { get; set; }
        public TextBox untisPathBox { get; set; }
        public DataGridView parkPlatzAntragView { get; set; }
        public BindingSource AntragBindingSource { get; set; }
        public BindingSource SchuelerBindingSource { get; set; }
        public BindingSource AdresseBindingSource { get; set; }
        public BindingSource GenehmigtStatus { get; set; }

        // Use to Calculate and get Notified everytime Atribute of Adresse changed
        private Schueler selectedSchueler;
        private Parkplatzantrag selectedParkplatzantrag;

        public async Task LoadAsync()
        {
            //Alle Daten zum context Laden
            _context
                .Parkplatzantrags
                .Include(e => e.Schueler)
                .Include(e => e.Schueler.Adressen)
                .Load();
            _context.Genehmigtstatuses.Load();

            //Sortiert ASC
            AntragBindingSource.Sort = "ParkplatzantragsId ASC";

            //Daten zum DataSource zu weisen und Reisezeit bzw Fahrzeit berechnen
            AntragBindingSource.ResetBindings(false);
            AntragBindingSource.DataSource = _context.Parkplatzantrags.Local.ToBindingList();
            await InitParkPlatzAntragAsync();
            GenehmigtStatus.DataSource = _context.Genehmigtstatuses.Local.ToBindingList();
            SchuelerBindingSource.DataSource = _context.Schuelers.Local.ToBindingList();
            AdresseBindingSource.DataSource = _context.Adressens.Local.ToBindingList();
        }

        public void New()
        {
            var parkplatzAntrag = AntragBindingSource.AddNew() as Parkplatzantrag;
            parkplatzAntrag.Antragsdatum = DateTime.Now;

        }

        public async Task SaveAsync()
        {
            await UpdateTravelDetailsAsync();
            if (selectedSchueler.Adressen != null)
            {
                selectedSchueler.Adressen.PropertyChanged += Adressen_PropertyChanged;
            }
            AntragBindingSource.EndEdit();
            SchuelerBindingSource.EndEdit();
            AdresseBindingSource.EndEdit();
            
            // wird geprüft ob record gespeichert wird;
            Int32 record;
            record = _context.SaveChanges();

            
            

            if (record != 0)
            {
                parkPlatzAntragView.Refresh();
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

                    if (schueler != null && schueler.Adressen != null && schueler.Parkplatzantrag != null && schueler.Parkplatzantrag.EntfernungKm == null && parkplatzantrag != null && parkplatzantrag.Punkte != 0)
                    {
                        // problem* _googleService musst initialisiert werden new GoogleService(); ansonsten null reference exception
                        parkplatzantrag.EntfernungKm = await _googleService.GetDistance(schueler.Adressen);
                        parkplatzantrag.Fahrzeit = await _googleService.GetDriveTime(schueler.Adressen);
                        parkplatzantrag.Reisezeit = await _googleService.GetTravelTime(schueler.Adressen);
                        parkplatzantrag.Punkte = _antragService.AntragBewerten(parkplatzantrag);

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

                if (parkplatzantrag != null) {
                    parkplatzantrag.EntfernungKm = await _googleService.GetDistance(parkplatzantrag.Schueler.Adressen);
                    parkplatzantrag.Fahrzeit = await _googleService.GetDriveTime(parkplatzantrag.Schueler.Adressen);
                    parkplatzantrag.Reisezeit = await _googleService.GetTravelTime(parkplatzantrag.Schueler.Adressen);
                    parkplatzantrag.Punkte = _antragService.AntragBewerten(parkplatzantrag);

                    // Prüft ob erfolgtreich gespeichert wird 
                    if (_context.SaveChanges() != 0) {
                        parkPlatzAntragView.Refresh();
                        MessageBox.Show("Erfolgreich ausgerechnet!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
            }

            

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
            detailView.SchuelerBindingSource.DataSource = SchuelerBindingSource.Current;
            detailView.AdresseBindingSource.DataSource = AdresseBindingSource.Current;
            detailView.AntragBinDingSource.DataSource = AntragBindingSource.Current;
            detailView.GenehmigtStatus.DataSource = GenehmigtStatus.DataSource;
            detailView.ShowDetail();

        }

        public void ShowMailSender(IMailSender mailSender)
        {
            //mailSender.emailsReceiverList = new List<Parkplatzantrag>();
            foreach (DataGridViewRow row in parkPlatzAntragView.SelectedRows)
            {
                // jeder Objekt neu berechnen
                Parkplatzantrag parkplatzantrag = (Parkplatzantrag)row.DataBoundItem;
                mailSender.emailsReceiverList.Add(parkplatzantrag);
            }
            mailSender.ShowMailSender();
        }

        public void ShowEmailSetting(IEmailSetting emailSetting)
        {
            emailSetting.ShowEmailSetting();
        }



        private async void Adressen_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            await UpdateTravelDetailsAsync();
        }

        private async Task UpdateTravelDetailsAsync()
        {
            if (SchuelerBindingSource.Current is Schueler schueler)
            {
                selectedSchueler = schueler;
                selectedParkplatzantrag = selectedSchueler.Parkplatzantrag;
                if (selectedParkplatzantrag != null && selectedSchueler.Adressen != null)
                {
                    // Perform calculation to update the EntfernungKm attribute
                    selectedParkplatzantrag.EntfernungKm = await _googleService.GetDistance(selectedSchueler.Adressen);
                    selectedParkplatzantrag.Fahrzeit = await _googleService.GetDriveTime(selectedSchueler.Adressen);
                    selectedParkplatzantrag.Reisezeit = await _googleService.GetTravelTime(selectedSchueler.Adressen);
                    selectedParkplatzantrag.Punkte = _antragService.AntragBewerten(selectedParkplatzantrag);
                }
            }
        }

        /*
        public void LoadUntisStunde()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                List<UntisStunde> untisStundeList = new List<UntisStunde>();
                
                foreach (var line in lines)
                {
                    untisStundeList.Add(new UntisStunde(line, ","));
                }

                if (untisStundeList.Count > 0)
                    MessageBox.Show(untisStundeList.Count.ToString() + "Untis Stunde von "+ DateAndTime.Now + " geladen");
                else
                    MessageBox.Show("List is empty");

                untisPathBox.Text = openFileDialog1.FileName;
            }
        }
        */
        public void ShowParkingStatistics(IParkingStatisticsView parkingStatisticsView)
        {
            parkingStatisticsView.showParkingStatistics();
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
