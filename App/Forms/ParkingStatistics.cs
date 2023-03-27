using Interface;
using Microsoft.VisualBasic;
using Models.Models;
using Models.Models.utilities;
using OxyPlot;
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


            /*
            //Schülerlist von genehmigte anträge raus holen
            //alle schüler die heute da sind mit hilfe von untisStundeList ausrechnen
            // anzahl von alle schüler die heute da sind
            // belegung von parkplatz anhand von alle schüler die heute da sind und mit hilfe von untis stunde list
            myModel = new PlotModel();
            myModel.Title = "Parkplatzstatistik";
            var xAxis = new OxyPlot.Axes.LinearAxis();
            xAxis.Position = OxyPlot.Axes.AxisPosition.Bottom;
            myModel.Axes.Add(xAxis);
            var yAxis = new OxyPlot.Axes.LinearAxis();
            yAxis.Position = OxyPlot.Axes.AxisPosition.Left;
            myModel.Axes.Add(yAxis);
            var series = new OxyPlot.Series.LineSeries();
            series.Points.Add(new DataPoint(0, 0));
            series.Points.Add(new DataPoint(10, 5));
            series.Points.Add(new DataPoint(20, 8));
            myModel.Series.Add(series);
            plotView1.Model = myModel;
            */
            //GenerateAndPlotStatistics(untisStundeList, genehmigteAntraege);
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

                // Create a Progress object to report progress
                var progress = new Progress<double>(value =>
                {
                    double percentage = (value / fileSize) * 100.0;
                    progressBar1.Value = (int)percentage;
                });

                // Load the file asynchronously and report progress
                await Task.Run(() =>
                {
                    using (var fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        string line;
                        long bytesRead = 0;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            untisStundeList.Add(new UntisStunde(line, ","));
                            bytesRead += Encoding.UTF8.GetByteCount(line);
                            ((IProgress<double>)progress).Report(bytesRead);
                        }
                    }
                });

                if (untisStundeList.Count > 0)
                    MessageBox.Show($"{untisStundeList.Count} Untis Stunde von {DateTime.Now} geladen");
                else
                    MessageBox.Show("List is empty");
            }
        }
      


        private List<Schueler> GetAnwesendeSchueler(List<UntisStunde> untisStundeList, List<Parkplatzantrag> genehmigteAntraege, TimeSpan timeSpan, TimeSpan timeSpan1)
        {
            // Schülerliste für den zugewiesenen Parkplatz erstellen
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

            // Anwesende Schüler ermitteln
            List<Schueler> anwesendeSchueler = new List<Schueler>();
            foreach (var schueler in schuelerListe)
            {
                bool schuelerAnwesend = false;
                foreach (var stunde in untisStundeList)
                {
                    if (stunde.KlassenNames == schueler.KlassenName)
                    {
                        DateTime stundeBeginn = stunde.StundeBegin;
                        DateTime stundeEnde = stunde.StundeEnde;
                        if (stundeBeginn.TimeOfDay <= DateTime.Now.TimeOfDay && DateTime.Now.TimeOfDay <= stundeEnde.TimeOfDay)
                        {
                            schuelerAnwesend = true;
                            break;
                        }
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
                    if (stunde.KlassenNames == schueler.KlassenName)
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
        
        private void GenerateAndPlotStatistics(List<UntisStunde> untisStundeList, List<Parkplatzantrag> genehmigteAntraege)
        {
            // Get a list of all students present during each hour of the day
            var studentCountsByHour = new Dictionary<int, int>();
            for (int i = 0; i < 24; i++)
            {
                var studentsPresent = GetAnwesendeSchueler(untisStundeList, genehmigteAntraege, new TimeSpan(i, 0, 0), new TimeSpan(i, 59, 59));
                studentCountsByHour[i] = studentsPresent.Count;
            }

            // Calculate the number of occupied parking spaces for each hour of the day
            var occupiedSpacesByHour = new Dictionary<int, int>();
            foreach (var hour in studentCountsByHour.Keys)
            {
                var occupiedSpaces = Math.Min(studentCountsByHour[hour], genehmigteAntraege.Count);
                occupiedSpacesByHour[hour] = occupiedSpaces;
            }

            // Create a new plot model
            myModel = new PlotModel();
            myModel.Title = "Parkplatzstatistik";

            // Add a linear axis for the x-axis (hours of the day)
            var xAxis = new OxyPlot.Axes.LinearAxis();
            xAxis.Position = OxyPlot.Axes.AxisPosition.Bottom;
            xAxis.Title = "Stunde des Tages";
            myModel.Axes.Add(xAxis);

            // Add a linear axis for the y-axis (number of occupied parking spaces)
            var yAxis = new OxyPlot.Axes.LinearAxis();
            yAxis.Position = OxyPlot.Axes.AxisPosition.Left;
            yAxis.Title = "Belegte Parkplätze";
            myModel.Axes.Add(yAxis);

            // Create a line series to plot the data
            var series = new OxyPlot.Series.LineSeries();
            foreach (var hour in occupiedSpacesByHour.Keys)
            {
                series.Points.Add(new DataPoint(hour, occupiedSpacesByHour[hour]));
            }
            myModel.Series.Add(series);

            // Display the plot
            plotView1.Model = myModel;
        }
        


        private void btnStatCalc_Click(object sender, EventArgs e)
        {
            GenerateAndPlotStatistics(untisStundeList, genehmigteAntraege);
        }
    }
}
