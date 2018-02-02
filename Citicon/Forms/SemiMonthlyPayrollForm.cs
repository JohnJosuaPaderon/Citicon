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

        private void GenerateButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
