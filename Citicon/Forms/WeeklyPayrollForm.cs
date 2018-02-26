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
    }
}
