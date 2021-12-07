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

namespace HRApp.Pages.RecentDeletedData
{
    /// <summary>
    /// Interaction logic for DeleteData1Page.xaml
    /// </summary>
    public partial class DeleteData1Page : Page, INotifyPropertyChanged
    {
        bool flag = false;

        public bool Flag
        {
            get { return flag; }
            set
            {
                flag = value;
                OnPropertyChanged("Flag");
            }
        }
        public DeleteData1Page()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }
        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (huhu.ActualWidth > 800)
            {
                Flag = false;
            }
            else
            {
                Flag = true;
            }
        }
    }
}