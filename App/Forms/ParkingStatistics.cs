using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface;
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
    }
}
