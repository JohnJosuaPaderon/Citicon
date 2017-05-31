using Citicon.Forms;
using Citicon.ReceivablesIntegration.Forms;
using System;
using System.Windows.Forms;

namespace Citicon.DeliveryApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private DeliveryForm DeliveryForm
        {
            get
            {
                var form = new DeliveryForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }
        private DailyTallySheetForm TallySheetForm
        {
            get
            {
                var form = new DailyTallySheetForm() { MdiParent = this };
                form.FormClosed += (s, e) => form = null;
                return form;
            }
        }

        private LegitimateProjectDesignForm LegitimateProjectDesignForm
        {
            get
            {
                var form = new LegitimateProjectDesignForm() { MdiParent = this };
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

        private void DeliveryButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(DeliveryForm);
        }

        private void TallySheetButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(TallySheetForm);
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

        private void EngineerButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(LegitimateProjectDesignForm);
        }

        private void UserSettingsButton_Click(object sender, EventArgs e)
        {
            OpenMdiChild(UserSettingsForm);
        }
    }
}
