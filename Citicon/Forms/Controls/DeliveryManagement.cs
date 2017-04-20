using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Controls
{
    public partial class DeliveryManagement : UserControl
    {
        public DeliveryManagement()
        {
            InitializeComponent();
        }

        public event EventHandler CloseDialogRequested;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you really want to cancel delivery?", "Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                CloseDialogRequested?.Invoke(this, new EventArgs());
            }
        }
    }
}
