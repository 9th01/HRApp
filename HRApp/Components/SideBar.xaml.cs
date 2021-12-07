using HRApp.Pages.AdministrationPages.EmployeeManagerPages;
using HRApp.Pages.AdministrationPages.PersonalChangePages;
using HRApp.Pages.AdministrationPages.RegulationsPoliciesPages;
using HRApp.Pages.HomePages;
using HRApp.Pages.HRReportPages.HRReportPages;
using HRApp.Pages.ManageRecruitmentPages.ListOfCandidatesPages;
using HRApp.Pages.ManageRecruitmentPages.PerformRecruitmentPages;
using HRApp.Pages.ManageRecruitmentPages.RecruitmentProcessPages;
using HRApp.Pages.RecentDeletedData;
using HRApp.Pages.SalaryAndBenefitPages.BonusPages;
using HRApp.Pages.SalaryAndBenefitPages.ViolationsPages;
using HRApp.Pages.SettingPages;
using HRApp.Pages.TrainingAndDevelopingPages.JobPositionPages;
using HRApp.Pages.TrainingAndDevelopingPages.TrainingProcessPages;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HRApp.Components
{
    /// <summary>
    /// Interaction logic for SideBar.xaml
    /// </summary>
    public partial class SideBar : UserControl
    {
        public Dictionary<string, bool> dictionary = new Dictionary<string, bool>();

        public Dictionary<string, bool> dictionaryExtra = new Dictionary<string, bool>();

        public static readonly DependencyProperty MainItemProperty =
         DependencyProperty.Register("MainItem", typeof(string), typeof(SideBar), new
            PropertyMetadata("", new PropertyChangedCallback(MainItemChanged)));

        public string MainItem
        {
            get { return (string)GetValue(MainItemProperty); }
            set { SetValue(MainItemProperty, value); }
        }

        private static void MainItemChanged(DependencyObject d,
           DependencyPropertyChangedEventArgs e)
        {
            SideBar sideBar = d as SideBar;
            sideBar.MainItemChanged(e);
        }

        private void MainItemChanged(DependencyPropertyChangedEventArgs e)
        {
            // tbTest.Text = e.NewValue.ToString();
            string option = e.NewValue.ToString();
            SetOption(option);
        }


        public static readonly DependencyProperty ExtraItemProperty =
         DependencyProperty.Register("ExtraItem", typeof(string), typeof(SideBar), new
            PropertyMetadata("", new PropertyChangedCallback(ExtraItemChanged)));

        public string ExtraItem
        {
            get { return (string)GetValue(ExtraItemProperty); }
            set { SetValue(ExtraItemProperty, value); }
        }

        private static void ExtraItemChanged(DependencyObject d,
           DependencyPropertyChangedEventArgs e)
        {
            SideBar sideBar = d as SideBar;
            sideBar.ExtraItemChanged(e);
        }

        private void ExtraItemChanged(DependencyPropertyChangedEventArgs e)
        {
            // tbTest.Text = e.NewValue.ToString();
            string option = e.NewValue.ToString();
            SetOptionExtra(option);
        }



        public SideBar()
        {
            InitializeComponent();
            SetupSideBar();
        }

        private void SetupSideBar()
        {
            dictionary.Add("Home", false);
            dictionary.Add("ManageRecruitmentParent", false);
            dictionary.Add("salary_and_benifits", false);
            dictionary.Add("administration", false);
            dictionary.Add("training_and_developing", false);
            dictionary.Add("Chart", false);
            dictionary.Add("HRReport", false);
            dictionary.Add("Setting", false);
            dictionary.Add("digital_conversion", false);
            dictionary.Add("RecentDeletedData", false);
            dictionary[MainItem] = true;

            dictionaryExtra.Add("RecruitmentProcess", false);
            dictionaryExtra.Add("PerformRecruitment", false);
            dictionaryExtra.Add("ListOfCandidates", false);
            dictionaryExtra.Add("EmployeeManager", false);
            dictionaryExtra.Add("RegulationsPolicies", false);
            dictionaryExtra.Add("PersonalChange", false);
            dictionaryExtra.Add("JobPosition", false);
            dictionaryExtra.Add("TrainingProcess", false);
            dictionaryExtra.Add("SalaryAndBenefit", false);
            dictionaryExtra.Add("Violation", false);
            if (dictionaryExtra.ContainsKey(ExtraItem))
            {
                dictionaryExtra[ExtraItem] = true;
            }

            SetStatusSideBar();
            SetStatusSideBarExtra();
        }

        private void manage_recruitment_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = ManageRecruitment.Height;
            animation.To = ManageRecruitment.Height == 0 ? 132 : 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(300));
            ManageRecruitment.BeginAnimation(HeightProperty, animation);
        }

        private void salary_and_benifits_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = salary_and_benifits_expland.Height;
            animation.To = salary_and_benifits_expland.Height == 0 ? 264 : 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(400));
            salary_and_benifits_expland.BeginAnimation(HeightProperty, animation);
        }

        private void administration_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = administration_expland.Height;
            animation.To = administration_expland.Height == 0 ? 484 : 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(600));
            administration_expland.BeginAnimation(HeightProperty, animation);
        }

        private void training_and_developing_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = training_and_developing_expland.Height;
            animation.To = training_and_developing_expland.Height == 0 ? 132 : 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(300));
            training_and_developing_expland.BeginAnimation(HeightProperty, animation);
        }

        private void digital_conversion_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = digital_conversion_expland.Height;
            animation.To = digital_conversion_expland.Height == 0 ? 176 : 0;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(300));
            digital_conversion_expland.BeginAnimation(HeightProperty, animation);
        }

        private void item_main_MouseMove(object sender, MouseEventArgs e)
        {
            Grid parent = sender as Grid;
            string name = parent.Name;
            SetColorMainItem(name);

        }

        private void item_main_MouseLeave(object sender, MouseEventArgs e)
        {
            Grid parent = sender as Grid;
            string name = parent.Name;
            UnSetColorMainItem(name);
        }

        
        // hàm chọn 1 main item
        private void SetColorMainItem(string name)
        {
            if (name == "") return;
            var converter = new BrushConverter();
            Grid parent = (Grid)this.FindName(name);
            Grid gridChildren = (Grid)parent.Children[1];
            gridChildren.Background = (Brush)converter.ConvertFromString("#F1F9FC");

            var textBlock = gridChildren.Children.OfType<TextBlock>().FirstOrDefault();
            textBlock.Foreground = (Brush)converter.ConvertFromString("#4C5BD4");

            Grid grid = (Grid)gridChildren.Children[1];
            grid.Visibility = Visibility.Visible;
        }

        // hàm bỏ chọn 1 main item
        private void UnSetColorMainItem(string name)
        {
            if (dictionary[name] == true || name =="") return;
            Grid parent = (Grid)this.FindName(name);
            Grid gridChildren = (Grid)parent.Children[1];
            var textBlock = gridChildren.Children.OfType<TextBlock>().FirstOrDefault();
            var converter = new BrushConverter();
            gridChildren.Background = (Brush)converter.ConvertFromString("#FFFFFF");
            textBlock.Foreground = (Brush)converter.ConvertFromString("#474747");
            Grid grid = (Grid)gridChildren.Children[1];
            grid.Visibility = Visibility.Collapsed;
        }

        // hàm set trạng thái cho sidebar
        private void SetStatusSideBar()
        {
            foreach (var item in dictionary)
            {
                if (item.Value == true)
                {
                    SetColorMainItem(item.Key);
                }
                else
                {
                    UnSetColorMainItem(item.Key);
                }
            }
        }

        private void SetOption(string name)
        {
            foreach (var item in dictionary)
            {
                if (item.Value == true)
                {
                    dictionary[item.Key] = false;
                    break;
                }
            }
            dictionary[name] = true;
            MainItem = name;
            SetStatusSideBar();
        }

        private void item_exta_MouseMove(object sender, MouseEventArgs e)
        {
            SetColorExtraItem(sender);
        }

        private void item_exta_MouseLeave(object sender, MouseEventArgs e)
        {
            UnSetColorExtraItem(sender);
        }

        // hàm chọn 1 main item
        private void SetColorExtraItem(object sender)
        {
            var converter = new BrushConverter();
            Grid grid = sender as Grid;
            grid.Background = (Brush)converter.ConvertFromString("#FFF6E5");
            Grid gridChild = (Grid)grid.Children[1];
            Grid gridRight = (Grid)gridChild.Children[1];
            gridRight.Visibility = Visibility.Visible;
        }

        // hàm bỏ chọn 1 main item
        private void UnSetColorExtraItem(object sender)
        {
            Grid grid = sender as Grid;
            string name = grid.Name;
            if (name != "")
            {
                if (dictionaryExtra.ContainsKey(name))
                {
                    if (dictionaryExtra[name] == true) return;
                }
            }
            var converter = new BrushConverter();
            grid.Background = (Brush)converter.ConvertFromString("#FFFFFF");
            Grid gridChild = (Grid)grid.Children[1];
            Grid gridRight = (Grid)gridChild.Children[1];
            gridRight.Visibility = Visibility.Collapsed;
        }


        private void SetStatusSideBarExtra()
        {
            foreach (var item in dictionaryExtra)
            {
                string name = item.Key;
                Grid grid = (Grid)this.FindName(name);
                if (item.Value == true)
                {
                    SetColorExtraItem(grid);
                }
                else
                {
                    UnSetColorExtraItem(grid);
                }
            }
        }

        private void SetOptionExtra(string name)
        {
            foreach (var item in dictionaryExtra)
            {
                if (item.Value == true)
                {
                    dictionaryExtra[item.Key] = false;
                    break;
                }
            }

            if (dictionaryExtra.ContainsKey(name))
            {
                dictionaryExtra[name] = true;
            }
            ExtraItem = name;
            SetStatusSideBarExtra();
        }

        private void navigateToPage(object sender, MouseButtonEventArgs e)
        {
            Grid grid = sender as Grid;
            string name = grid.Name;
            SetOption(name);
            SetOptionExtra("");
            switch (name)
            {
                case "Home":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new HomePage());
                        }
                    };
                    break;
                case "Setting":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new SettingPage());
                        }
                    };
                    break;
                case "RecentDeletedData":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new DeleteData1Page());
                        }
                    };
                    break;
                case "HRReport":
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new HRReportPage());
                        }
                    };
                    break;
            }
        }

        private void navigateToPageItem(object sender, MouseButtonEventArgs e)
        {
            DependencyObject obj = sender as DependencyObject;
            Grid grid = (Grid)obj;
            string name = grid.Name;
            SetOptionExtra(name);
            switch (name)
            {
                case "RecruitmentProcess":
                    SetOption("ManageRecruitmentParent");
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new RecruitmentProcessPage());
                        }
                    };
                    break;
                case "PerformRecruitment":
                    SetOption("ManageRecruitmentParent");
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new PerformRecruitmentPage());
                        }
                    };
                    break;
                case "ListOfCandidates":
                    SetOption("ManageRecruitmentParent");
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new ListOfCandidatesPage());
                        }
                    };
                    break;
                case "EmployeeManager":
                    SetOption("administration");
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new ListOfEmployeePage());
                        }
                    };
                    break;
                case "RegulationsPolicies":
                    SetOption("administration");
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new WorkingRegulationsPage());
                        }
                    };
                    break;
                case "PersonalChange":
                    SetOption("administration");
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new UpDownSalaryPage());
                        }
                    };
                    break;
                case "JobPosition":
                    SetOption("training_and_developing");
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new JobPositionPage());
                        }
                    };
                    break;
                case "TrainingProcess":
                    SetOption("training_and_developing");
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new TrainingProcessPage());
                        }
                    };
                    break;
                case "SalaryAndBenefit":
                    SetOption("salary_and_benifits");
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new PersonalBonusPage());
                        }
                    };
                    break;
                case "Violation":
                    SetOption("salary_and_benifits");
                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.GetType() == typeof(HomeView))
                        {
                            (window as HomeView).MainContent.Navigate(new PersonalViolationsPage());
                        }
                    };
                    break;
            }
        }
    }
}
