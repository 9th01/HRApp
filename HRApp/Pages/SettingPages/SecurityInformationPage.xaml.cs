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
    /// Interaction logic for SecurityInformationPage.xaml
    /// </summary>
    public partial class SecurityInformationPage : Page
    {
        private bool isShowDevices = false;

        private bool isShowChangePassword = false;

        public SecurityInformationPage()
        {
            InitializeComponent();
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

        private void showHideDevices(object sender, MouseButtonEventArgs e)
        {
            if (!isShowDevices)
            {
                grid_show_devices.Visibility = Visibility.Collapsed;
                grid_hidden_devices.Visibility = Visibility.Visible;
                grid_more_devices.Visibility = Visibility.Visible;
            }
            else
            {
                grid_show_devices.Visibility = Visibility.Visible;
                grid_hidden_devices.Visibility = Visibility.Collapsed;
                grid_more_devices.Visibility = Visibility.Collapsed;
            }

            isShowDevices = !isShowDevices;
        }

        private void showHideChangePassword(object sender, MouseButtonEventArgs e)
        {
            if (isShowChangePassword)
            {
                grid_change_password.Visibility = Visibility.Collapsed;
                change_password_arrow_down.Visibility = Visibility.Visible;
                change_password_arrow_up.Visibility = Visibility.Collapsed;

            }
            else
            {
                grid_change_password.Visibility = Visibility.Visible;
                change_password_arrow_down.Visibility = Visibility.Collapsed;
                change_password_arrow_up.Visibility = Visibility.Visible;
            }

            
            isShowChangePassword = !isShowChangePassword;
        }
    }
}
