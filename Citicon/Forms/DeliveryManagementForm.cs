using Citicon.Data;
using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class DeliveryManagementForm : Form
    {
        public DeliveryManagementForm(ProjectDesign projectDesign, DeliveryScheduleStatus deliveryScheduleStatus)
        {
            InitializeComponent();
            ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
            DeliveryScheduleStatus = deliveryScheduleStatus;
        }

        public DeliveryScheduleStatus DeliveryScheduleStatus
        {
            get { return DeliveryManagement.DeliveryScheduleStatus; }
            set
            {
                DeliveryManagement.DeliveryScheduleStatus = value;
            }
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
