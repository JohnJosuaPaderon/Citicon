using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class DeliveryManagementForm : Form
    {
        public DeliveryManagementForm()
        {
            InitializeComponent();
        }

        private void DeliveryManagement_CloseDialogRequested(object sender, EventArgs e)
        {
            Close();
        }
    }
}
