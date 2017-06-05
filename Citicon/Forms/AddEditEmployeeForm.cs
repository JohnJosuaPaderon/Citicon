using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class AddEditEmployeeForm : Form
    {
        public AddEditEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEditEmployeeControl_FormCancelRequested(object sender, EventArgs e)
        {
            Close();
        }
    }
}
