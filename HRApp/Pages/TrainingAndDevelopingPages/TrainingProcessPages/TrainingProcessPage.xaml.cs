using HRApp.View;
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

namespace HRApp.Pages.TrainingAndDevelopingPages.TrainingProcessPages
{
    /// <summary>
    /// Interaction logic for TrainingProcessPage.xaml
    /// </summary>
    public partial class TrainingProcessPage : Page
    {
        public TrainingProcessPage()
        {
            InitializeComponent();
        }

        private void navigateToDetail(object sender, MouseButtonEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(HomeView))
                {
                    (window as HomeView).MainContent.Navigate(new TrainingProcessDetailPage());
                }
            }
        }
    }
}
