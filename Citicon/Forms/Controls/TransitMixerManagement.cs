using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Citicon.DataManager;
using Citicon.Data;
using Citicon.Forms.Dialogs;

namespace Citicon.Forms.Controls
{
    public partial class TransitMixerManagement : UserControl
    {
        public TransitMixerManagement()
        {
            InitializeComponent();
            TransitMixerManager = new TransitMixerManager();
        }

        private TransitMixerManager TransitMixerManager;
        private TransitMixer _SelectedTransitMixer;

        public TransitMixer SelectedTransitMixer
        {
            get { return _SelectedTransitMixer; }
            set
            {
                if (_SelectedTransitMixer != value)
                {
                    _SelectedTransitMixer = value;
                    OnSelectedTransitMixerChanged();
                }
            }
        }

        private void OnSelectedTransitMixerChanged()
        {
            PlateNumberTextBox.Text = SelectedTransitMixer?.PlateNumber;
            VolumeCapacityTextBox.Text = (SelectedTransitMixer?.VolumeCapacity ?? 0).ToString("#,##0.00");
            PhysicalNumberTextBox.Text = SelectedTransitMixer?.PhysicalNumber;

        }

        private async Task LoadListAsync()
        {
            TransitMixerDataGridView.Rows.Clear();

            try
            {
                var transitMixers = await TransitMixerManager.GetListAsync();

                if (transitMixers != null && transitMixers.Any())
                {
                    var rows = ToDataGridViewRows(transitMixers);

                    if (rows != null && rows.Any())
                    {
                        TransitMixerDataGridView.Rows.AddRange(rows);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataGridViewRow[] ToDataGridViewRows(IEnumerable<TransitMixer> transitMixers)
        {
            if (transitMixers != null && transitMixers.Any())
            {
                var list = new List<DataGridViewRow>();

                foreach (var transitMixer in transitMixers)
                {
                    if (transitMixer != null)
                    {
                        list.Add(ToDataGridViewRow(transitMixer));
                    }
                }

                return list.ToArray();
            }
            else
            {
                return null;
            }
        }

        private DataGridViewRow ToDataGridViewRow(TransitMixer transitMixer)
        {
            if (transitMixer != null)
            {
                var row = new DataGridViewRow();
                row.Height = 30;
                row.Cells.Add(new DataGridViewTextBoxCell { Value = transitMixer });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = transitMixer.PlateNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = transitMixer.VolumeCapacity });

                return row;
            }
            else
            {
                return null;
            }
        }

        private async void TransitMixerManagement_Load(object sender, EventArgs e)
        {
            await LoadListAsync();
        }

        private void TransitMixerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (TransitMixerDataGridView.SelectedRows.Count == 1)
            {
                SelectedTransitMixer = TransitMixerDataGridView.SelectedRows[0].Cells[TransitMixer_Column.Name].Value as TransitMixer;
            }
            else
            {
                SelectedTransitMixer = null;
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (SelectedTransitMixer != null)
            {
                var dialogResult = MessageBox.Show("Do you really want to delete the selected Transaction Mixer?", "Delete Transit Mixer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        var transitMixer = await TransitMixerManager.DeleteAsync(SelectedTransitMixer);

                        if (transitMixer != null)
                        {
                            MessageBox.Show("Successfully deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void AddNewButton_Click(object sender, EventArgs e)
        {
            var dialog = new AddEditTransitMixerDialog();
            dialog.ShowDialog();
            dialog = null;
            await LoadListAsync();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (SelectedTransitMixer != null)
            {
                var dialog = new AddEditTransitMixerDialog(SelectedTransitMixer);
                dialog.ShowDialog();
                dialog = null;
                await LoadListAsync(); 
            }
        }
    }
}
