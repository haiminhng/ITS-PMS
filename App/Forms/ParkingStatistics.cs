using Interface;
using Microsoft.VisualBasic;
using Models.Models.utilities;
using OxyPlot;
using OxyPlot.WindowsForms;



namespace App.Forms
{
    public partial class ParkingStatistics : Form, IParkingStatisticsView
    {
        private PlotModel myModel;

        public ParkingStatistics()
        {
            InitializeComponent();
            myModel = new PlotModel();
            myModel.Title = "My Chart";
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
        }

        public void showParkingStatistics()
        {
            this.ShowDialog();
        }

        private void btnLoadFileUntis_Click(object sender, EventArgs e)
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
                    MessageBox.Show(untisStundeList.Count.ToString() + "Untis Stunde von " + DateAndTime.Now + " geladen");
                else
                    MessageBox.Show("List is empty");

                textBox1.Text = openFileDialog1.FileName;
            }
        }

    }
}
