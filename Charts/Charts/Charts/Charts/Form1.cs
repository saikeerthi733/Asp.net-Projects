using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Charts
{
    using CHART = System.Windows.Forms.DataVisualization.Charting.Chart;
    using SERIES = System.Windows.Forms.DataVisualization.Charting.Series;
    using AREA = System.Windows.Forms.DataVisualization.Charting.ChartArea;
    using LEGEND = System.Windows.Forms.DataVisualization.Charting.Legend;

    // Location == 12, 12
    // Size     == 776, 426

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CHART newChart = new CHART();

            SERIES newSeries = new SERIES();
            newSeries.Name = "Languages";
            newSeries.Color = Color.Gold;
            newSeries.IsXValueIndexed = false;
            newSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            newChart.Series.Add(newSeries);

            for (int i = 1; i < 6; i++)
                newSeries.Points.AddXY(i, i * i);

            newChart.Invalidate();

            AREA newArea = new AREA();
            LEGEND newLegend = new LEGEND();

            newArea.Name = "My Only ChartArea";
            newChart.ChartAreas.Add(newArea);
            newChart.Dock = System.Windows.Forms.DockStyle.Fill;

            newLegend.Name = "Programming Language Usage";
            newChart.Legends.Add(newLegend);
            newChart.Location = new Point(12, 12);
            newChart.Size = new Size(776, 426);

            newChart.Text = ".NET's Progrmming Language Analysis Chart";

            this.Controls.Add(newChart);
        }
    }
}
