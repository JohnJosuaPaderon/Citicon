using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class DeliveryCancellationForm : Form
    {
        public DeliveryCancellationForm()
        {
            InitializeComponent();
            _Controller = new DeliveryCancellationFormController(this);
        }

        private readonly DeliveryCancellationFormController _Controller;
        public string LinkProjectColumn => nameof(ProjectColumn);
        public string LinkProjectDesignColumn => nameof(ProjectDesignColumn);
        public string LinkDeliveryColumn => nameof(DeliveryColumn);

        private async void DeliveryCancellationForm_Load(object sender, EventArgs e)
        {
            await _Controller.SearchProjectAsync();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            await _Controller.SearchProjectAsync();
        }

        private async void ProjectsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await _Controller.GetProjectDesignsAsync();
        }

        private async void ProjectDesignsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await _Controller.GetDeliveriesAsync();
        }

        private void DeliveriesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            _Controller.DisplayCurrentDelivery();
        }

        private async void CancelDeliveryButton_Click(object sender, EventArgs e)
        {
            await _Controller.CancelAsync();
        }
    }
}
