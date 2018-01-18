namespace Citicon.Forms
{
    internal sealed class InventoryReportFormController : FormControllerBase<InventoryReportForm>
    {
        public InventoryReportFormController(InventoryReportForm form) : base(form)
        {
        }

        private InventoryStocksReportForm IncomingStocksForm
        {
            get
            {
                var result = new InventoryStocksReportForm()
                {
                    MdiParent = _Form
                };
                result.FormClosed += (s, e) => result = null;
                return result;
            }
        }

        public OutgoingStockReportForm OutgoingStocksForm
        {
            get
            {
                var result = new OutgoingStockReportForm()
                {
                    MdiParent = _Form
                };
                result.FormClosed += (s, e) => result = null;
                return result;
            }
        }

        public void OpenChild(InventoryReportFormContent content)
        {
            if (_Form.ActiveMdiChild != null)
            {
                _Form.ActiveMdiChild.Close();
            }

            switch (content)
            {
                case InventoryReportFormContent.IncomingStocks:
                    IncomingStocksForm.Show();
                    break;
                case InventoryReportFormContent.OutgoingStocks:
                    OutgoingStocksForm.Show();
                    break;
            }
        }
    }
}
