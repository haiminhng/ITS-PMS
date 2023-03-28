using Interface;
using Microsoft.VisualBasic;
using Models.Data;
using Models.Models;
using Models.Models.utilities;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Text;
using Unity;

namespace App.Forms
{
    public partial class ParkingStatistics : Form, IParkingStatisticsView
    {

        private PlotModel myModel;

        private List<UntisStunde> untisStundeList = new List<UntisStunde>();

        public List<Parkplatzantrag> genehmigteAntraege { get; set; }

        public ParkingStatistics()
        {
            InitializeComponent();
            genehmigteAntraege = new List<Parkplatzantrag>();
            //ZeigeParkplatzStatistik(dateTimePicker1.Value);
        }


        public void showParkingStatistics()
        {
            this.ShowDialog();
        }
        private async void btnLoadFileUntis_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                textBox1.Text = filename;
                untisStundeList.Clear();

                // Get file size in bytes
                long fileSize = new FileInfo(filename).Length;

                // Create a new instance of the FileLoadingForm
                IFileLoadingForm loadingForm = UnityConfig.container.Resolve<IFileLoadingForm>();

                // Show the loading form
                loadingForm.Show();

                // Load the file asynchronously and report progress
                var fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                var streamReader = new StreamReader(fileStream, Encoding.UTF8);
                string line;
                long bytesRead = 0;
                while ((line = await streamReader.ReadLineAsync()) != null)
                {
                    untisStundeList.Add(new UntisStunde(line, ","));
                    bytesRead += Encoding.UTF8.GetByteCount(line);
                    double progress = (double)bytesRead / fileSize * 100.0;

                    // Update progress and status in the loading form
                    loadingForm.SetProgress((int)progress);
                    loadingForm.SetStatus($"Loading... {progress:F2}%");
                }

                streamReader.Close();
                fileStream.Close();

                // Hide the loading form
                loadingForm.Close();

