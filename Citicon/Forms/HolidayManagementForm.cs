using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.Dialogs;
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

        private async Task DeleteAsync()
        {
            if (HolidayDataGridView.SelectedRows.Count == 1)
            {
                var row = HolidayDataGridView.SelectedRows[0];
                var dialogResult = MessageBox.Show("Do you really want to delete the selected holiday?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        var holiday = await HolidayManager.DeleteAsync(row.Cells[HolidayColumn.Name].Value as Holiday);

                        if (holiday != null)
                        {
                            HolidayDataGridView.Rows.Remove(row);
                            MessageBox.Show("Successfully deleted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    } 
                }
            }
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void AddNewButton_Click(object sender, EventArgs e)
        {
            var dialog = new AddEditHolidayDialog();
            dialog.ShowDialog();
            dialog = null;
            await GetHolidayListAsync();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (HolidayDataGridView.SelectedRows.Count == 1)
            {
                var dialog = new AddEditHolidayDialog(HolidayDataGridView.SelectedRows[0].Cells[HolidayColumn.Name].Value as Holiday);
                dialog.ShowDialog();
                dialog = null;
                await GetHolidayListAsync();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await DeleteAsync();
        }
    }
}
