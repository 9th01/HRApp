using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HRApp.Pages.HRReportPages.HRReportPages.Charts
{
    /// <summary>
    /// Interaction logic for NewStaffChart.xaml
    /// </summary>
    public partial class NewStaffChart : UserControl
    {
        public NewStaffChart()
        {
            InitializeComponent();
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#4C5BD4");
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = null,
                    Values = new ChartValues<double> {double.NaN, 5, 10, 8, 11, 14, 15, 8, 10, 12, 6, 7, 10 },
                    PointForeground = brush,
                    DataLabels = true,
                    Fill = Brushes.Transparent,
                    Stroke = brush
                },
            };

            Labels = new[] { "", "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12", };
            YFormatter = value => value.ToString();
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

    }
}