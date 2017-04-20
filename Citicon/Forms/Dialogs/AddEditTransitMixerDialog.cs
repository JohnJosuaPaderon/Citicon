using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        public AddEditTransitMixerDialog(TransitMixer transitMixer)
        {
            InitializeComponent();
            TransitMixer = transitMixer ?? throw new ArgumentNullException(nameof(transitMixer));
            DialogMode = DataDialogMode.Edit;
        }

        public TransitMixer TransitMixer { get; private set; }
        public DataDialogMode DialogMode { get; }

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
        }
    }
}
