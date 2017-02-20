using Citicon.CommonUi.Controls;
using Citicon.Data;
using Citicon.DataManager;
using MahApps.Metro.Controls;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace Citicon.TimeLogEnrollment
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

        private async Task SearchEmployeeAsync(string keyword)
        {
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var employees = await EmployeeManager.SearchEmployeeAsync(keyword);

                if (employees != null)
                {
                    foreach (var item in employees)
                    {
                        SearchBar.SuggestionItems.Add(item);
                    }
                }
            }
        }

        private async void SearchBar_SearchTriggered(object sender, SearchTriggeredEventArgs e)
        {
            await SearchEmployeeAsync(e.Keyword);
        }

        private async void Register_Click(object sender, RoutedEventArgs e)
        {
            await RegisterEmployeeAsync();
        }

        private async Task RegisterEmployeeAsync()
        {
            var employee = SearchBar.SelectedItem as Employee;

            if (employee != null)
            {
                try
                {
                    var loginInfo = await EmployeeManager.RegisterEmployeeLoginAsync(employee);

                    if (loginInfo != null)
                    {
                        MessageBox.Show(string.Format("Employee successfully registered!{0}Login Code : {1}", Environment.NewLine, loginInfo.LoginCode.ToString("000000")), "Registered", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to register.", "Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("No employee to register!", "Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
