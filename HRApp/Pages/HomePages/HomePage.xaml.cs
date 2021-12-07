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

namespace HRApp.Pages.HomePages
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {

        //public delegate void SendName(string Name);

        //public static event SendName onNameSend;

        Thickness thicknessColumn1L = new Thickness(0, 49, 0, 0);
        Thickness thicknessColmn1S = new Thickness(0, 180, 0, 0);
        Thickness thicknessGridHeadL = new Thickness(0, 50, 20, 0);
        Thickness thicknessGridHeadS = new Thickness(0, 50, 0, 0);

        public HomePage()
        {
            InitializeComponent();
            //txtTest.Text = x;
        }



        private void NavigationService_LoadCompleted(object sender, NavigationEventArgs e)
        {
            string str = (string)e.ExtraData;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //onNameSend("Name to Send");
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(homePage.ActualWidth < 900)
            {
                column1.Margin = thicknessColmn1S;
                Grid.SetColumnSpan(gridHead, 2);
                gridHead.Margin = thicknessGridHeadS;
            }
            else
            {
                column1.Margin = thicknessColumn1L;
                Grid.SetColumnSpan(gridHead, 1);
                gridHead.Margin = thicknessGridHeadL;
            }
        }
    }
}
