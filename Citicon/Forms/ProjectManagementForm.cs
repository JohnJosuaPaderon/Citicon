using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.Dialogs;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class ProjectManagementForm : Form
    {
        public ProjectManagementForm(Client client)
        {
            InitializeComponent();
            Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Client Client { get; }

        private async Task GetProjectListAsync()
        {
            ProjectDataGridView.Rows.Clear();
            var projects = await ProjectManager.GetListByClientAsync(Client);

            if (projects != null && projects.Any())
            {
                foreach (var project in projects)
                {
                    AddToUI(project);
                }
            }
        }

        private async Task GetSelectedProjectAsync()
        {
            if (ProjectDataGridView.SelectedRows.Count == 1)
            {
                if (ProjectDataGridView.SelectedRows[0].Cells[ProjectColumn.Name].Value is Project project)
                {
                    ProjectView.Project = await ProjectManager.GetByIdAsync(project.Id);
                }
            }
        }

        private void AddToUI(Project project)
        {
            if (project != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = project });

                ProjectDataGridView.Rows.Add(row);
            }
        }

        private void UpdateUI()
        {
            ClientNameTextBox.Text = Client?.CompanyName;
        }

        private async void ProjectManagementForm_Load(object sender, EventArgs e)
        {
            await GetProjectListAsync();
            UpdateUI();
        }

        private async void ProjectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetSelectedProjectAsync();
        }

        private async void AddNewButton_Click(object sender, EventArgs e)
        {
            var form = new AddEditProjectDialog(Client);
            form.ShowDialog();
            await GetProjectListAsync();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (ProjectView.Project != null)
            {
                var form = new AddEditProjectDialog(ProjectView.Project);
                form.ShowDialog();
                await GetProjectListAsync();
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProjectView.Project != null)
            {
                var result = MessageBox.Show("Do you really want to delete the project?", "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var project = await ProjectManager.DeleteAsync(ProjectView.Project);

                        if (project != null)
                        {
                            for (int i = 0; i < ProjectDataGridView.Rows.Count; i++)
                            {
                                var tempProject = ProjectDataGridView.Rows[i].Cells[ProjectColumn.Name].Value as Project;

                                if (project == tempProject)
                                {
                                    ProjectDataGridView.Rows.RemoveAt(i);
                                    break;
                                }
                            }

                            MessageBox.Show("Project has been deleted.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Project was not deleted.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ViewDesignsButton_Click(object sender, EventArgs e)
        {
            if (ProjectView.Project != null)
            {
                var form = new ProjectDesignManagementForm(ProjectView.Project);
                form.ShowDialog();
            }
        }

        private void ViewQuotationsButton_Click(object sender, EventArgs e)
        {
            if (ProjectView.Project != null)
            {
                var form = new QuotationManagementForm(ProjectView.Project);
                form.ShowDialog();
            }
        }
    }
}
