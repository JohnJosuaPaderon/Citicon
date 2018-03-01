using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class BillingPaymentHistoryViewForm : Form
    {
        public BillingPaymentHistoryViewForm()
        {
            InitializeComponent();
            _Controller = new BillingPaymentHistoryViewFormController(this);
        }

        private readonly BillingPaymentHistoryViewFormController _Controller;

        public string LinkClientColumn => ClientColumn.Name;
        public string LinkBillingColumn => BillingColumn.Name;
        public string LinkBillingSiNumberColumn => Billing_SiNumberColumn.Name;
        public string LinkBillingAmountDueColumn => Billing_AmountDueColumn.Name;
        public string LinkBillingAmountPaidColumn => Billing_AmountPaidColumn.Name;
        public string LinkBillingPaymentHistoryColumn => BillingPaymentHistoryColumn.Name;
        public string LinkBillingPaymentHistoryPaymentDateColumn => BillingPaymentHistory_PaymentDateColumn.Name;
        public string LinkBillingPaymentHistoryAmountPaidColumn => BillingPaymentHistory_AmountPaidColumn.Name;
        public string LinkBillingPaymentHistoryOrNumberColumn => BillingPaymentHistory_OrNumberColumn.Name;
        public string LinkBillingPaymentHistoryAckNumberColumn => BillingPaymentHistory_AckNumberColumn.Name;
        public string LinkBillingPaymentHistoryCrNumberColumn => BillingPaymentHistory_CrNumberColumn.Name;
        public string LinkBillingPaymentHistoryPrNumberColumn => BillingPaymentHistory_PrNumberColumn.Name;
        public string LinkBillingPaymentHistoryBankColumn => BillingPaymentHistory_BankColumn.Name;
        public string LinkBillingPaymentHistoryChequeNumberColumn => BillingPaymentHistory_ChequeNumberColumn.Name;
        public string LinkBillingPaymentHistoryChequeDateColumn => BillingPaymentHistory_ChequeDateColumn.Name;

        private async void SearchButton_Click(object sender, System.EventArgs e)
        {
            await _Controller.SearchClientAsync();
        }
    }
}
