using Citicon.Data;
using Citicon.DataManager;
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
            var dateRange = new DateTimeRange(dtpSelectRange_From.Value, dtpSelectRange_To.Value);
            var payroll = new Payroll
            {
                Branch = branch,
                DateRange = dateRange
            };

            if (branch != null)
            {
                dgvPayrollItems.Rows.Clear();

                try
                {
                    var payrollItems = await PayrollManager.GeneratePayrollAsync(payroll);

                    if (payrollItems != null)
                    {
                        foreach (var item in payrollItems)
                        {
                            payroll.Employees.Add(item);
                            AddEmployeePayrollToDataGridView(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task ExportAsync()
        {
            var branch = (Branch)cmbxSelectPlant.SelectedItem;
            var rangeDate = new DateTimeRange(dtpSelectRange_From.Value, dtpSelectRange_To.Value);

            if (dgvPayrollItems.Rows.Count > 0)
            {
                if (branch != null)
                {
                    var payroll = new Payroll
                    {
                        Branch = branch,
                        DateRange = rangeDate
                    };

                    foreach (DataGridViewRow row in dgvPayrollItems.Rows)
                    {
                        payroll.Employees.Add(((EmployeePayroll)row.Cells[colPayrollItem.Name].Value));
                    }   

                    try
                    {
                        btnExport.Enabled = false;
                        btnGeneratePayroll.Enabled = false;
                        await PayrollManager.ExportPayrollAsync(payroll);
                        MessageBox.Show("Successfully exported!");
                        dgvPayrollItems.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        btnExport.Enabled = true;
                        btnGeneratePayroll.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty payroll!");
            }
        }

        private void AddEmployeePayrollToDataGridView(EmployeePayroll employeePayroll)
        {
            if (employeePayroll != null)
            {
                var row = new DataGridViewRow
                {
                    Height = 30
                };

                row.Cells.Add(CreateTextBoxCell(employeePayroll));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.Employee));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.VLSL));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.Rate));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.BasicPay));
                row.Cells.Add(CreateTextBoxCell(employeePayroll.RegularWorkingHours));

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

        private async void btnExport_Click(object sender, EventArgs e)
        {
            await ExportAsync();
        }
    }
}
