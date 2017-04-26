using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class DriverTripReportForm : Form
    {
        public DriverTripReportForm()
        {
            InitializeComponent();
        }

        private async Task GetDriverListAsync()
        {
            DriverDataGridView.Rows.Clear();
            var range = new DateTimeRange(RangeStartDateTimePicker.Value, RangeEndDateTimePicker.Value);

            try
            {
                var drivers = await EmployeeManager.GetTripReportDriverListAsync(range);

                if (drivers != null && drivers.Any())
                {
                    foreach (var driver in drivers)
                    {
                        AddToUI(driver);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToUI(Employee driver)
        {
            if (driver != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = driver });
                DriverDataGridView.Rows.Add(row);
            }
        }

        private void DriverTripReportForm_Load(object sender, EventArgs e)
        {

        }

        private async void LoadButton_Click(object sender, EventArgs e)
        {
            await GetDriverListAsync();
        }
    }
}
