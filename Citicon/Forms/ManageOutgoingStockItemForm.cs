using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class ManageOutgoingStockItemForm : Form
    {
        public static (Transaction Transaction, bool IsCancelled) Add(Item item, decimal? latestPrice, DateTime? latestPriceDate)
        {
            var dialog = new ManageOutgoingStockItemForm(new Transaction
            {
                Item = item,
                LatestPrice = latestPrice,
                LatestPriceDate = latestPriceDate
            });
            dialog.ShowDialog();

            return (dialog.CurrentTransaction, dialog.IsCancelled);
        }

        public static (Transaction Transaction, bool IsCancelled) Edit(Transaction transaction)
        {
            var dialog = new ManageOutgoingStockItemForm(transaction);
            dialog.ShowDialog();

            return (dialog.CurrentTransaction, dialog.IsCancelled);
        }

        public ManageOutgoingStockItemForm(Transaction currentTransaction)
        {
            CurrentTransaction = currentTransaction;

            InitializeComponent();
            _BranchManager = new BranchManager();
            _CompanyManager = new CompanyManager();
            _VehicleManager = new VehicleManager();
        }

        public Transaction CurrentTransaction { get; private set; }
        public bool IsCancelled { get; private set; }

        private readonly BranchManager _BranchManager;
        private readonly CompanyManager _CompanyManager;
        private readonly VehicleManager _VehicleManager;

        private async void ManageOutgoingStockItemForm_Load(object sender, EventArgs e)
        {
            IsCancelled = true;
            await LoadBranchesAsync();
            await LoadCompaniesAsync();
            await LoadVehiclesAsync();
            DisplayCurrentTransaction();
        }

        private void CancelDialogButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            IsCancelled = false;
            UpdateCurrentTransaction();
            Close();
        }

        private void DisplayCurrentTransaction()
        {
            ItemDescriptionTextBox.Text = CurrentTransaction.Item.Description;
            ItemCodeTextBox.Text = CurrentTransaction.Item.Code;
            ItemClassificationTextBox.Text = CurrentTransaction.Item.Classification.Description;
            ItemStockValueTextBox.Text = CurrentTransaction.Item.StockValue.ToString("#,##0.000");
            TransactionDateTimePicker.Value = CurrentTransaction.TransactionDate < TransactionDateTimePicker.MinDate ? DateTime.Now : CurrentTransaction.TransactionDate;
            RemovedStockValueNumericUpDown.Value = CurrentTransaction.RemovedStockValue;
            BranchComboBox.SelectedItem = CurrentTransaction.Branch;
            CompanyComboBox.SelectedItem = CurrentTransaction.Company;
            VehicleComboBox.SelectedItem = CurrentTransaction.Truck;
            RequestedByTextBox.Text = CurrentTransaction.RequestedBy;
            ReleasedByTextBox.Text = CurrentTransaction.ReleasedBy;
            PurposeTextBox.Text = CurrentTransaction.Purpose;
        }

        private void UpdateCurrentTransaction()
        {
            CurrentTransaction.TransactionDate = TransactionDateTimePicker.Value;
            CurrentTransaction.RemovedStockValue = RemovedStockValueNumericUpDown.Value;
            CurrentTransaction.Branch = BranchComboBox.SelectedItem as Branch;
            CurrentTransaction.Company = CompanyComboBox.SelectedItem as Company;
            CurrentTransaction.Truck = VehicleComboBox.SelectedItem as Vehicle;
            CurrentTransaction.RequestedBy = RequestedByTextBox.Text;
            CurrentTransaction.ReleasedBy = ReleasedByTextBox.Text;
            CurrentTransaction.Purpose = PurposeTextBox.Text;
        }

        private async Task LoadBranchesAsync()
        {
            BranchComboBox.Items.Clear();
            var branches = await _BranchManager.GetListAsync();

            if (branches != null && branches.Any())
            {
                BranchComboBox.Items.AddRange(branches);
            }
        }

        private async Task LoadCompaniesAsync()
        {
            CompanyComboBox.Items.Clear();
            var companies = await _CompanyManager.GetListAsync();

            if (companies != null && companies.Any())
            {
                CompanyComboBox.Items.AddRange(companies);
            }
        }

        private async Task LoadVehiclesAsync()
        {
            VehicleComboBox.Items.Clear();
            var vehicles = await _VehicleManager.GetListAsync();

            if (vehicles !=null && vehicles.Any())
            {
                VehicleComboBox.Items.AddRange(vehicles);
            }
        }
    }
}
