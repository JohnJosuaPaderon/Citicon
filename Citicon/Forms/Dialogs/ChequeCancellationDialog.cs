using System;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class ChequeCancellationDialog : Form
    {
        public ChequeCancellationDialog()
        {
            InitializeComponent();
            _Controller = new ChequeCancellationController(this);
        }

        private readonly ChequeCancellationController _Controller;

        private void ChequeCancellationDialog_Load(object sender, EventArgs e)
        {
            _Controller.Initialize();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _Controller.UpdateBankAccountsAsync();
        }

        private async void CancelChequeButton_Click(object sender, EventArgs e)
        {
            await _Controller.CancelChequeAsync();
        }
    }
}
