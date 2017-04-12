using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class AddTimeLogDialog : Form
    {
        public AddTimeLogDialog(Employee employee)
        {
            InitializeComponent();
            Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private Employee Employee { get; }
        private EmployeeLogin _EmployeeLogin;
        
        public EmployeeLogin EmployeeLogin
        {
            get { return _EmployeeLogin; }
            private set
            {
                if (_EmployeeLogin != value)
                {
                    _EmployeeLogin = value;
                    UpdateEmployeeLoginUI();
                }
            }
        }

        private void UpdateEmployeeLoginUI()
        {
            EmployeeTextBox.Text = EmployeeLogin?.Employee?.ToString();
        }

        private async Task GetEmployeeLoginAsync()
        {
            try
            {
                EmployeeLogin = await EmployeeManager.GetEmployeeLoginAsync(Employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task SaveAsync()
        {
            var timeLog = new TimeLog()
            {
                EmployeeLogin = EmployeeLogin,
                Login = LoginCheckBox.Checked ? new DateTime?(LoginDateTimePicker.Value) : null,
                Logout = LogoutCheckBox.Checked ? new DateTime?(LogoutDateTimePicker.Value) : null
            };
            try
            {
                timeLog = await EmployeeManager.InsertTimeLogAsync(timeLog);

                if (timeLog != null)
                {
                    MessageBox.Show("Successfully added.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to add.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void AddTimeLogDialog_Load(object sender, EventArgs e)
        {
            await GetEmployeeLoginAsync();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            await SaveAsync();
        }

        private void LoginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoginDateTimePicker.Enabled = LoginCheckBox.Checked;
        }

        private void LogoutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LogoutDateTimePicker.Enabled = LogoutCheckBox.Checked;
        }
    }
}
