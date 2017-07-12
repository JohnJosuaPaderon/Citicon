using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class AddEditTransitMixerDialog : Form
    {
        public AddEditTransitMixerDialog()
        {
            InitializeComponent();
            TransitMixer = new TransitMixer();
            DialogMode = DataDialogMode.Add;
            TransitMixerManager = new TransitMixerManager();
        }

        public AddEditTransitMixerDialog(TransitMixer transitMixer)
        {
            InitializeComponent();
            TransitMixer = transitMixer ?? throw new ArgumentNullException(nameof(transitMixer));
            DialogMode = DataDialogMode.Edit;
            TransitMixerManager = new TransitMixerManager();
        }

        public TransitMixer TransitMixer { get; private set; }
        public DataDialogMode DialogMode { get; }
        private TransitMixerManager TransitMixerManager;

        private void CancelOperationButton_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure, do really want to cancel and close?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private async Task LoadDriverListAsync()
        {
            DefaultDriverComboBox.Items.Clear();

            try
            {
                var drivers = await EmployeeManager.GetDriverListAsync();

                if (drivers != null && drivers.Any())
                {
                    DefaultDriverComboBox.Items.AddRange(drivers.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void AddEditTransitMixerDialog_Load(object sender, EventArgs e)
        {
            await LoadDriverListAsync();
            UpdateTransitMixerUI();
            switch (DialogMode)
            {
                case DataDialogMode.None:
                    Text = "Unknown Operation";
                    break;
                case DataDialogMode.Add:
                    Text = "Add new Transit Mixer";
                    break;
                case DataDialogMode.Edit:
                    Text = "Edit existing Transit Mixer";
                    break;
            }
        }

        private void UpdateTransitMixerUI()
        {
            PhysicalNumberTextBox.Text = TransitMixer?.PhysicalNumber;
            PlateNumberTextBox.Text = TransitMixer?.PlateNumber;
            VolumeCapacityNumericUpDown.Value = Convert.ToDecimal(TransitMixer?.VolumeCapacity ?? 0);
            DefaultDriverComboBox.SelectedItem = TransitMixer?.DefaultDriver;
        }

        private async Task SaveAsync()
        {
            if (DialogMode != DataDialogMode.None)
            {
                try
                {
                    TransitMixer.Additionals = AdditionalsNumericUpDown.Value;
                    string failedMessage = string.Empty;
                    string successMessage = string.Empty;

                    switch (DialogMode)
                    {
                        case DataDialogMode.Add:
                            failedMessage = "Failed to add transit mixer.";
                            successMessage = "Transit mixer has been added successfully.";
                            TransitMixer = await TransitMixerManager.InsertAsync(TransitMixer);
                            break;
                        case DataDialogMode.Edit:
                            failedMessage = "Failed to modify transit mixer.";
                            successMessage = "Transit mixer has been modified successfully.";
                            TransitMixer = await TransitMixerManager.UpdateAsync(TransitMixer);
                            break;
                    }

                    if (TransitMixer != null)
                    {
                        MessageBox.Show(successMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(failedMessage, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Unknown operation.");
            }
        }

        private void SetTransitMixerProperty(Action method)
        {
            if (TransitMixer != null)
            {
                method();
            }
        }

        private void DefaultDriverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DefaultDriverComboBox.Enabled = DefaultDriverCheckBox.Checked;

            if (DefaultDriverCheckBox.Checked)
            {
                SetTransitMixerProperty(() => TransitMixer.DefaultDriver = DefaultDriverComboBox.SelectedItem as Employee);
            }
            else
            {
                SetTransitMixerProperty(() => TransitMixer.DefaultDriver = null);
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            await SaveAsync();
        }

        private void PhysicalNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTransitMixerProperty(() => TransitMixer.PhysicalNumber = PhysicalNumberTextBox.Text);
        }

        private void PlateNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTransitMixerProperty(() => TransitMixer.PlateNumber = PlateNumberTextBox.Text);
        }

        private void VolumeCapacityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetTransitMixerProperty(() => TransitMixer.VolumeCapacity = Convert.ToDouble(VolumeCapacityNumericUpDown.Value));
        }

        private void DefaultDriverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTransitMixerProperty(() => TransitMixer.DefaultDriver = DefaultDriverComboBox.SelectedItem as Employee);
        }
    }
}
