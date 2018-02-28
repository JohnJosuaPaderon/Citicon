using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Threading.Tasks;

namespace Citicon.Forms
{
    internal sealed class AddEditClientAdvancePaymentFormController : FormControllerBase<AddEditClientAdvancePaymentForm>
    {
        public AddEditClientAdvancePaymentFormController(AddEditClientAdvancePaymentForm form, ClientAdvancePayment advancePayment) : base(form)
        {
            form.AddedValueNumericUpDown.Maximum = 100_000_000;

            AdvancePayment = advancePayment ?? throw new ArgumentNullException(nameof(advancePayment));
        }

        public ClientAdvancePayment AdvancePayment { get; private set; }

        public void Initialize()
        {
            _Form.ClientTextBox.Text = AdvancePayment.Client?.CompanyName;
        }

        public async Task SaveAdvancePaymentAsync()
        {
            if (AdvancePayment != null)
            {
                PrepareData();
                try
                {
                    var result = await ClientManager.SaveAsync(AdvancePayment);

                    if (result != null)
                    {
                        _MessageDisplay.Inform("Successfully saved.");
                        _Form.Close();
                    }
                    else
                    {
                        _MessageDisplay.Error("Failed to save.");
                    }
                }
                catch (Exception ex)
                {
                    _MessageDisplay.Exception(ex);
                }
            }
            else
            {
                _MessageDisplay.Error("Invalid data.");
            }
        }

        private void PrepareData()
        {
            AdvancePayment.AddedValue = _Form.AddedValueNumericUpDown.Value;
        }

        public void Cancel()
        {
            AdvancePayment = null;
            _Form.Close();
        }
    }
}
