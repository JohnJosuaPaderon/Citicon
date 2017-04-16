using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.PayrollIntegration.Forms
{
    public partial class HolidayManagementForm : Form
    {
        public HolidayManagementForm()
        {
            InitializeComponent();

            HolidayFilterComboBox.Items.Add(HolidaySearchFilter.All);
            HolidayFilterComboBox.Items.Add(HolidaySearchFilter.Past);
            HolidayFilterComboBox.Items.Add(HolidaySearchFilter.Incoming);

            HolidayManager = new HolidayManager();
        }

        private HolidayManager HolidayManager;

        private void HolidayManagementForm_Load(object sender, EventArgs e)
        {
            HolidayFilterComboBox.SelectedItem = HolidaySearchFilter.Incoming;
        }

        private async void HolidayFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetHolidayListAsync();
        }

        private async Task GetHolidayListAsync()
        {
            HolidayDataGridView.Rows.Clear();

            if (HolidayFilterComboBox.SelectedItem is HolidaySearchFilter searchFilter)
            {
                try
                {
                    var holidays = await HolidayManager.GetHolidayListAsync(searchFilter);

                    if (holidays != null && holidays.Any())
                    {
                        foreach (var holiday in holidays)
                        {
                            AddToUI(holiday);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void AddToUI(Holiday holiday)
        {
            if (holiday != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = holiday });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = holiday.DateOccur });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = holiday.Type });
                HolidayDataGridView.Rows.Add(row);
            }
        }
    }
}
