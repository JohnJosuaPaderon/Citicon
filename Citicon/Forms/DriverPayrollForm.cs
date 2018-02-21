using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class DriverPayrollForm : Form
    {
        public DriverPayrollForm()
        {
            InitializeComponent();
            _Controller = new DriverPayrollFormController(this);
        }

        private readonly DriverPayrollFormController _Controller;

        private async void GenerateButton_Click(object sender, System.EventArgs e)
        {
            await _Controller.GenerateAsync();
        }

        private async void DriverPayrollForm_Load(object sender, System.EventArgs e)
        {
            await _Controller.InitializeAsync();
        }

        private void ChangeCutOffLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
