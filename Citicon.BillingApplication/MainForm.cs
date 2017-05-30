using Citicon.Data;
using Citicon.Forms;
using System;
using System.Windows.Forms;

namespace Citicon.BillingApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private BillingForm BillingForm
        {
            get
            {
                var form = new BillingForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private void InitializeSecurity()
        {
            UserSettingsButton.Enabled = User.CurrentUser.Admin;
        }

        private void OpenMdiChild(Form form)
        {
            if (ActiveMdiChild != null && ActiveMdiChild.GetType() == form.GetType())
            {
                return;
            }
            else
            {
                if (ActiveMdiChild != null)
                {
                    ActiveMdiChild.Close();
                }

                form.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeSecurity();
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(BillingForm);
        }
    }
}
