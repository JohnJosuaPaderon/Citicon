using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class TimeLogCalculatorForm : Form
    {
        public TimeLogCalculatorForm()
        {
            InitializeComponent();
            _Controller = new TimeLogCalculatorFormController(this);
        }

        private readonly TimeLogCalculatorFormController _Controller;

        private async void SearchEmployeeButton_Click(object sender, EventArgs e)
        {
            await _Controller.SearchAsync();
        }
    }
}
