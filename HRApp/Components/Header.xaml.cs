using Microsoft.Win32;
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

namespace HRApp.Components
{
    /// <summary>
    /// Interaction logic for Header.xaml
    /// </summary>
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imageAvatar.ImageSource = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void HeaderSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(header.ActualWidth < 1058)
            {
                tbxName.Visibility = Visibility.Collapsed;
                //iconShowSideBar.Visibility = Visibility.Visible;
            }
            else
            {
                tbxName.Visibility = Visibility.Visible;
                //iconShowSideBar.Visibility = Visibility.Collapsed;
            }
        }
    }
}
