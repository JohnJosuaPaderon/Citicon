using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class AddEditProjectDesignDialog : Form
    {
        private AddEditProjectDesignDialog()
        {
            InitializeComponent();
        }

        public static ProjectDesign ShowAddDialog(bool saveToDB)
        {
            var dialog = new AddEditProjectDesignDialog()
            {
                Mode = DataDialogMode.Add,
                SaveToDB = saveToDB,
                ProjectDesign = new ProjectDesign()
            };
            dialog.ShowDialog();

            return dialog.ProjectDesign;
        }

        public static ProjectDesign ShowEditDialog(ProjectDesign projectDesign, bool saveToDB)
        {
            var dialog = new AddEditProjectDesignDialog()
            {
                Mode = DataDialogMode.Edit,
                SaveToDB = saveToDB,
                ProjectDesign = projectDesign
            };
            dialog.ShowDialog();

            return dialog.ProjectDesign;
        }

        private DataDialogMode Mode { get; set; }
        private bool SaveToDB { get; set; }
        private ProjectDesign ProjectDesign { get; set; }

        private void LoadMixTypes()
        {
            MixTypeComboBox.Items.Add(ProjectDesignMixType.ORD);
            MixTypeComboBox.Items.Add(ProjectDesignMixType.PCD);
        }

        private void LoadAggregates()
        {
            AggregateComboBox.Items.Clear();
            var aggregates = ProductAggregateManager.GetList();

            if (aggregates != null && aggregates.Any())
            {
                AggregateComboBox.Items.AddRange(aggregates.ToArray());
            }
        }

        private void LoadStrengths()
        {
            StrengthComboBox.Items.Clear();
            var strengths = ProductStrengthManager.GetList();

            if (strengths != null && strengths.Any())
            {
                StrengthComboBox.Items.AddRange(strengths.ToArray());
            }
        }

        private void UpdateUI()
        {
            PricePerCubicMeterNumericUpDown.Value = ProjectDesign?.PricePerCubicMeter ?? 0;
            MixTypeComboBox.SelectedItem = ProjectDesign?.MixType;
            PSINumericUpDown.Value = ProjectDesign?.Psi ?? 0;
            AggregateComboBox.SelectedItem = ProjectDesign?.Aggregate;
            StrengthComboBox.SelectedItem = ProjectDesign?.Strength;
            CementFactorNumericUpDown.Value = ProjectDesign?.CementFactor ?? 0;
        }

        private void AddEditProjectDesignDialog_Load(object sender, EventArgs e)
        {
            LoadMixTypes();
            LoadAggregates();
            LoadStrengths();
            UpdateUI();
        }

        private void CancelQuotationButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to cancel?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ProjectDesign = null;
                Close();
            }
        }

        private void SaveQuotationButton_Click(object sender, EventArgs e)
        {
            var result = ProjectDesignManager.Validate(ProjectDesign);

            if (result.Success)
            {
                Close();
            }
            else
            {
                MessageBox.Show(result.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PricePerCubicMeterNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ProjectDesign != null)
            {
                ProjectDesign.PricePerCubicMeter = PricePerCubicMeterNumericUpDown.Value;
            }
        }

        private void CementFactorNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ProjectDesign != null)
            {
                ProjectDesign.CementFactor = CementFactorNumericUpDown.Value;
            }
        }

        private void PSINumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ProjectDesign != null)
            {
                ProjectDesign.Psi = PSINumericUpDown.Value;
            }
        }

        private void AggregateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectDesign != null)
            {
                ProjectDesign.Aggregate = AggregateComboBox.SelectedItem as ProductAggregate;
            }
        }

        private void StrengthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectDesign != null)
            {
                ProjectDesign.Strength = StrengthComboBox.SelectedItem as ProductStrength;
            }
        }

        private void MixTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectDesign != null)
            {
                ProjectDesign.MixType = (ProjectDesignMixType)MixTypeComboBox.SelectedItem;
            }
        }
    }
}
