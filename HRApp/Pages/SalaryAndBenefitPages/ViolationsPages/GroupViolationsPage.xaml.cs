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

namespace HRApp.Pages.SalaryAndBenefitPages.ViolationsPages
{
    /// <summary>
    /// Interaction logic for GroupViolationsPage.xaml
    /// </summary>
    public partial class GroupViolationsPage : Page
    {
        public GroupViolationsPage()
        {
            InitializeComponent();
        }

        private void NavigateToPage(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            string name = textBlock.Name;
            switch (name)
            {
                case "Personal":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new PersonalViolationsPage());
                        }
                    };
                    break;
                case "Group":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new GroupViolationsPage());
                        }
                    };
                    break;
                case "List":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new ListViolationsPage());
                        }
                    };
                    break;
            }
        }
    }
}
