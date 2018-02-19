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

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenMdiChild(EmployeeForm);
        }

        public EmployeeForm EmployeeForm
        {
            get
            {
                var form = new EmployeeForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        public UserSettingsForm UserSettingsForm
        {
            get
            {
                var form = new UserSettingsForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
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

        private void UserSettingsButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(UserSettingsForm);
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(EmployeeForm);
        }
    }
}
