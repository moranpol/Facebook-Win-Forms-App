using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public partial class FormAlbumStatistics : Form
    {
        private LoginResult m_LoginResult;

        public FormAlbumStatistics()
        {
            m_LoginResult = FormMain.GetLoginResult();
            InitializeComponent();
            ChartFactory v_ChartFactory = new ColumnChartFactory();
            Chart v_Chart = v_ChartFactory.CreateChart();
            updateChart(v_Chart);
        }

        private void updateChart(Chart i_Chart)
        {
            i_Chart.Titles.Add("Albums Amount Per Month");
            i_Chart.ChartAreas[0].AxisX.Title = "Month";
            i_Chart.ChartAreas[0].AxisY.Title = "Albums";

            Dictionary<int, int> v_AlbumPerMonth = createDictionaryForChart();
            var v_SortedMonths = v_AlbumPerMonth.Keys.OrderBy(i_Month => i_Month);

            foreach (int v_MonthKey in v_SortedMonths)
            {
                string v_MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(v_MonthKey);
                i_Chart.Series[0].Points.AddXY(v_MonthName, v_AlbumPerMonth[v_MonthKey]);
            }

            Controls.Add(i_Chart);
        }

        private Dictionary<int, int> createDictionaryForChart()
        {
            int v_Month;
            Dictionary<int, int> v_AlbumPerMonth = new Dictionary<int, int>();

            foreach (var v_Album in m_LoginResult.LoggedInUser.Albums)
            {
                v_Month = v_Album.CreatedTime.Value.Month;

                if (v_AlbumPerMonth.ContainsKey(v_Month))
                {
                    v_AlbumPerMonth[v_Month]++;
                }
                else
                {
                    v_AlbumPerMonth.Add(v_Month, 1);
                }
            }

            return v_AlbumPerMonth;
        }
    }
}
