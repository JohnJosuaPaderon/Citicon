using Citicon.Data;
using Citicon.Forms.Dialogs;
using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class AddEditEmployeeForm : Form
    {
        private AddEditEmployeeForm(DataDialogMode mode, Employee employee, EmployeePayrollAddition payrollAddition, EmployeePayrollDeduction payrollDeduction)
        {
            InitializeComponent();
            AddEditEmployeeControl.Mode = mode;
            AddEditEmployeeControl.Employee = employee ?? throw new ArgumentNullException(nameof(employee));
            AddEditEmployeeControl.EmployeePayrollAddition = payrollAddition ?? throw new ArgumentNullException(nameof(payrollAddition));
            AddEditEmployeeControl.EmployeePayrollDeduction = payrollDeduction ?? throw new ArgumentNullException(nameof(payrollDeduction));
        }

        public static AddEditEmployeeForm AddEmployee()
        {
            return new AddEditEmployeeForm(DataDialogMode.Add, new Employee(), new EmployeePayrollAddition(), new EmployeePayrollDeduction());
        }

        public static AddEditEmployeeForm EditEmployee(Employee employee, EmployeePayrollAddition payrollAddition, EmployeePayrollDeduction payrollDeduction)
        {
            return new AddEditEmployeeForm(DataDialogMode.Edit, employee, payrollAddition ?? new EmployeePayrollAddition(), payrollDeduction ?? new EmployeePayrollDeduction());
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

        private void AddEditEmployeeControl_Load(object sender, EventArgs e)
        {

        }
    }
}
