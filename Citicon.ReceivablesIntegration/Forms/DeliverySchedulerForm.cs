using Citicon.Data;
using Citicon.DataManager;
using Citicon.DataProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.ReceivablesIntegration.Forms
{
    public partial class DeliverySchedulerForm : Form
    {
        public DeliverySchedulerForm()
        {
            InitializeComponent();
            ScheduledProjectDesignManager = new ScheduledProjectDesignManager();
        }
        
        private ScheduledProjectDesignManager ScheduledProjectDesignManager { get; }

        private async Task SaveSchedulesAsync()
        {
            if (dgvScheduledProjectDesign.Rows.Count > 0)
            {
                List<ScheduledProjectDesign> scheduledDesigns = new List<ScheduledProjectDesign>();

                foreach (DataGridViewRow row in dgvScheduledProjectDesign.Rows)
                {
                    var scheduledDesign = new ScheduledProjectDesign()
                    {
                        Design = row.Cells[colScheduledProjectDesign.Name].Value as ProjectDesign,
                        ScheduledDate = dtpScheduledDate.Value,
                        UseRangeDate = UseRangedDateCheckBox.Checked,
                        RangeEnd = RangeEndDateTimePicker.Value,
                        StructureType = StructureTypeComboBox.SelectedItem as BillingStructureType,
                        MaximumVolume = (decimal)row.Cells[colScheduledProjectDesign_MaximumVolume.Name].Value
                    };
                    if (!await ScheduledProjectDesignManager.ExistsAsync(scheduledDesign))
                    {
                        scheduledDesigns.Add(scheduledDesign);
                    }
                }

                if (scheduledDesigns.Count > 0)
                {
                    try
                    {
                        await ScheduledProjectDesignManager.InsertListAsync(scheduledDesigns);
                        dgvScheduledProjectDesign.Rows.Clear();
                        MessageBox.Show("Schedule saved!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing to save.");
            }
        }

        private async Task GetApprovedProjectListAsync()
        {
            dgvProjects.Rows.Clear();

            try
            {
                var projects = await ProjectManager.GetApprovedListAsync();

                if (projects != null)
                {
                    foreach (Project project in projects)
                    {
                        AddProject(project);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetApprovedProjectDesignListByProjectAsync()
        {
            dgvProjectDesign.Rows.Clear();

            if (dgvProjects.SelectedRows.Count == 1)
            {
                if (dgvProjects.SelectedRows[0].Cells[colProject.Name].Value is Project project)
                {
                    try
                    {
                        var projectDesigns = await ProjectDesignManager.GetApprovedListByProjectAsync(project);

                        if (projectDesigns != null)
                        {
                            foreach (ProjectDesign projectDesign in projectDesigns)
                            {
                                AddProjectDesign(projectDesign);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async Task IncludeSelectedProjectDesignAsync()
        {
            if (dgvProjectDesign.SelectedRows.Count == 1)
            {
                var projectDesign = (ProjectDesign)dgvProjectDesign.SelectedRows[0].Cells[colProjectDesign.Name].Value;

                if (projectDesign != null)
                {
                    var scheduledDesign = new ScheduledProjectDesign()
                    {
                        Design = projectDesign,
                        ScheduledDate = dtpScheduledDate.Value,
                        RangeEnd = RangeEndDateTimePicker.Value,
                        UseRangeDate = UseRangedDateCheckBox.Checked,
                        MaximumVolume = ProjectDesignMaxVolumeNumericUpDown.Value
                    };
                    if (await ScheduledDesignExistsAsync(scheduledDesign))
                    {
                        MessageBox.Show("Schedule already exists!");
                    }
                    else
                    {
                        AddScheduledDesign(scheduledDesign.Design);
                    }
                }
                else
                {
                    MessageBox.Show("Nothing to include.");
                }
            }
        }

        private void AddProject(Project project)
        {
            if (project != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = project });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = project.Client });

                dgvProjects.Rows.Add(row);
            }
        }

        private void AddProjectDesign(ProjectDesign projectDesign)
        {
            if (projectDesign != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = projectDesign });

                dgvProjectDesign.Rows.Add(row);
            }
        }

        private async Task<bool> ScheduledDesignExistsAsync(ScheduledProjectDesign scheduledDesign)
        {
            if (scheduledDesign != null)
            {
                foreach (DataGridViewRow row in dgvScheduledProjectDesign.Rows)
                {
                    var rowItem = (ProjectDesign)row.Cells[colScheduledProjectDesign.Name].Value;

                    if (rowItem == scheduledDesign.Design)
                    {
                        return true;
                    }
                }

                return await ScheduledProjectDesignManager.ExistsAsync(scheduledDesign);
            }
            else
            {
                return false;
            }
        }

        private void AddScheduledDesign(ProjectDesign design)
        {
            if (design != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = design });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = ProjectDesignMaxVolumeNumericUpDown.Value });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = design.Project });

                dgvScheduledProjectDesign.Rows.Add(row);
            }
        }

        private async void DeliverySchedulerForm_Load(object sender, EventArgs e)
        {
            //await GetApprovedProjectListAsync();
            await GetStructureTypeAsync();
            LoadSearchPredicates();
        }

        private void LoadSearchPredicates()
        {
            SearchPredicateComboBox.Items.Clear();
            SearchPredicateComboBox.Items.Add(SearchApprovedProjectPredicate.Client);
            SearchPredicateComboBox.Items.Add(SearchApprovedProjectPredicate.Project);
        }

        private async Task GetStructureTypeAsync()
        {
            try
            {
                StructureTypeComboBox.Items.AddRange((await BillingStructureTypeManager.GetListAsync()).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            await GetApprovedProjectDesignListByProjectAsync();
        }

        private async void btnScheduleSelectedProjectDesign_Click(object sender, EventArgs e)
        {
            await IncludeSelectedProjectDesignAsync();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgvScheduledProjectDesign.SelectedRows.Count == 1)
            {
                dgvScheduledProjectDesign.Rows.Remove(dgvScheduledProjectDesign.SelectedRows[0]);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            dgvScheduledProjectDesign.Rows.Clear();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await SaveSchedulesAsync();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            //var key = SearchTextBox.Text.Trim().ToUpper();

            //foreach (DataGridViewRow row in dgvProjects.Rows)
            //{
            //    if (row.Cells[colProject.Name].Value is Project project)
            //    {
            //        if (project.Name.ToUpper().Contains(key) || (project.Client?.CompanyName.ToUpper().Contains(key) ?? false))
            //        {
            //            dgvProjects.FirstDisplayedScrollingRowIndex = row.Index;
            //            row.Selected = true;
            //            break;
            //        }
            //    }
            //}
        }

        private async Task SearchAsync()
        {
            if (!string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                if (SearchPredicateComboBox.SelectedItem is SearchApprovedProjectPredicate predicate)
                {
                    try
                    {
                        dgvProjects.Rows.Clear();
                        var result = await ProjectManager.SearchApprovedProjectAsync(SearchTextBox.Text.Trim(), predicate);

                        if (result != null && result.Any())
                        {
                            foreach (var project in result)
                            {
                                AddProject(project);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No result.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid search predicate.");
                }
            }
            else
            {
                MessageBox.Show("Invalid search key.");
            }
        }

        private void UseRangedDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RangeEndDateTimePicker.Enabled = UseRangedDateCheckBox.Checked;
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            await SearchAsync();
        }
    }
}
