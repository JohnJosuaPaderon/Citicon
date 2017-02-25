using Citicon.Data;
using Citicon.DataManager;
using org.mariuszgromada.math.mxparser;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.PayrollIntegration.Forms
{
    public partial class SemiMonthlyPayrollForm : Form
    {
        public SemiMonthlyPayrollForm()
        {
            InitializeComponent();
            BranchManager = new BranchManager();
            PayrollManager = new PayrollManager();
        }

        private BranchManager BranchManager { get; }
        private PayrollManager PayrollManager { get; }

        private async Task LoadBranchListAsync()
        {
            var branches = await BranchManager.GetListAsync();

            if (branches != null)
            {
                cmbxSelectPlant.Items.Clear();
                cmbxSelectPlant.Items.AddRange(branches);
            }
        }

        private async Task GeneratePayrollAsync()
        {
            var branch = (Branch)cmbxSelectPlant.SelectedItem;
            var rangeDate = new DateTimeRange(dtpSelectRange_From.Value, dtpSelectRange_To.Value);

            if (branch != null)
            {
                dgvPayrollItems.Rows.Clear();

                try
                {
                    var payrollItems = await PayrollManager.GeneratePayrollAsync(rangeDate, branch);

                    if (payrollItems != null)
                    {
                        foreach (var item in payrollItems)
                        {
                            addEmployeePayrollToDataGridView(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Export()
        {
            var branch = (Branch)cmbxSelectPlant.SelectedItem;
            var rangeDate = new DateTimeRange(dtpSelectRange_From.Value, dtpSelectRange_To.Value);

            if (dgvPayrollItems.Rows.Count > 0)
            {
                if (branch != null)
                {
                    var payroll = new Payroll();
                    payroll.Branch = branch;
                    payroll.DateRange = rangeDate;

                    foreach (DataGridViewRow row in dgvPayrollItems.Rows)
                    {
                        payroll.Items.Add(((EmployeePayroll)row.Cells[colPayrollItem.Name].Value));
                    }

                    try
                    {
                        PayrollManager.ExportPayroll(payroll);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty payroll!");
            }
        }

        private void addEmployeePayrollToDataGridView(EmployeePayroll employeePayroll)
        {
            if (employeePayroll != null)
            {
                var row = new DataGridViewRow();
                row.Height = 30;
                row.Cells.Add(CreateTextBoxCell(employeePayroll));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.Employee));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.VLSL));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.DailyRate));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.BasicPay));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.RegularWorkingHours));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.NightDifferentialHours));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.SundayHours));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.SpecialHolidayHours));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.SpecialHolidayOvertimeHours));

                dgvPayrollItems.Rows.Add(row);
            }
        }

        private DataGridViewTextBoxCell CreateTextBoxCell(object value)
        {
            return new DataGridViewTextBoxCell { Value = value };
        }

        private async void SemiMonthlyPayrollForm_Load(object sender, EventArgs e)
        {
            await LoadBranchListAsync();
        }

        private async void btnGeneratePayroll_Click(object sender, EventArgs e)
        {
            await GeneratePayrollAsync();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export();
        }
    }
}
