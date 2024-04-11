using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public class ColumnChartFactory : ChartFactory
    {
        public override Chart CreateChart()
        {
            Chart v_Chart = new Chart();
            v_Chart.ChartAreas.Clear();
            v_Chart.Series.Clear();
            v_Chart.ChartAreas.Add(new ChartArea());
            Series v_Series = new Series();
            v_Series.ChartType = SeriesChartType.Column;
            v_Chart.Series.Add(v_Series);

            return v_Chart;
        }
    }
}
