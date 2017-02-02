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
using Citicon.Data;

namespace Citicon.Inventory
{
    public partial class CementSuppliedProjectForm : Form
    {
        public Client CementSuppliedClient { get; private set; }
        public Project[] CementSuppliedProjects { get; private set; }

        public CementSuppliedProjectForm()
        {
            InitializeComponent();
        }

        private void CementSuppliedProjectForm_Load(object sender, EventArgs e)
        {
            var getClientListTask = ClientManager.GetListAsync();
            getClientListTask.ContinueWith(DisplayClientList);
        }

        private void DisplayClientList(Task<IEnumerable<Client>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    var clientRows = new List<DataGridViewRow>();
                    foreach (var item in task.Result)
                    {
                        var row = new DataGridViewRow();
                        row.Height = 30;
                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = item });
                        clientRows.Add(row);
                    }
                    Invoke(new Action(() =>
                    {
                        dgvClients.Rows.Clear();
                        dgvClients.Rows.AddRange(clientRows.ToArray());
                    }));
                }
            }
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                var row = dgvClients.SelectedRows[0];
                var client = (Client)row.Cells[colClient.Name].Value;
                var getProjectListByClientTask = ProjectManager.GetListByClientAsync(client);
                getProjectListByClientTask.ContinueWith(DisplayProjectList);
            }
        }

        private void DisplayProjectList(Task<IEnumerable<Project>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                Invoke(new Action(() => dgvProjects.Rows.Clear()));
                if (task.Result != null)
                {
                    var projectRows = new List<DataGridViewRow>();
                    foreach (var item in task.Result)
                    {
                        var row = new DataGridViewRow();
                        row.Height = 30;
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Location });
                        projectRows.Add(row);
                    }

                    Invoke(new Action(() => dgvProjects.Rows.AddRange(projectRows.ToArray())));
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                var client = (Client)dgvClients.SelectedRows[0].Cells[colClient.Name].Value;
                CementSuppliedClient = client;

                if (dgvProjects.SelectedRows.Count > 0)
                {
                    var projects = new List<Project>();

                    foreach (DataGridViewRow row in dgvProjects.SelectedRows)
                    {
                        projects.Add((Project)row.Cells[colProject.Name].Value);
                    }

                    CementSuppliedProjects = projects.ToArray();
                    Close();
                }
                else
                {
                    MessageBox.Show("Select a Project for Cement Supplied");
                }
            }
        }
    }
}
