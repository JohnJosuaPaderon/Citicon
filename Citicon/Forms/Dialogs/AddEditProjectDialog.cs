using Citicon.Data;
using Citicon.Data.Converters;
using Citicon.DataManager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class AddEditProjectDialog : Form
    {
        public AddEditProjectDialog(Client client)
        {
            InitializeComponent();
            Project = new Project()
            {
                Client = client
            };
            Mode = DataDialogMode.Add;
        }

        public AddEditProjectDialog(Project project)
        {
            InitializeComponent();
            Project = project ?? throw new ArgumentNullException(nameof(project));
            Mode = DataDialogMode.Edit;
        }

        public Project Project { get; private set; }
        public DataDialogMode Mode { get; }

        private void UpdateModeOnUI()
        {
            switch (Mode)
            {
                case DataDialogMode.None:
                    Text = "Unknown Operation";
                    break;
                case DataDialogMode.Add:
                    Text = "Add new Project";
                    break;
                case DataDialogMode.Edit:
                    Text = "Edit Project";
                    break;
            }
        }

        private void UpdateUI()
        {
            UpdateModeOnUI();
            UpdateProjectOnUI();
        }

        private void UpdateProjectOnUI()
        {
            NameTextBox.Text = Project?.Name;
            LocationTextBox.Text = Project?.Location;
            TypeComboBox.SelectedItem = ProjectTypeConverter.ToDisplay(Project?.Type ?? ProjectType.Undefined);
            InitialPaymentNumericUpDown.Value = Project?.InitialPayment ?? 0;
            InitialCementNumericUpDown.Value = (decimal)(Project?.InitialCement ?? 0);
        }

        private void InitializeRequirement()
        {
            TypeComboBox.Items.Add(ProjectTypeConverter.ToDisplay(ProjectType.Straight));
            TypeComboBox.Items.Add(ProjectTypeConverter.ToDisplay(ProjectType.CementSupplied));
            QuotationTypeComboBox.Items.Add(QuotationType.Citicon);
            QuotationTypeComboBox.Items.Add(QuotationType.Lex);
        }

        private async Task AddAsync()
        {
            var validationResult = ProjectManager.Validate(Project);

            if (validationResult.Success)
            {
                try
                {
                    var project = await ProjectManager.InsertAsync(Project);

                    if (project != null)
                    {
                        Project = project;
                        MessageBox.Show("Project has been added successfully.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Project not saved.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(validationResult.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task EditAsync()
        {
            var validationResult = ProjectManager.Validate(Project);

            if (validationResult.Success)
            {
                try
                {
                    var project = await ProjectManager.UpdateAsync(Project);

                    if (project != null)
                    {
                        Project = project;
                        MessageBox.Show("Project has been modified successfully.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Project not saved.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(validationResult.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddEditProjectDialog_Load(object sender, EventArgs e)
        {
            InitializeRequirement();
            UpdateUI();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, you want to cancel?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case DataDialogMode.None:
                    MessageBox.Show("Unknown operation.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case DataDialogMode.Add:
                    await AddAsync();
                    break;
                case DataDialogMode.Edit:
                    await EditAsync();
                    break;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Project != null)
            {
                Project.Name = NameTextBox.Text;
            }
        }

        private void LocationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Project != null)
            {
                Project.Location = LocationTextBox.Text;
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Project != null)
            {
                Project.Type = ProjectTypeConverter.FromDisplay((string)TypeComboBox.SelectedItem);
            }
        }

        private void InitialPaymentNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Project != null)
            {
                Project.InitialPayment = InitialPaymentNumericUpDown.Value;
            }
        }

        private void InitialCementNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Project != null)
            {
                Project.InitialCement = (double)InitialCementNumericUpDown.Value;
            }
        }

        private void CompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Project != null)
            {
                Project.Completed = CompletedCheckBox.Checked;
            }
        }

        private void QuotationTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Project != null)
            {
                Project.QuotationType = (QuotationType)QuotationTypeComboBox.SelectedItem;
            }
        }
    }
}
