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

namespace HRApp.Pages.ManageRecruitmentPages.PerformRecruitmentPages
{
    /// <summary>
    /// Interaction logic for PerformRecruitmentPage.xaml
    /// </summary>
    public partial class PerformRecruitmentPage : Page, INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

        List<ComboData> ListData;

        public PerformRecruitmentPage()
        {
            InitializeComponent();
            ListData = new List<ComboData>();
            ListData.Add(new ComboData { Id = 1, Value = "Nhân sự tuyển dụng" });
            ListData.Add(new ComboData { Id = 2, Value = "Nhân sự thử việc" });
            ListData.Add(new ComboData { Id = 3, Value = "Three" });
            ListData.Add(new ComboData { Id = 4, Value = "Four" });
            ListData.Add(new ComboData { Id = 5, Value = "Five" });

            cbx1.ItemsSource = ListData;
            cbx1.DisplayMemberPath = "Value";
            cbx1.SelectedValuePath = "Id";

            cbx1.SelectedValue = "1";
            DataContext = this;
        }

        private void navigateToPage(object sender, MouseButtonEventArgs e)
        {
            Grid grid = sender as Grid;
            string name = grid.Name;
            switch (name)
            {
                case "PerformRecruitment":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new PerformRecruitmentPage());
                        }
                    };
                    break;
                case "RecruitmentInformation":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new RecruitmentInformationPage());
                        }
                    };
                    break;
                case "RecruitmentConnection":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new RecruitmentConnectionPage());
                        }
                    };
                    break;
                case "RecruitmentFee":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new RecruitmentFeePage());
                        }
                    };
                    break;
            }
        }

        private void page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (page.ActualWidth < 900)
            {
                Show = false;
            }
            else
            {
                Show = true;
            }
        }
    }

    public class ComboData
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}

