using Citicon.Data;
using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class AddEditClientAdvancePaymentForm : Form
    {
        public static ClientAdvancePayment Add(Client client)
        {
            if (client != null)
            {
                var instance = new AddEditClientAdvancePaymentForm(new ClientAdvancePayment(client)
                {
                    TransactionDate = DateTime.Now
                });
                instance.ShowDialog();
                return instance._Controller.AdvancePayment;
            }
            else
            {
                return null;
            }
        }

        private AddEditClientAdvancePaymentForm(ClientAdvancePayment advancePayment)
        {
            InitializeComponent();
            _Controller = new AddEditClientAdvancePaymentFormController(this, advancePayment);
        }

        private readonly AddEditClientAdvancePaymentFormController _Controller;

        private void AddEditClientAdvancePaymentForm_Load(object sender, EventArgs e)
        {
            _Controller.Initialize();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            await _Controller.SaveAdvancePaymentAsync();
        }

        private void CancelFormButton_Click(object sender, EventArgs e)
        {
            _Controller.Cancel();
        }
    }
}
