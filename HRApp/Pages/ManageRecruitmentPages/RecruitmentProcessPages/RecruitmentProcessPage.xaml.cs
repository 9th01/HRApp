using HRApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

namespace HRApp.Pages.ManageRecruitmentPages.RecruitmentProcessPages
{
    /// <summary>
    /// Interaction logic for RecruitmentProcessPage.xaml
    /// </summary>  
    public partial class RecruitmentProcessPage : Page, INotifyPropertyChanged
    {
        private bool show;

        public bool Show
        {
            get { return show; }
            set
            {
                show = value;
                OnPropertyChanged("Show");
            }
        }
        public RecruitmentProcessPage()
        {
            InitializeComponent();
            DataContext = this;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        private void navigateToDetail(object sender, MouseButtonEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(HomeView))
                {
                    (window as HomeView).MainContent.Navigate(new RecruitmentProcessDetailPage());
                }
            }
        }

        private void page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(page.ActualWidth < 800)
            {
                Show = false;
            }
            else
            {
                Show = true;
            }
        }
    }
}
