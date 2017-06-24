using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class AddEditEmployeePositionDialog : Form
    {
        public static void AddEmployeePosition()
        {
            var dialog = new AddEditEmployeePositionDialog(new JobPosition(), DataDialogMode.Add);
            dialog.ShowDialog();
            dialog = null;
        }

        public static void EditEmployeePosition(JobPosition employeePosition)
        {
            var dialog = new AddEditEmployeePositionDialog(employeePosition, DataDialogMode.Edit);
            dialog.ShowDialog();
            dialog = null;
        }

        private JobPosition _EmployeePosition;
        private DataDialogMode _Mode;

        public JobPosition EmployeePosition
        {
            get { return _EmployeePosition; }
            set
            {
                if (_EmployeePosition != value)
                {
                    _EmployeePosition = value;
                    UpdateUI();
                }
            }
        }

        public DataDialogMode Mode
        { 
            get { return _Mode; }
            set
            {
                if (_Mode != value)
                {
                    _Mode = value;
                    UpdateMode();
                }
            }
        }

        private void UpdateMode()
        {
            switch (Mode)
            {
                case DataDialogMode.None:
                    Text = "Nothing to do.";
                    break;
                case DataDialogMode.Add:
                    Text = "Add new Position";
                    break;
                case DataDialogMode.Edit:
                    Text = "Edit Position";
                    break;
            }
        }

        private void UpdateUI()
        {
            NameTextBox.Text = EmployeePosition.Name;
            DepartmentComboBox.SelectedItem = EmployeePosition.Department;
        }

        private AddEditEmployeePositionDialog(JobPosition employeePosition, DataDialogMode mode)
        {
            InitializeComponent();
            EmployeePosition = employeePosition ?? throw new ArgumentNullException(nameof(employeePosition));
            Mode = mode;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task GetDepartmentListAsync()
        {
            DepartmentComboBox.Items.Clear();

            try
            {
                var departments = await DepartmentManager.GetListAsync();

                if (departments != null && departments.Any())
                {
                    DepartmentComboBox.Items.AddRange(departments.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void AddEditEmployeePositionDialog_Load(object sender, EventArgs e)
        {
            await GetDepartmentListAsync();
            UpdateUI();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            EmployeePosition.Name = NameTextBox.Text;
            EmployeePosition.Department = DepartmentComboBox.SelectedItem as Department;
            switch (Mode)
            {
                case DataDialogMode.None:
                    MessageBox.Show("Nothing to be done.");
                    break;
                case DataDialogMode.Add:
                    await InsertEmployeePositionAsync();
                    break;
                case DataDialogMode.Edit:
                    await UpdateEmployeePositionAsync();
                    break;
            }
        }

        private async Task UpdateEmployeePositionAsync()
        {
            try
            {
                var employeePosition = await JobPositionManager.UpdateAsync(EmployeePosition);

                if (employeePosition != null)
                {
                    MessageBox.Show("Successfully modified.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to modify.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task InsertEmployeePositionAsync()
        {
            try
            {
                var employeePosition = await JobPositionManager.InsertAsync(EmployeePosition);

                if (employeePosition != null)
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
    }
}
