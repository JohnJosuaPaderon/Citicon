using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class ClientAdvancePaymentManagementForm : Form
    {
        public ClientAdvancePaymentManagementForm()
        {
            InitializeComponent();
            _Controller = new ClientAdvancePaymentManagementFormController(this);
        }

        private readonly ClientAdvancePaymentManagementFormController _Controller;

        private void ClientAdvancePaymentManagementForm_Load(object sender, EventArgs e)
        {

        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            await _Controller.SearchAsync();
        }

        private async void AddAdvancePaymentButton_Click(object sender, EventArgs e)
        {
            await _Controller.AddAsync();
        }
    }
}
