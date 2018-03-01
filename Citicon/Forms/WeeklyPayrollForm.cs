using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class WeeklyPayrollForm : Form
    {
        public WeeklyPayrollForm()
        {
            InitializeComponent();
            _Controller = new WeeklyPayrollFormController(this);
        }

        private readonly WeeklyPayrollFormController _Controller;

        public string LinkPayrollEmployeeColumn => WeeklyPayrollEmployeeColumn.Name;
        public string LinkPayrollEmployeeEmployeeColumn => WeeklyPayrollEmployee_EmployeeColumn.Name;
        public string LinkPayrollEmployeeDailyRateColumn => WeeklyPayrollEmployee_DailyRateColumn.Name;
        public string LinkPayrollEmployeeBasicPayColumn => WeeklyPayrollEmployee_BasicPayColumn.Name;
        public string LinkPayrollEmployeeGrossPayColumn => WeeklyPayrollEmployee_GrossPayColumn.Name;
        public string LinkPayrollEmployeeTotalDeductionColumn => WeeklyPayrollEmployee_TotalDeductionColumn.Name;
        public string LinkPayrollEmployeeNetPayColumn => WeeklyPayrollEmployee_NetPayColumn.Name;

        private void ChangeCutOffLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _Controller.ChangeCutOff();
        }

        private async void WeeklyPayrollForm_Load(object sender, System.EventArgs e)
        {
            await _Controller.InitializeAsync();
        }

        private async void GenerateButton_Click(object sender, System.EventArgs e)
        {
            await _Controller.GenerateAsync();
        }

        private async void ViewTimeLogsButton_Click(object sender, System.EventArgs e)
        {
            await _Controller.ViewTimeLogsAsync();
        }

        private async void SavePrintButton_Click(object sender, System.EventArgs e)
        {
            await _Controller.SavePrintAsync();
        }
    }
}
