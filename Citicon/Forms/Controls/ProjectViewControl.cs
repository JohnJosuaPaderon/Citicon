using System;
using System.Windows.Forms;
using Citicon.Data;
using Citicon.Data.Converters;

namespace Citicon.Forms.Controls
{
    public partial class ProjectViewControl : UserControl
    {
        public ProjectViewControl()
        {
            InitializeComponent();
        }

        private Project _Project;

        public Project Project
        {
            get { return _Project; }
            set
            {
                _Project = value;
                UpdateProjectOnUI();
            }
        }

        private void UpdateProjectOnUI()
        {
            NameTextBox.Text = Project?.Name;
            LocationTextBox.Text = Project?.Location;
            TypeTextBox.Text = ProjectTypeConverter.ToDisplay(Project?.Type ?? ProjectType.Undefined);
            InitialPaymentTextBox.Text = Project?.InitialPayment.ToString("#,##0.00");
            InitialCementTextBox.Text = Project?.InitialCement.ToString("#,##0.0##");
            CompletedCheckBox.Checked = Project?.Completed ?? false;
        }

        private void CompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Project != null && Project.Completed != CompletedCheckBox.Checked)
            {
                CompletedCheckBox.Checked = Project.Completed;
            }
        }
    }
}
