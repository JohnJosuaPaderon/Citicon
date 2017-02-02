using MahApps.Metro.Controls;
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

namespace Citicon.DesktopClient.QuotationApproval
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_LoggedIn(object sender, Common.LoggedInEventArgs e)
        {
            MainTransitioner.SelectedIndex = 1;
        }

        private void QuotationApprovalControl_BackToPrevious(object sender, RoutedEventArgs e)
        {
            MainTransitioner.SelectedIndex = 0;
        }
    }
}
