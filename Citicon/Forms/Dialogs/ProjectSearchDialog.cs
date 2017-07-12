using Citicon.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class ProjectSearchDialog : Form
    {
        public static Project Show(Client client, IEnumerable<Project> projects)
        {
            var dialog = new ProjectSearchDialog(client, projects);
            dialog.ShowDialog();

            return dialog.SelectedProject;
        }

        private ProjectSearchDialog(Client client, IEnumerable<Project> projects)
        {
            InitializeComponent();
            Client = client;
            Projects = projects;

        }

        private Client Client { get; }
        private Project SelectedProject;
        private IEnumerable<Project> Projects { get; }

        private void ProjectSearchDialog_Load(object sender, EventArgs e)
        {
            ClientNameTextBox.Text = Client.CompanyName;
            LoadProjectList();
        }

        private void LoadProjectList()
        {
            foreach (var project in Projects)
            {
                AddToUI(project);
            }
        }

        private void AddToUI(Project project)
        {
            var row = new DataGridViewRow()
            {
                Height = 30
            };
            row.Cells.Add(new DataGridViewTextBoxCell { Value = project });
            ProjectDataGridView.Rows.Add(row);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var key = SearchTextBox.Text.Trim().ToUpper();

            foreach (DataGridViewRow row in ProjectDataGridView.Rows)
            {
                if (row.Cells[ProjectColumn.Name].Value is Client client)
                {
                    if (client.CompanyName.Contains(key))
                    {
                        row.Selected = true;
                        ProjectDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (ProjectDataGridView.SelectedRows.Count == 1)
            {
                SelectedProject = ProjectDataGridView.SelectedRows[0].Cells[ProjectColumn.Name].Value as Project;
                Close();
            }
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            SelectedProject = null;
        }
    }
}
