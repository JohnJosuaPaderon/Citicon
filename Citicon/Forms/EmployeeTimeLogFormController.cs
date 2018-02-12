using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.DataLinks;
using Citicon.WindowsForm;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    internal sealed class EmployeeTimeLogFormController : FormControllerBase<EmployeeTimeLogForm>
    {
        public EmployeeTimeLogFormController(EmployeeTimeLogForm form, Employee employee, DateTimeRange cutOff) : base(form)
        {
            _TimeLogs = new DataGridViewItemSource<TimeLog>(_Form.TimeLogsDataGridView, AddRow, TimeLogChanged, "TimeLogColumn", RefreshRow);
            _Employee = employee;
            _CutOff = cutOff;
        }

        private readonly Employee _Employee;
        private readonly DateTimeRange _CutOff;

        public bool HasChanges { get; private set; }

        public void Close()
        {
            _Form.Close();
        }

        private readonly DataGridViewItemSource<TimeLog> _TimeLogs;
        private TimeLog CurrentTimeLog;

        private DataGridViewRow AddRow(TimeLog timeLog)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(timeLog)
                .AddTextBoxCell(timeLog.Login)
                .AddTextBoxCell(timeLog.Logout)
                .AddTextBoxCell(timeLog.Type);
        }

        private void RefreshRow(DataGridViewRow row, TimeLog timeLog)
        {
            row.Cells["TimeLog_LoginColumn"].Value = timeLog.Login;
            row.Cells["TimeLog_LogoutColumn"].Value = timeLog.Logout;
        }

        private void TimeLogChanged(TimeLog timeLog)
        {
            if (timeLog != null)
            {
                _Form.LoginDateTimePicker.Value = timeLog.Login ?? DateTime.Now;
                _Form.LogoutDateTimePicker.Value = timeLog.Logout ?? DateTime.Now;
            }

            CurrentTimeLog = timeLog;
        }

        public async Task LoadTimeLogsAsync()
        {
            _TimeLogs.Clear();
            var timeLogs = await EmployeeManager.GetTimeLogListAsync(_Employee, _CutOff);

            if (timeLogs != null && timeLogs.Any())
            {
                _TimeLogs.AddRange(timeLogs);
            }
        }

        public async Task InitializeAsync()
        {
            _Form.EmployeeTextBox.Text = _Employee.ToString();
            await LoadTimeLogsAsync();
        }

        public async Task DeleteAsync()
        {
            var selectedTimeLog = _TimeLogs.SelectedItem;

            if (selectedTimeLog != null)
            {
                await EmployeeManager.DeleteTimeLogAsync(selectedTimeLog);
                _TimeLogs.Remove(selectedTimeLog);
                HasChanges = true;
            }
        }

        public async Task SaveChangesAsync()
        {
            var selectedTimeLog = _TimeLogs.SelectedItem;

            if (selectedTimeLog != null)
            {
                selectedTimeLog.Login = _Form.LoginDateTimePicker.Value;
                selectedTimeLog.Logout = _Form.LogoutDateTimePicker.Value;

                await EmployeeManager.UpdateTimeLogAsync(selectedTimeLog);
                _TimeLogs.RefreshSelected();
                HasChanges = true;
            }
        }
    }
}
