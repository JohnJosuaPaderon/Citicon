using Citicon.Data;
using Citicon.DataManager;
using Citicon.DataProcess;
using Citicon.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public sealed class OutgoingStockReportFormController : FormControllerBase<OutgoingStockReportForm>
    {
        public OutgoingStockReportFormController(OutgoingStockReportForm form) : base(form)
        {
            _Option = new GetFilteredOutgoingStockListOption();
            _ItemManager = new ItemManager();
            _BranchManager = new BranchManager();
            _CompanyManager = new CompanyManager();
            _VehicleManager = new VehicleManager();
        }

        private readonly GetFilteredOutgoingStockListOption _Option;
        private readonly ItemManager _ItemManager;
        private readonly BranchManager _BranchManager;
        private readonly CompanyManager _CompanyManager;
        private readonly VehicleManager _VehicleManager;

        private IEnumerable<OutgoingStock> OutgoingStocks;

        public async Task InitializeAsync()
        {
            await LoadItemsAsync();
            await LoadBranchesAsync();
            await LoadCompaniesAsync();
            await LoadVehiclesAsync();
        }

        public async Task GetFilteredOutgoingStocksAsync()
        {
            try
            {
                EnableControls(false);
                _Form.OutgoingStockDataGridView.Rows.Clear();
                ResetOption();
                OutgoingStocks = await OutgoingStockManager.GetFilteredListAsync(_Option);

                if (OutgoingStocks != null && OutgoingStocks.Any())
                {
                    foreach (var outgoingStock in OutgoingStocks)
                    {
                        AddToUi(outgoingStock);
                    }
                }
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
            }
            finally
            {
                EnableControls(true);
            }
        }

        public async Task ExportAsync()
        {
            try
            {
                EnableControls(false);
                await OutgoingStockManager.ExportReportAsync(OutgoingStocks);
                _MessageDisplay.Inform("Successfully exported.");
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
            }
            finally
            {
                EnableControls(true);
            }
        }

        private async Task LoadItemsAsync()
        {
            try
            {
                _Form.DescriptionFilterComboBox.Items.Clear();
                var result = await _ItemManager.GetListAsync();

                if (result != null && result.Any())
                {
                    _Form.DescriptionFilterComboBox.Items.AddRange(result);
                }
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
            }
        }

        private async Task LoadBranchesAsync()
        {
            try
            {
                _Form.BranchFilterComboBox.Items.Clear();
                var result = await _BranchManager.GetListAsync();

                if (result != null && result.Any())
                {
                    _Form.BranchFilterComboBox.Items.AddRange(result);
                }
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
            }
        }

        private async Task LoadCompaniesAsync()
        {
            try
            {
                _Form.CompanyFilterComboBox.Items.Clear();
                var result = await _CompanyManager.GetListAsync();

                if (result != null && result.Any())
                {
                    _Form.CompanyFilterComboBox.Items.AddRange(result);
                }
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
            }
        }

        private async Task LoadVehiclesAsync()
        {
            try
            {
                _Form.VehicleFilterComboBox.Items.Clear();
                var result = await _VehicleManager.GetListAsync();

                if (result != null && result.Any())
                {
                    _Form.VehicleFilterComboBox.Items.AddRange(result);
                }
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
            }
        }

        private void ResetOption()
        {
            _Option.FilterByBranch = _Form.BranchFilterCheckBox.Checked;
            _Option.FilterByCompany = _Form.CompanyFilterCheckBox.Checked;
            _Option.FilterByItem = _Form.DescriptionFilterCheckBox.Checked;
            _Option.FilterByTransactionDateRange = _Form.TransactionDateFilterCheckBox.Checked;
            _Option.FilterByVehicle = _Form.VehicleFilterCheckBox.Checked;
            _Option.Branch = _Form.BranchFilterComboBox.SelectedItem as Branch;
            _Option.Company = _Form.CompanyFilterComboBox.SelectedItem as Company;
            _Option.Item = _Form.DescriptionFilterComboBox.SelectedItem as Item;
            _Option.TransactionDateRange.Begin = _Form.TransactionDateRangeBeginFilterDateTimePicker.Value;
            _Option.TransactionDateRange.End = _Form.TransactionDateRangeEndFilterDateTimePicker.Value;
        }

        private void EnableControls(bool enabled)
        {
            _Form.BranchFilterCheckBox.Enabled = enabled;
            _Form.BranchFilterComboBox.Enabled = enabled;
            _Form.DescriptionFilterCheckBox.Enabled = enabled;
            _Form.DescriptionFilterComboBox.Enabled = enabled;
            _Form.CompanyFilterCheckBox.Enabled = enabled;
            _Form.CompanyFilterComboBox.Enabled = enabled;
            _Form.VehicleFilterCheckBox.Enabled = enabled;
            _Form.VehicleFilterComboBox.Enabled = enabled;
            _Form.TransactionDateFilterCheckBox.Enabled = enabled;
            _Form.TransactionDateRangeBeginFilterDateTimePicker.Enabled = enabled;
            _Form.TransactionDateRangeEndFilterDateTimePicker.Enabled = enabled;
            _Form.SearchButton.Enabled = enabled;
            _Form.ExportButton.Enabled = enabled;
        }

        private void AddToUi(OutgoingStock outgoingStock)
        {
            if (outgoingStock != null)
            {
                _Form.OutgoingStockDataGridView.Rows.Add(new DataGridViewRow()
                    .SetHeight(30)
                    .AddTextBoxCell(outgoingStock)
                    .AddTextBoxCell(outgoingStock.IssuanceSlipNumber)
                    .AddTextBoxCell(outgoingStock.TransactionDate)
                    .AddTextBoxCell(outgoingStock.Item?.Code)
                    .AddTextBoxCell(outgoingStock.Item)
                    .AddTextBoxCell(outgoingStock.Quantity)
                    .AddTextBoxCell(outgoingStock.MeasurementUnit)
                    .AddTextBoxCell(outgoingStock.UnitCost)
                    .AddTextBoxCell(outgoingStock.Supplier)
                    .AddTextBoxCell(outgoingStock.Vehicle));
            }
        }
    }
}
