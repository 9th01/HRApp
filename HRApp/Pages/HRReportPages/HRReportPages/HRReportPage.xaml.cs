using HRApp.View;
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

namespace HRApp.Pages.HRReportPages.HRReportPages
{
    /// <summary>
    /// Interaction logic for HRReportPage.xaml
    /// </summary>
    public partial class HRReportPage : Page, INotifyPropertyChanged
    {
        private double width1;

        public double Width1
        {
            get { return width1; }
            set
            {
                width1 = value;
                OnPropertyChanged("Width1");
            }
        }

        private double width2;

        public double Width2
        {
            get { return width2; }
            set
            {
                width2 = value;
                OnPropertyChanged("Width2");
            }
        }

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        public HRReportPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NavigateToPage(object sender, MouseButtonEventArgs e)
        {
            Border border = sender as Border;
            string name = border.Name;
            switch (name)
            {
                case "NewStaff":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new NewStaffPage());
                        }
                    };
                    break;
            }
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(Page.ActualWidth < 900)
            {
                Width1 = (Page.ActualWidth - 40) / 2;
                Width2 = Page.ActualWidth - 20;
            }
            else
            {
                Width1 = (Page.ActualWidth - 60) / 3;
                Width2 = (Page.ActualWidth - 40) / 2;
            }
        }
    }
}
