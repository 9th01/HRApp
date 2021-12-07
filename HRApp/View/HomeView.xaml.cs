using HRApp.Pages.HomePages;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HRApp.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : Window, INotifyPropertyChanged
    {
        Thickness margin;
        private string mainItem;

        public string MainItem
        {
            get { return mainItem; }
            set
            {
                mainItem = value;
                OnPropertyChanged("MainItem");
            }
        }

        private string extraItem;

        public string ExtraItem
        {
            get { return extraItem; }
            set
            {
                extraItem = value;
                OnPropertyChanged("ExtraItem");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }
        public HomeView()
        {
            InitializeComponent();
            MainContent.NavigationService.Navigate(new HomePage());
            MainItem = "Home";
            ExtraItem = "";
            DataContext = this;
            //MainContent.NavigationService.Navigate(new HomePage("100"));
            //HomePage.onNameSend += PassData;
        }

        private void Frame_LoadCompleted(object sender, NavigationEventArgs e)

        {

            (e.Content as HomePage).Tag = this;

        }

        //private void NavigationService_LoadCompleted(object sender, NavigationEventArgs e)
        //{
        //    string str = (string)e.ExtraData;
        //}

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

        public void PassData(string data)

        {
            MessageBox.Show(data);
        }

        private void HomeViewSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(homeView.ActualWidth < 1366)
            {
                margin = new Thickness(60 - (1366 - homeView.ActualWidth) / 600 * 40, 0, 60 - (1366 - homeView.ActualWidth) / 600 * 40, 0);
            }
            else
            {
                margin = new Thickness(60, 0, 60, 0);
            }
            gridContent.Margin = margin;

            if(homeView.ActualWidth < 1058)
            {
                sideBar.Visibility = Visibility.Collapsed;
                iconShowSideBar.Visibility = Visibility.Visible;
            }
            else
            {
                sideBar.Visibility = Visibility.Visible;
                iconShowSideBar.Visibility = Visibility.Collapsed;
                CloseSideBar();
            }
        }

        private void CloseSideBar(object sender, MouseButtonEventArgs e)
        {
            CloseSideBar();
        }

        private void ShowSideBar(object sender, MouseButtonEventArgs e)
        {
            ShowSideBar();
        }

        private void CloseSideBar()
        {
            containerSideBar.Visibility = Visibility.Collapsed;
        }

        private void ShowSideBar()
        {
            containerSideBar.Visibility = Visibility.Visible;
        }
    }
}
