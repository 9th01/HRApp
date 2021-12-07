using HRApp.Pages.LoginPages;
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
using System.Windows.Shapes;

namespace HRApp.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public Scale scale;

        public LoginView()
        {
            InitializeComponent();

            MainContent.NavigationService.Navigate(new LoginEmployeePage(this));
        }

        private void Minimimize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            this.WindowState = WindowState.Minimized;
        }
        private void NomarlSize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Normal;
            NomarlSize.Visibility = Visibility.Collapsed;
            Maximimize.Visibility = Visibility.Visible;
            logoInTitle.Margin = new Thickness(0, 0, 0, 0);
            pageTitle.Height = 40;
            //pageDisplay.Margin = new Thickness(0, 25, 0, 0);
        }

        private void Maximimize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            NomarlSize.Visibility = Visibility.Visible;
            Maximimize.Visibility = Visibility.Collapsed;
            pageTitle.Height = 45;
            logoInTitle.Margin = new Thickness(0, 5, 0, 0);
            //pageDisplay.Margin = new Thickness(0, 30, 0, 0);
        }

        private void CloseWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void pageTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void upload_size(object sender, SizeChangedEventArgs e)
        {
            // reponsive left_background
            if (Screen.ActualWidth > 1366)
            {
                left_background.Width = new GridLength(1, GridUnitType.Star);
                background_gradien_color.Visibility = Visibility.Visible;
            }
            else if (Screen.ActualWidth >= 1024 && Screen.ActualWidth <= 1366)
            {
                left_background.Width = new GridLength(384 + (Screen.ActualWidth - 1024) * 299 / 342);
                background_gradien_color.Visibility = Visibility.Visible;
            }
            else if (Screen.ActualWidth < 1024 && Screen.ActualWidth >= 768)
            {
                left_background.Width = new GridLength(248 + (Screen.ActualWidth - 768) * 136 / 256);
                background_gradien_color.Visibility = Visibility.Visible;
            }
            else
            {
                left_background.Width = new GridLength(0);
                background_gradien_color.Visibility = Visibility.Hidden;
            }

            scale = new Scale(Screen.ActualWidth / 1366, Screen.ActualWidth / 1366);
            this.DataContext = scale;

        }

        public class Scale
        {
            public double X_image { get; set; }

            public double Y_image { get; set; }

            public Scale(double X_image, double Y_image)
            {
                this.X_image = X_image;
                this.Y_image = Y_image;
            }
        }
    }
}