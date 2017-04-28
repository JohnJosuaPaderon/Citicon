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
            finally
            {
                range = null;
            }
        }

        private async Task GetDeliveryListAsync()
        {
            DeliveryDataGridView.Rows.Clear();

            if (DriverDataGridView.SelectedRows.Count == 1)
            {
                var driver = DriverDataGridView.SelectedRows[0].Cells[DriverColumn.Name].Value as Employee;
                var range = new DateTimeRange(RangeStartDateTimePicker.Value, RangeEndDateTimePicker.Value);

                try
                {
                    var deliveries = await DeliveryManager.GetTripReportDeliveryListByDriverAsync(range, driver);

                    if (deliveries != null && deliveries.Any())
                    {
                        foreach (var delivery in deliveries)
                        {
                            AddToUI(delivery);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    range = null;
                }
            }
        }

        private void AddToUI(Delivery delivery)
        {
            if (delivery != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.ProjectDesign });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.DeliveryDate });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.Project });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.DeliveryReceiptNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.TransitMixer });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.Project?.Location });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.Route });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.Route?.Rate });
                DeliveryDataGridView.Rows.Add(row);
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

        private async void DriverDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetDeliveryListAsync();
        }
    }
}
