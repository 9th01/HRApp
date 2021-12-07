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
    /// Interaction logic for AgeChart.xaml
    /// </summary>
    public partial class AgeChart : UserControl
    {
        public AgeChart()
        {
            InitializeComponent();
            var converter = new BrushConverter();
            var brush1 = (Brush)converter.ConvertFromString("#4C5BD4");
            var brush2 = (Brush)converter.ConvertFromString("#3F964F");
            var brush3 = (Brush)converter.ConvertFromString("#FFA800");
            var brush4 = (Brush)converter.ConvertFromString("#D44C4C");
            SeriesCollection = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Title = "Dưới 30 tuổi",
                    Values = new ChartValues<double> {4, 5, 6, 8, 6, 1, 4, 1, 9, 5, 7, 8},
                    StackMode = StackMode.Values,
                    Fill = brush1,
                    Stroke = brush1
                },
                new StackedColumnSeries
                {
                    Title = "30 - 44 tuổi",
                    Values = new ChartValues<double> {2, 5, 6, 7, 5, 6, 8, 6, 1, 4, 1, 9},
                    StackMode = StackMode.Values,
                    Fill = brush2,
                    Stroke = brush2
                },
                new StackedColumnSeries
                {
                    Title = "45 - 59 tuổi",
                    Values = new ChartValues<double> {2, 5, 6, 3, 5, 6, 2, 6, 1, 4, 1, 9},
                    StackMode = StackMode.Values,
                    Fill = brush3,
                    Stroke = brush3
                },
                new StackedColumnSeries
                {
                    Title = "Trên 60 tuổi",
                    Values = new ChartValues<double> {2, 5, 6, 7, 5, 6, 6, 6, 1, 4, 1, 5},
                    StackMode = StackMode.Values,
                    Fill = brush4,
                    Stroke = brush4
                }
            };

            Labels = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            Formatter = value => value.ToString();
            DataContext = this;
            chart.AxisX[0].Separator.StrokeThickness = 0;
            //chart.AxisY[0].Separator.StrokeThickness = 0;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

    }
}

