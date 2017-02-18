using Citicon.Data;
using Citicon.TimeLog.ViewModels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Citicon.TimeLog.Views
{
    /// <summary>
    /// Interaction logic for LogSummaryView.xaml
    /// </summary>
    public partial class LogSummaryView : UserControl
    {
        public LogSummaryView()
        {
            InitializeComponent();

        }

        private LogSummaryViewModel ViewModel => DataContext as LogSummaryViewModel;

        public Employee CurrentEmployee
        {
            get { return (Employee)GetValue(CurrentEmployeeProperty); }
            set
            {
                ViewModel.Employee = value;
                SetValue(CurrentEmployeeProperty, value);
            }
        }
        
        public static readonly DependencyProperty CurrentEmployeeProperty = DependencyProperty.Register(nameof(CurrentEmployee), typeof(Employee), typeof(LogSummaryView), new PropertyMetadata(null));
        
        public async Task LogEmployeeAsync(EmployeeLogin loginInfo)
        {
            await ViewModel.LogEmployeeAsync(loginInfo);
        }
        
        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
