using Citicon.Data;
using Citicon.Forms;
using Citicon.ReceivablesIntegration.Forms;
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

        private SalesInvoiceAssignmentForm SalesInvoiceAssignmentForm
        {
            get
            {
                var form = new SalesInvoiceAssignmentForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private BillingPaymentForm BillingPaymentForm
        {
            get
            {
                var form = new BillingPaymentForm() { MdiParent = this };
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

        private DailyTallySheetForm DailyTallySheetForm
        {
            get
            {
                var form = new DailyTallySheetForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private UserSettingsForm UserSettingsForm
        {
            get
            {
                var form = new UserSettingsForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private DeliveryConfirmationForm DeliveryConfirmationForm
        {
            get
            {
                var form = new DeliveryConfirmationForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private PurchaseOrderMonitoringForm PurchaseOrderMonitoringForm
        {
            get
            {
                var form = new PurchaseOrderMonitoringForm() { MdiParent = this };
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
            //InitializeSecurity();
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(BillingForm);
        }

        private void SalesInvoiceButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(SalesInvoiceAssignmentForm);
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(BillingPaymentForm);
        }

        private void PurchaseOrderButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(PurchaseOrderManagementForm);
        }

        private void TallySheetButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(DailyTallySheetForm);
        }

        private void UserSettingsButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(UserSettingsForm);
        }

        private void DeliveryConfirmationButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(DeliveryConfirmationForm);
        }

        private void PurchaseOrderMonitorButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(PurchaseOrderMonitoringForm);
        }
    }
}
