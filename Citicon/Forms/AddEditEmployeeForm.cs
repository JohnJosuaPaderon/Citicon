using Citicon.Data;
using Citicon.Forms.Dialogs;
using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class AddEditEmployeeForm : Form
    {
        private AddEditEmployeeForm(DataDialogMode mode, Employee employee)
        {
            InitializeComponent();
            AddEditEmployeeControl.Mode = mode;
            AddEditEmployeeControl.Employee = employee;
        }

        public static AddEditEmployeeForm AddEmployee()
        {
            return new AddEditEmployeeForm(DataDialogMode.Add, new Employee());
        }

        public static AddEditEmployeeForm EditEmployee(Employee employee)
        {
            return new AddEditEmployeeForm(DataDialogMode.Edit, employee ?? throw new ArgumentNullException(nameof(employee)));
        }

        private void AddEditEmployeeControl_FormCancelRequested(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEditEmployeeForm_Load(object sender, EventArgs e)
        {
            switch (AddEditEmployeeControl.Mode)
            {
                case DataDialogMode.None:
                    Text = "Add or Edit Employee";
                    break;
                case DataDialogMode.Add:
                    Text = "Add New Employee";
                    break;
                case DataDialogMode.Edit:
                    Text = "Edit Employee";
                    break;
            }
        }
    }
}
