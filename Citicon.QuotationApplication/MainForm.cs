using Citicon.Forms;
using System;
using System.Windows.Forms;

namespace Citicon.QuotationApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public ClientManagementForm ClientManagementForm
        {
            get
            {
                var form = new ClientManagementForm() { MdiParent = this };
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

        private DeliverySchedulerForm DeliverySchedulerForm
        {
            get
            {
                var form = new DeliverySchedulerForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private PurchaseOrderManagementForm PurchaseOrderManagementForm
        {
            get
            {
                var form = new PurchaseOrderManagementForm() { MdiParent = this };
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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(ClientManagementForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenMdiChild(ClientManagementForm);
        }

        private void UserSettingsButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(UserSettingsForm);
        }

        private void DeliverySchedulerButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(DeliverySchedulerForm);
        }

        private void PurchaseOrderButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(PurchaseOrderManagementForm);
        }
    }
}
