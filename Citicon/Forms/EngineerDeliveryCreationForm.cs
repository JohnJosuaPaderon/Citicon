using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class EngineerDeliveryCreationForm : Form
    {
        public EngineerDeliveryCreationForm()
        {
            InitializeComponent();
        }

        private void EngineerDeliveryCreationForm_Load(object sender, EventArgs e)
        {
            GetLegitimateClients();
            GetAggregates();
            GetStrengths();
        }

        private void GetAggregates()
        {
            cmbxNewProjectDesign_Aggregate.Items.Clear();
            try
            {
                cmbxNewProjectDesign_Aggregate.Items.AddRange(ProductAggregateManager.GetList().ToArray());
            }
            catch (Exception)
            {
            }
        }

        private void GetStrengths()
        {
            cmbxNewProjectDesign_Strength.Items.Clear();
            try
            {
                cmbxNewProjectDesign_Strength.Items.AddRange(ProductStrengthManager.GetList().ToArray());
            }
            catch (Exception)
            {
            }
        }

        private void GetLegitimateClients()
        {
            dgvClients.Rows.Clear();
            var task = ClientManager.GetLegitimateListAsync();
            task.ContinueWith(DisplayLegitimateClients);
        }

        private void DisplayLegitimateClients(Task<IEnumerable<Client>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    var rows = new List<DataGridViewRow>();

                    foreach (Client client in task.Result)
                    {
                        var row = new DataGridViewRow();
                        row.Height = 30;
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = client });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = client.Address });
                        rows.Add(row);
                    }

                    Invoke(new Action(() =>
                    {
                        dgvClients.Rows.AddRange(rows.ToArray());
                    }));
                }
            }
            else
            {

            }
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            dgvProjects.Rows.Clear();
            if (dgvClients.SelectedRows.Count == 1)
            {
                GetProjects();
            }
        }

        private void GetProjects()
        {
            var client = (Client)dgvClients.SelectedRows[0].Cells[colClient.Name].Value;
            var task = ProjectManager.GetListByClientAsync(client);
            task.ContinueWith(DisplayProjects);
        }

        private void DisplayProjects(Task<IEnumerable<Project>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    var rows = new List<DataGridViewRow>();

                    foreach (Project project in task.Result)
                    {
                        var row = new DataGridViewRow();
                        row.Height = 30;
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = project });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = project.Location });
                        rows.Add(row);
                    }

                    Invoke(new Action(() =>
                    {
                        dgvProjects.Rows.AddRange(rows.ToArray());
                    }));
                }
            }
            else
            {

            }
        }

        private void dgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            dgvProjectDesigns.Rows.Clear();
            if (dgvProjects.SelectedRows.Count == 1)
            {
                GetProjectDesigns();
            }
        }

        private void GetProjectDesigns()
        {
            var project = (Project)dgvProjects.SelectedRows[0].Cells[colProject.Name].Value;
            var task = ProjectDesignManager.GetListByProjectAsync(project);
            task.ContinueWith(DisplayProjectDesigns);
        }

        private void DisplayProjectDesigns(Task<IEnumerable<ProjectDesign>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    var rows = new List<DataGridViewRow>();

                    foreach (ProjectDesign projectDesign in task.Result)
                    {
                        var row = new DataGridViewRow();
                        row.Height = 30;
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.MixType });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.Aggregate });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.Strength });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.Psi });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.PricePerCubicMeter });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.CementFactor });
                        rows.Add(row);
                    }

                    Invoke(new Action(() =>
                    {
                        dgvProjectDesigns.Rows.AddRange(rows.ToArray());
                    }));
                }
            }
            else
            {

            }
        }

        private void btnAddNewProjectDesign_Click(object sender, EventArgs e)
        {
            AddNewProjectDesign();

        }

        private void AddNewProjectDesign()
        {
            var projectDesign = new ProjectDesign();

            projectDesign.Project = (Project)dgvProjects.SelectedRows[0].Cells[colProject.Name].Value;
            projectDesign.Psi = nudNewProjectDesign_Psi.Value;
            projectDesign.Aggregate = (ProductAggregate)cmbxNewProjectDesign_Aggregate.SelectedItem;
            projectDesign.Strength = (ProductStrength)cmbxNewProjectDesign_Strength.SelectedItem;
            projectDesign.PricePerCubicMeter = nudNewProjectDesign_PricePerCubicMeter.Value;
            projectDesign.CementFactor = nudNewProjectDesign_CementFactor.Value;
            projectDesign.MixType = ProjectDesignMixTypeManager.Parse((string)cmbxNewProjectDesign_MixType.SelectedItem);
            projectDesign.ForApproval = true;

            if (ValidEntry(projectDesign))
            {
                var task = ProjectDesignManager.InsertAsync(projectDesign);
                task.ContinueWith(DisplayInsertProjectDesignResult);
            }
            else
            {
                MessageBox.Show("Project is either already exists or having invalid value.");
            }
        }

        private void InsertProjectDesignToDataGridView(ProjectDesign projectDesign)
        {
            var row = new DataGridViewRow();
            row.Height = 30;
            row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.MixType });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.Aggregate });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.Strength });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.Psi });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.PricePerCubicMeter });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign.CementFactor });

            Invoke(new Action(() =>
            {
                dgvProjectDesigns.Rows.Add(row);
            }));
        }

        private void DisplayInsertProjectDesignResult(Task<ProjectDesign> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                InsertProjectDesignToDataGridView(task.Result);
                ClearNewProjectDesign();
                MessageBox.Show("Project Design successfully saved!", "Project Design", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occured on saving Project Design", "Project Design", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidEntry(ProjectDesign projectDesign)
        {
            if (projectDesign.Psi <= 0)
            {
                return false;
            }

            if (projectDesign.Aggregate == null)
            {
                return false;
            }

            if (projectDesign.Strength == null)
            {
                return false;
            }

            if (projectDesign.CementFactor <= 0)
            {
                return false;
            }

            foreach (DataGridViewRow row in dgvProjectDesigns.Rows)
            {
                var tempProjectDesign = (ProjectDesign)row.Cells[colProjectDesign.Name].Value;

                if (tempProjectDesign.Psi == projectDesign.Psi &&
                    tempProjectDesign.Aggregate == projectDesign.Aggregate &&
                    tempProjectDesign.Strength == projectDesign.Strength &&
                    tempProjectDesign.PricePerCubicMeter == projectDesign.PricePerCubicMeter &&
                    tempProjectDesign.CementFactor == projectDesign.CementFactor &&
                    tempProjectDesign.MixType == projectDesign.MixType)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnCancelNewProjectDesign_Click(object sender, EventArgs e)
        {
            ClearNewProjectDesign();
        }

        private void ClearNewProjectDesign()
        {
            Invoke(new Action(() =>
            {
                cmbxNewProjectDesign_MixType.SelectedItem = null;
                cmbxNewProjectDesign_Aggregate.SelectedItem = null;
                cmbxNewProjectDesign_Strength.SelectedItem = null;
                nudNewProjectDesign_Psi.Value = 0;
                nudNewProjectDesign_PricePerCubicMeter.Value = 0;
                nudNewProjectDesign_CementFactor.Value = 0;
            }));
        }
    }
}
