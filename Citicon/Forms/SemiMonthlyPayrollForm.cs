using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class SemiMonthlyPayrollForm : Form
    {
        public SemiMonthlyPayrollForm()
        {
            InitializeComponent();
            _Controller = new SemiMonthlyPayrollFormController(this);
        }

        private readonly SemiMonthlyPayrollFormController _Controller;
        public string LinkSemiMonthlyPayrollEmployeeColumn => SemiMonthlyPayrollEmployeeColumn.Name;
        public string LinkSemiMonthlyPayrollEmployeeDailyRateColumn => SemiMonthlyPayrollEmployee_DailyRateColumn.Name;
        public string LinkSemiMonthlyPayrollEmployeeGrossPayColumn => SemiMonthlyPayrollEmployee_GrossPayColumn.Name;
        public string LinkSemiMonthlyPayrollEmployeeTotalDeductionColumn => SemiMonthlyPayrollEmployee_TotalDeductionColumn.Name;
        public string LinkSemiMonthlyPayrollEmployeeNetPayColumn => SemiMonthlyPayrollEmployee_NetPayColumn.Name;

        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            await _Controller.GenerateAsync();
        }

        private async void SemiMonthlyPayrollForm_Load(object sender, EventArgs e)
        {
            await _Controller.InitializeAsync();
        }

        protected override void OnClosed(EventArgs e)
        {
            _Controller.Dispose();
            base.OnClosed(e);
        }

        private async void SavePrintButton_Click(object sender, EventArgs e)
        {
            await _Controller.SavePrintAsync();
        }

        private async void ViewTimeLogsButton_Click(object sender, EventArgs e)
        {
            await _Controller.ViewTimeLogsAsync();
        }

        private void ChangeCutOffLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _Controller.ChangeCutOff();
        }
    }
}
