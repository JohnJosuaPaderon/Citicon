using Citicon.Data;
using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class DeliveryManagementForm : Form
    {
        public DeliveryManagementForm(ProjectDesign projectDesign)
        {
            InitializeComponent();
            ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
        }

        public ProjectDesign ProjectDesign
        {
            get { return DeliveryManagement.ProjectDesign; }
            private set
            {
                DeliveryManagement.ProjectDesign = value;
            }
        }

        private void DeliveryManagement_CloseDialogRequested(object sender, EventArgs e)
        {
            Close();
        }
    }
}