                if (untisStundeList.Count > 0)
                    MessageBox.Show($"{untisStundeList.Count} Untis Stunde von {DateTime.Now} geladen");
                else
                    MessageBox.Show("List is empty");
            }
        }


        private List<Schueler> GetGenehmigteSchueler(List<Parkplatzantrag> genehmigteAntraege)
        {
            List<Schueler> schuelerListe = new List<Schueler>();
            foreach (var antrag in genehmigteAntraege)
            {
                if (antrag.Genehmigt == 1 && antrag.Schueler != null)
                {
                    if (!schuelerListe.Contains(antrag.Schueler))
                    {
                        schuelerListe.Add(antrag.Schueler);
                    }
                }
            }
            return schuelerListe;
        }

        private List<UntisStunde> GetHeutigeUntisStunden(DateTime ausgewaehltesDatum)
        {
            List<UntisStunde> heutigeUntisStunden = new List<UntisStunde>();
            foreach (var stunde in untisStundeList)
            {
                if (stunde.StundeBegin.Date == ausgewaehltesDatum.Date)
                {
                    heutigeUntisStunden.Add(stunde);
                }
            }
            return heutigeUntisStunden;
        }

        private List<UntisStunde> GetUntisStundenFuerGenehmigteSchueler(List<UntisStunde> heutigeUntisStunden, List<Schueler> genehmigteSchuelerListe)
        {
            List<UntisStunde> stundenFuerGenehmigteSchueler = new List<UntisStunde>();
            foreach (var stunde in heutigeUntisStunden)
            {
                foreach (var schueler in genehmigteSchuelerListe)
                {
                    if (stunde.KlassenNames.Equals(schueler.KlassenName))
                    {
                        stundenFuerGenehmigteSchueler.Add(stunde);
                        break; // Schüler für diese Stunde gefunden, Schleife für diesen Stunde beenden
                    }
                }
            }
            return stundenFuerGenehmigteSchueler;
        }



        private List<Schueler> GetAnwesendeSchueler(List<UntisStunde> untisStundeList, List<Schueler> schuelerListe)
        {
            List<Schueler> anwesendeSchueler = new List<Schueler>();
            foreach (var schueler in schuelerListe)
            {
                bool schuelerAnwesend = false;
                foreach (var stunde in untisStundeList)
                {
                    if (stunde.Klasse == schueler.KlassenName)
                    {
                        schuelerAnwesend = true;
                    }
                }
                if (schuelerAnwesend)
                {
                    anwesendeSchueler.Add(schueler);
                }
            }
            return anwesendeSchueler;
        }



        private List<UntisStunde> GetAnwesendeStunden(List<UntisStunde> untisStundeListe, List<Schueler> anwesendeSchueler)
        {
            List<UntisStunde> anwesendeStunden = new List<UntisStunde>();
            foreach (var stunde in untisStundeListe)
            {
                foreach (var schueler in anwesendeSchueler)
                {
                    if (string.Equals(stunde.Kurzzeichen, schueler.KlassenName, StringComparison.OrdinalIgnoreCase))
                    {
                        DateTime stundeBeginn = stunde.StundeBegin;
                        DateTime stundeEnde = stunde.StundeEnde;
                        if (stundeBeginn.TimeOfDay <= DateTime.Now.TimeOfDay && DateTime.Now.TimeOfDay <= stundeEnde.TimeOfDay)
                        {
                            anwesendeStunden.Add(stunde);
                            break;
                        }
                    }
                }
            }
            return anwesendeStunden;
        }


        public void ZeigeParkplatzStatistik(DateTime ausgewaehltesDatum)
        {
            // Anwesende Schüler und Stunden ermitteln
            List<Schueler> genehmigteSchueler = GetGenehmigteSchueler(genehmigteAntraege);
            List<UntisStunde> untisStundes = GetHeutigeUntisStunden(dateTimePicker1.Value);
            List<UntisStunde> untisHeute = GetUntisStundenFuerGenehmigteSchueler(untisStundes, genehmigteSchueler);
            ZeigeUntisStundenStatistik(untisHeute);
        }

        public void ZeigeUntisStundenStatistik(List<UntisStunde> untisStunden)
        {
            // Create dictionary to store count of UntisStunden for each hour of the day
            Dictionary<int, int> hourCount = new Dictionary<int, int>();
            for (int i = 0; i < 24; i++)
            {
                hourCount.Add(i, 0);
            }

            // Count UntisStunden for each hour of the day
            foreach (var stunde in untisStunden)
            {
                int hour = stunde.StundeBegin.Hour;
                hourCount[hour]++;
            }

            // Set up plot view to display statistics
            plotView1.Model = new PlotModel { Title = "Parkplatz Statistik " + dateTimePicker1.Value.Date };
            var columnSeries = new BarSeries();
            columnSeries.ItemsSource = hourCount;
            columnSeries.ValueField = "Value";
            columnSeries.Title = "Anzahl Autos";
            columnSeries.FillColor = OxyColor.Parse("#2196F3");
            columnSeries.StrokeColor = OxyColor.Parse("#2196F3");
            columnSeries.StrokeThickness = 1;
            columnSeries.LabelPlacement = LabelPlacement.Outside;
            columnSeries.LabelFormatString = "{0}";
            plotView1.Model.Series.Add(columnSeries);
            plotView1.Model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "Anzahl der im Park abgestellten Autos\r\n\r\n\r\n\r\n", Minimum = 0, Maximum = hourCount.Values.Max() + 1 });
            plotView1.Model.Axes.Add(new CategoryAxis { Position = AxisPosition.Left, Title = "Uhrzeit", ItemsSource = hourCount.Keys.Reverse() });
        }




        private void btnStatCalc_Click(object sender, EventArgs e)
        {
            ZeigeParkplatzStatistik(dateTimePicker1.Value);
        }
    }
}
