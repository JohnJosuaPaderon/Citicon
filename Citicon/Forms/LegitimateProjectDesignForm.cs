using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class LegitimateProjectDesignForm : Form
    {
        public LegitimateProjectDesignForm()
        {
            InitializeComponent();
        }

        private async void ClientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetProjectListAsync();
        }

        private async Task GetProjectListAsync()
        {
            ProjectDataGridView.Rows.Clear();

            try
            {
                if (ClientDataGridView.SelectedRows.Count == 1 && ClientDataGridView.SelectedRows[0].Cells[ClientColumn.Name].Value is Client client)
                {
                    var projects = await ProjectManager.GetListByClientAsync(client);

                    if (projects != null && projects.Any())
                    {
                        foreach (var project in projects)
                        {
                            Display(project);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Display(Project project)
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

        private async Task GetClientListAsync()
        {
            ClientDataGridView.Rows.Clear();

            try
            {
                var clients = await (SpecialClientsCheckBox.Checked ? ClientManager.GetLegitimateListAsync() : ClientManager.GetListAsync());

                if (clients != null && clients.Any())
                {
                    foreach (var client in clients)
                    {
                        Display(client);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Display(Client client)
        {
            if (client != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = client });
                ClientDataGridView.Rows.Add(row);
            }
        }

        private async void ProjectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetDesignListAsync();
        }

        private async Task GetDesignListAsync()
        {
            DesignDataGridView.Rows.Clear();

            try
            {
                if (ProjectDataGridView.SelectedRows.Count == 1 && ProjectDataGridView.SelectedRows[0].Cells[ProjectColumn.Name].Value is Project project)
                {
                    var designs = await ProjectDesignManager.GetListByProjectAsync(project);

                    if (designs != null && designs.Any())
                    {
                        foreach (var design in designs)
                        {
                            Display(design);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Display(ProjectDesign design)
        {
            if (design != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = design });
                DesignDataGridView.Rows.Add(row);
            }
        }

        private async void LegitimateProjectDesignForm_Load(object sender, EventArgs e)
        {
            await GetClientListAsync();
        }

        private void ConfirmDeliveryButton_Click(object sender, EventArgs e)
        {
            if (DesignDataGridView.SelectedRows.Count == 1 && DesignDataGridView.SelectedRows[0].Cells[DesignColumn.Name].Value is ProjectDesign design)
            {
                var form = new DeliveryManagementForm(design);
                form.ShowDialog();
                form = null;
            }
        }

        private async void SpecialClientsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            await GetClientListAsync();
        }
    }
}
