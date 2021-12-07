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

namespace HRApp.Pages.SettingPages
{
    /// <summary>
    /// Interaction logic for SettingPage.xaml
    /// </summary>
    public partial class SettingPage : Page
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private void explandmore_company_info_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Path path = sender as Path;
            if (company_info_expland.Visibility == Visibility.Collapsed)
            {
                RotateTransform rotateTransform = new RotateTransform(0);
                path.RenderTransform = rotateTransform;
                company_info_expland.Visibility = Visibility.Visible;
                line_company_info.Visibility = Visibility.Hidden;
            }
            else
            {
                RotateTransform rotateTransform = new RotateTransform(-90);
                path.RenderTransform = rotateTransform;
                company_info_expland.Visibility = Visibility.Collapsed;
                line_company_info.Visibility = Visibility.Visible;
            }
        }

        private void notify_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Path path = sender as Path;
            if (notify_expland.Visibility == Visibility.Collapsed)
            {
                RotateTransform rotateTransform = new RotateTransform(0);
                path.RenderTransform = rotateTransform;
                notify_expland.Visibility = Visibility.Visible;
                line_notify.Visibility = Visibility.Hidden;
            }
            else
            {
                RotateTransform rotateTransform = new RotateTransform(-90);
                path.RenderTransform = rotateTransform;
                notify_expland.Visibility = Visibility.Collapsed;
                line_notify.Visibility = Visibility.Visible;
            }
        }

        private void remind_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Path path = sender as Path;
            if (remind_expland.Visibility == Visibility.Collapsed)
            {
                RotateTransform rotateTransform = new RotateTransform(0);
                path.RenderTransform = rotateTransform;
                remind_expland.Visibility = Visibility.Visible;
                line_remind.Visibility = Visibility.Hidden;
            }
            else
            {
                RotateTransform rotateTransform = new RotateTransform(-90);
                path.RenderTransform = rotateTransform;
                remind_expland.Visibility = Visibility.Collapsed;
                line_remind.Visibility = Visibility.Visible;
            }
        }

        private void editButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (txtCompanyInfo.Visibility == Visibility.Visible)
            {
                txtCompanyInfo.Visibility = Visibility.Collapsed;
                txtPhoneNumber.Visibility = Visibility.Collapsed;
                txtWebsite1.Visibility = Visibility.Collapsed;
                txtWebsite2.Visibility = Visibility.Collapsed;

                gridTbCompanyInfo1.Visibility = Visibility.Visible;
                gridTbCompanyInfo2.Visibility = Visibility.Visible;
                gridTbCompanyInfo3.Visibility = Visibility.Visible;
            }
            else
            {
                txtCompanyInfo.Visibility = Visibility.Visible;
                txtPhoneNumber.Visibility = Visibility.Visible;
                txtWebsite1.Visibility = Visibility.Visible;
                txtWebsite2.Visibility = Visibility.Visible;

                gridTbCompanyInfo1.Visibility = Visibility.Collapsed;
                gridTbCompanyInfo2.Visibility = Visibility.Collapsed;
                gridTbCompanyInfo3.Visibility = Visibility.Collapsed;
            }
        }

        private void navigateToPage(object sender, MouseButtonEventArgs e)
        {
            Grid grid = sender as Grid;
            string name = grid.Name;
            String uri = "SettingPages/" + name + "Page";

            switch (name)
            {
                case "Setting":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new SettingPage());
                        }
                    };
                    break;
                case "Profile":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new ProfilePage());
                        }
                    };
                    break;
                case "SecurityInformation":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new SecurityInformationPage());
                        }
                    };
                    break;
                case "ActivityLog":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new ActivityLogPage());
                        }
                    };
                    break;
                case "ListMember":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new ListMemberPage());
                        }
                    };
                    break;
            }
        }

        private void NavigateToUserRightsPage(object sender, MouseButtonEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(HomeView))
                {
                    (window as HomeView).MainContent.Navigate(new UserRightsPage());
                }
            }
        }
    }
}
