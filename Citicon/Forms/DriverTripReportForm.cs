using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
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

        public IEnumerable<Delivery> Deliveries { get; private set; }

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
                    Deliveries = await DeliveryManager.GetTripReportDeliveryListByDriverAsync(range, driver);

                    if (Deliveries != null && Deliveries.Any())
                    {
                        foreach (var delivery in Deliveries)
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

        private void ExportTripReport(TripReportMode mode)
        {
            if (Deliveries != null && Deliveries.Any())
            {
                Employee driver = null;
                if (mode == TripReportMode.Driver && DriverDataGridView.SelectedRows[0].Cells[DriverColumn.Name].Value is Employee tempDriver && Deliveries.Any(d => d.Driver == tempDriver))
                {
                    tempDriver = driver;
                }
                else
                {
                    MessageBox.Show("No driver.");
                    return;
                }

                TripReport tripReport = null;
                var deliveryDateRange = new DateTimeRange(RangeStartDateTimePicker.Value, RangeEndDateTimePicker.Value);

                switch (mode)
                {
                    case TripReportMode.NotSet:
                        MessageBox.Show("Exporting information is not set.");
                        break;
                    case TripReportMode.All:
                        tripReport = TripReport.Extract(deliveryDateRange, Deliveries);
                        break;
                    case TripReportMode.Driver:
                        tripReport = TripReport.ExtractDriver(deliveryDateRange, driver, Deliveries);
                        break;
                }

                if (tripReport != null)
                {

                }
                else
                {
                    MessageBox.Show("Nothing to export.");
                }
            }
            else
            {
                MessageBox.Show("No deliveries.");
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

        private void ExportDriverButton_Click(object sender, EventArgs e)
        {
            ExportTripReport(TripReportMode.Driver);
        }

        private void ExportAllButton_Click(object sender, EventArgs e)
        {
            ExportTripReport(TripReportMode.All);
        }
    }
}
