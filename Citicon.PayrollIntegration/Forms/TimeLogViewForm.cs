using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.Dialogs;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.PayrollIntegration.Forms
{
    public partial class TimeLogViewForm : Form
    {
        public TimeLogViewForm()
        {
            InitializeComponent();
            BranchManager = new BranchManager();
        }

        private BranchManager BranchManager;

        private TimeLog _SelectedTimeLog;

        public TimeLog SelectedTimeLog
        {
            get { return _SelectedTimeLog; }
            set
            {
                if (_SelectedTimeLog != value)
                {
                    _SelectedTimeLog = value;
                    UpdateSelectedTimeLogUI();
                }
            }
        }

        private void UpdateSelectedTimeLogUI()
        {
            TimeLogDetails_LoginDateTimePicker.Value = SelectedTimeLog?.Login ?? DateTime.Now;
            TimeLogDetails_LogoutDateTimePicker.Value = SelectedTimeLog?.Logout ?? DateTime.Now;
        }

        private async void TimeLogViewForm_Load(object sender, EventArgs e)
        {
            await GetBranchListAsync();
        }

        private async Task GetBranchListAsync()
        {
            BranchComboBox.Items.Clear();

            try
            {
                var branchList = await BranchManager.GetListAsync();

                if (branchList != null && branchList.Any())
                {
                    BranchComboBox.Items.AddRange(branchList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task GetEmployeeListAsync()
        {
            if (BranchComboBox.SelectedItem is Branch branch)
            {
                EmployeeDataGridView.Rows.Clear();

                try
                {
                    var employees = await EmployeeManager.GetListWithTimeLogAsync(branch, new DateTimeRange(TimeRangeStartDdateTimePicker.Value, TimeRangeEndDateTimePicker.Value));

                    if (employees != null && employees.Any())
                    {
                        foreach (var employee in employees)
                        {
                            AddToUI(employee);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddToUI(Employee employee)
        {
            if (employee != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = employee });
                EmployeeDataGridView.Rows.Add(employee);
            }
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            await GetEmployeeListAsync();
        }

        private async Task GetTimeLogListAsync()
        {
            TimeLogDataGridView.Rows.Clear();

            if (EmployeeDataGridView.SelectedRows.Count == 1)
            {
                if (EmployeeDataGridView.SelectedRows[0].Cells[EmployeeColumn.Name].Value is Employee employee)
                {
                    try
                    {
                        var timeLogs = await EmployeeManager.GetTimeLogListAsync(employee, new DateTimeRange(TimeRangeStartDdateTimePicker.Value, TimeRangeEndDateTimePicker.Value));

                        if (timeLogs != null && timeLogs.Any())
                        {
                            foreach (var timeLog in timeLogs)
                            {
                                AddToUI(timeLog);
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

        private void AddToUI(TimeLog timeLog)
        {
            if (timeLog != null)
            {
                var row = new DataGridViewRow()
                {
                    Height = 30
                };
                row.Cells.Add(new DataGridViewTextBoxCell { Value = timeLog });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = timeLog.Login });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = timeLog.Logout });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = timeLog.Type });

                TimeLogDataGridView.Rows.Add(row);
            }
        }

        private async void EmployeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await GetTimeLogListAsync();
        }

        private void TimeLogDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (TimeLogDataGridView.SelectedRows.Count == 1)
            {
                SelectedTimeLog = TimeLogDataGridView.SelectedRows[0].Cells[TimeLogColumn.Name].Value as TimeLog;
            }
        }

        private async Task UpdateSelectedTimeLogAsync()
        {
            try
            {
                var timeLog = await EmployeeManager.UpdateTimeLogAsync(SelectedTimeLog);

                if (timeLog != null)
                {
                    var row = TimeLogDataGridView.SelectedRows[0];
                    row.Cells[TimeLogColumn.Name].Value = timeLog;
                    row.Cells[TimeLog_LoginColumn.Name].Value = timeLog.Login;
                    row.Cells[TimeLog_LogoutColumn.Name].Value = timeLog.Logout;
                    row.Cells[TimeLog_TypeColumn.Name].Value = timeLog.Type;

                    TimeLogDataGridView.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed to save changes.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task DeleteSelectedTimeLogAsync()
        {
            var result = MessageBox.Show("Are you sure, do you really want to delete the selected time log?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var timeLog = await EmployeeManager.DeleteTimeLogAsync(SelectedTimeLog);

                    if (timeLog != null)
                    {
                        TimeLogDataGridView.Rows.Remove(TimeLogDataGridView.SelectedRows[0]);
                        MessageBox.Show("Deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete time log.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void SaveTimeLogChangesButton_Click(object sender, EventArgs e)
        {
            if (SelectedTimeLog != null)
            {
                SelectedTimeLog.Login = TimeLogDetails_LoginDateTimePicker.Value;
                SelectedTimeLog.Logout = TimeLogDetails_LogoutDateTimePicker.Value;

                await UpdateSelectedTimeLogAsync();
            }
        }

        private async void DeleteTimeLogButton_Click(object sender, EventArgs e)
        {
            if (SelectedTimeLog != null)
            {
                await DeleteSelectedTimeLogAsync(); 
            }
        }

        private void InsertTimeLogButton_Click(object sender, EventArgs e)
        {
            if (EmployeeDataGridView.SelectedRows.Count == 1)
            {
                var employee = EmployeeDataGridView.SelectedRows[0].Cells[EmployeeColumn.Name].Value as Employee;
                var form = new AddTimeLogDialog(employee);
                form.ShowDialog();
                form = null;
            }
        }
    }
}
