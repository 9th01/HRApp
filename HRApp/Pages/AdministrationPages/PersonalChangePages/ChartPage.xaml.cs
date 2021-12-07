using HRApp.View;
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

namespace HRApp.Pages.AdministrationPages.PersonalChangePages
{
    /// <summary>
    /// Interaction logic for ChartPage.xaml
    /// </summary>
    public partial class ChartPage : Page
    {
        public ChartPage()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            var brush1 = (Brush)converter.ConvertFromString("#4C5BD4");
            var brush2 = (Brush)converter.ConvertFromString("#FFA800");

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Mốc thời gian 1 (02/02/2021 - 02/05/2021)",
                    Values = new ChartValues<double> { 10, 50, 39, 50, 20, 50 },
                    DataLabels = true,
                    Stroke = brush1,
                }
            };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Mốc thời gian 2 (02/05/2021 - 02/08/2021)",
                Values = new ChartValues<double> { 11, 56, 42, 17, 30 },
                DataLabels = true,
                Stroke = brush2
            });

            SeriesCollection[1].Values.Add(48d);

            Labels = new[] { "Tăng lương", "Giảm lương", "Bổ nhiệm, quy hoạch", "Luân chuyển công tác", "Giảm biên chế", "Nghỉ việc" };
            Formatter = value => value.ToString();

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        private void NavigateToPage(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            string name = textBlock.Name;
            switch (name)
            {
                case "Appointment":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new AppointmentPage());
                        }
                    };
                    break;
                case "Downsizing":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new DownsizingPage());
                        }
                    };
                    break;
                case "UpDownSalary":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new UpDownSalaryPage());
                        }
                    };
                    break;
                case "WorkingRotation":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new WorkingRotationPage());
                        }
                    };
                    break;
                case "Chart":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new ChartPage());
                        }
                    };
                    break;
            }
        }
    }
}
