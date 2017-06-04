using Citicon.Forms;
using System;
using System.Windows.Forms;

namespace Citicon.HumanResourceApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddEditEmployeeForm();
            form.ShowDialog();
            form = null;
        }
    }
}
