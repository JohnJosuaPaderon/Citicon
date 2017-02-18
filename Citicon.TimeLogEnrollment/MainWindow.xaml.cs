using Citicon.CommonUi.Controls;
using Citicon.DataManager;
using MahApps.Metro.Controls;
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
    }
}
