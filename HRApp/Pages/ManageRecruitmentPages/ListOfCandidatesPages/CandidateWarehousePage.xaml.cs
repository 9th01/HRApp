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

namespace HRApp.Pages.ManageRecruitmentPages.ListOfCandidatesPages
{
    /// <summary>
    /// Interaction logic for CandidateWarehousePage.xaml
    /// </summary>
    public partial class CandidateWarehousePage : Page
    {
        public CandidateWarehousePage()
        {
            InitializeComponent();
        }

        private void NavigateToDetail(object sender, MouseButtonEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(HomeView))
                {
                    (window as HomeView).MainContent.Navigate(new CandidateProfileDetailsPage());
                }
            }
        }

        private void NavigateToWarehouse(object sender, MouseButtonEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(HomeView))
                {
                    (window as HomeView).MainContent.Navigate(new CandidateWarehousePage());
                }
            }
        }

        private void NavigateToListCandidate(object sender, MouseButtonEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(HomeView))
                {
                    (window as HomeView).MainContent.Navigate(new ListOfCandidatesPage());
                }
            }
        }
    }
}
