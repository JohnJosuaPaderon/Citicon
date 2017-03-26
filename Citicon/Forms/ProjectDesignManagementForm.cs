using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class ProjectDesignManagementForm : Form
    {
        public ProjectDesignManagementForm(Project project)
        {
            InitializeComponent();
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        public Project Project { get; }

        private void UpdateCoreUI()
        {
            ProjectTextBox.Text = Project?.ToString();
            ClientTextBox.Text = Project?.Client?.ToString();
        }

        private async Task GetProjectDesignListAsync()
        {
            ProjectDesignDataGridView.Rows.Clear();
            var projectDesigns = await ProjectDesignManager.GetListByProjectAsync(Project);

            if (projectDesigns != null && projectDesigns.Any())
            {
                foreach (var projectDesign in projectDesigns)
                {
                    AddToUI(projectDesign);
                }
            }
        }

        private async Task GetSelectedProjectDesignAsync()
        {
            if (ProjectDesignDataGridView.SelectedRows.Count == 1)
            {
                var projectDesign = ProjectDesignDataGridView.SelectedRows[0].Cells[ProjectDesignColumn.Name].Value as ProjectDesign;

                if (projectDesign != null)
                {
                    ProjectDesignView.ProjectDesign = await ProjectDesignManager.GetByIdAsync(projectDesign.Id);
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

                ProjectDesignDataGridView.Rows.Add(row);
            }
        }

        private async void ProjectDesignManagementForm_Load(object sender, EventArgs e)
        {
            UpdateCoreUI();
            await GetProjectDesignListAsync();
        }

        private async void ProjectDesignDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetSelectedProjectDesignAsync();
        }
    }
}
