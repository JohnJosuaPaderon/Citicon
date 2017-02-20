using Citicon.TimeLog.ViewModels;
using MahApps.Metro.Controls;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Citicon.TimeLog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel.LogSummaryView = LogSummaryView;
        }

        private MainWindowViewModel ViewModel => DataContext as MainWindowViewModel;

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ClearAndFocusEmployeeLoginCode();
        }

        private async void EmployeeLoginCode_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                await LogAsync();
            }
            else if (e.Key == Key.Tab)
            {
                e.Handled = true;
            }
            else if (!((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.D0 && e.Key <= Key.D9)))
            {
                e.Handled = true;
            }
        }

        private async Task LogAsync()
        {
            var loginCode = EmployeeLoginCode.Password;

            if (loginCode.Length == 6)
            {
                await ViewModel.GetEmployeeLoginAsync(loginCode);
                await LogSummaryView.LogEmployeeAsync(ViewModel.LoginInfo);
            }

            ClearAndFocusEmployeeLoginCode();
        }

        private void ClearAndFocusEmployeeLoginCode()
        {
            EmployeeLoginCode.Password = string.Empty;
            EmployeeLoginCode.Focus();
        }

        private void EmployeeLoginCode_LostFocus(object sender, RoutedEventArgs e)
        {
            //EmployeeLoginCode.Focus();
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var vm = (LogSummaryViewModel)ViewModel.LogSummaryView.DataContext;
            vm.Dispose();
        }
    }
}
