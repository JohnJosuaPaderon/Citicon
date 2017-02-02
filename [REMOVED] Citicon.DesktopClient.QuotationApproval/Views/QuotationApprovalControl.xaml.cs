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

namespace Citicon.DesktopClient.QuotationApproval.Views
{
    /// <summary>
    /// Interaction logic for QuotationApprovalControl.xaml
    /// </summary>
    public partial class QuotationApprovalControl : UserControl
    {
        public QuotationApprovalControl()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler BackToPrevious;

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            BackToPrevious?.Invoke(this, new RoutedEventArgs());
        }
    }
}
