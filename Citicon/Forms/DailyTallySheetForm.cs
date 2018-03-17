using Citicon.Data;
using Citicon.DataManager;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class DailyTallySheetForm : Form
    {
        public DailyTallySheetForm()
        {
            InitializeComponent();
        }

        private async Task GetProjectDesignListAsync()
        {
            ProjectDesignDataGridView.Rows.Clear();

            var projectDesigns = await ProjectDesignManager.GetListWithDeliveryAsync(SelectDateTimePicker.Value);

            if (projectDesigns != null && projectDesigns.Any())
            {
                foreach (var projectDesign in projectDesigns)
                {
                    AddToUI(projectDesign);
                }
            }
        }

        private async Task GetDeliveryListAsync()
        {
            DeliveryDataGridView.Rows.Clear();

            if (ProjectDesignDataGridView.SelectedRows.Count == 1)
            {
                if (ProjectDesignDataGridView.SelectedRows[0].Cells[ProjectDesignColumn.Name].Value is ProjectDesign projectDesign)
                {
                    var deliveries = await DeliveryManager.GetListByProjectDesignAndDeliveryDateAsync(projectDesign, SelectDateTimePicker.Value);

                    if (deliveries != null && deliveries.Any())
                    {
                        foreach (var delivery in deliveries)
                        {
                            AddToUI(delivery);
                        }
                    }
                }
            }
        }

        private void AddToUI(ProjectDesign projectDesign)
        {
            if (projectDesign != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };

                row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.Project });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.Project?.Client });

                ProjectDesignDataGridView.Rows.Add(row);
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
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.Load });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.DeliveryReceiptNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.TransitMixer });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.Driver });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.Volume });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.PlantLeave });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.PlantArrive });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = delivery.ServiceEngineer });

                DeliveryDataGridView.Rows.Add(row);
            }
        }

        private async Task ExportAsync()
        {
            if (ProjectDesignDataGridView.Rows.Count > 0)
            {
                var tallySheet = new TallySheetReport
                {
                    DeliveryDate = SelectDateTimePicker.Value,
                    Dispatcher = "R. CASTILLEJO"
                };

                foreach (DataGridViewRow row in ProjectDesignDataGridView.Rows)
                {
                    if (row.Cells[ProjectDesignColumn.Name].Value is ProjectDesign projectDesign)
                    {
                        var tallySheetItem = new TallySheetItem(projectDesign);

                        var deliveries = await DeliveryManager.GetListByProjectDesignAndDeliveryDateAsync(projectDesign, tallySheet.DeliveryDate);

                        if (deliveries != null && deliveries.Any())
                        {
                            foreach (var delivery in deliveries)
                            {
                                tallySheetItem.Deliveries.Add(delivery);
                            }
                        }

                        tallySheet.Items.Add(tallySheetItem);
                    }
                }

                try
                {
                    var filePath = await DeliveryManager.ExportDailyTallySheetAsync(tallySheet);

                    if (File.Exists(filePath))
                    {
                        MessageBox.Show("Tally sheet has been exported.");
                    }
                    else
                    {
                        MessageBox.Show("An error occured on exporting tally sheet.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nothing to export.");
            }
        }

        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            await GetProjectDesignListAsync();
        }
        private async void ProjectDesignDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetDeliveryListAsync();
        }

        private void CancelPrintButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ExportButton_Click(object sender, EventArgs e)
        {
            await ExportAsync();
        }
    }
}
