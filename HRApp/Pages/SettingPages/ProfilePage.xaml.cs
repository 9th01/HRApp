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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        private bool isEditPersonalInfo = false;

        private bool isAddFamilyMember = false;
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void editButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isEditPersonalInfo)
            {
                hideAllTbPersonalInfo();
            }
            else
            {
                showAllTbPersonalInfo();
            }

            isEditPersonalInfo = !isEditPersonalInfo;
        }

        // ẩn form chỉnh sửa thông tin cá nhân
        private void hideAllTbPersonalInfo()
        {
            gridTbAcademicLevel.Visibility = Visibility.Collapsed;
            gridTbAddress.Visibility = Visibility.Collapsed;
            gridTbCMND.Visibility = Visibility.Collapsed;
            gridTbCurriculumVitae.Visibility = Visibility.Collapsed;
            gridTbDateOfBirth.Visibility = Visibility.Collapsed;
            gridTbDateStartWork.Visibility = Visibility.Collapsed;
            gridTbEmail.Visibility = Visibility.Collapsed;
            gridTbHomeTown.Visibility = Visibility.Collapsed;
            gridTbMaritalStatus.Visibility = Visibility.Collapsed;
            gridTbPhoneNumber.Visibility = Visibility.Collapsed;
            gridTbRestrationBook.Visibility = Visibility.Collapsed;
            gridTbSex.Visibility = Visibility.Collapsed;
            gridBtnPersonalInfo.Visibility = Visibility.Collapsed;
        }


        // hiện form chỉnh sửa thông tin cá nhân
        private void showAllTbPersonalInfo()
        {
            gridTbAcademicLevel.Visibility = Visibility.Visible;
            gridTbAddress.Visibility = Visibility.Visible;
            gridTbCMND.Visibility = Visibility.Visible;
            gridTbCurriculumVitae.Visibility = Visibility.Visible;
            gridTbDateOfBirth.Visibility = Visibility.Visible;
            gridTbDateStartWork.Visibility = Visibility.Visible;
            gridTbEmail.Visibility = Visibility.Visible;
            gridTbHomeTown.Visibility = Visibility.Visible;
            gridTbMaritalStatus.Visibility = Visibility.Visible;
            gridTbPhoneNumber.Visibility = Visibility.Visible;
            gridTbRestrationBook.Visibility = Visibility.Visible;
            gridTbSex.Visibility = Visibility.Visible;
            gridBtnPersonalInfo.Visibility = Visibility.Visible;
        }

        private void btnAddPersonal_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isAddFamilyMember)
            {
                gridFormFamilyMember.Visibility = Visibility.Collapsed;
                gridBtnAddFamilyMember.Visibility = Visibility.Collapsed;
            }
            else
            {
                gridFormFamilyMember.Visibility = Visibility.Visible;
                gridBtnAddFamilyMember.Visibility = Visibility.Visible;
            }

            isAddFamilyMember = !isAddFamilyMember;
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
    }
}
