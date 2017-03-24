using Citicon.Data;
using System;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class AddEditClientDialog : Form
    {
        public AddEditClientDialog()
        {
            InitializeComponent();
            Mode = DataDialogMode.Add;
        }

        public AddEditClientDialog(Client client)
        {
            InitializeComponent();
            Client = client ?? throw new ArgumentNullException(nameof(client));
            Mode = DataDialogMode.Edit;
        }

        private Client _Client;

        public Client Client
        {
            get { return _Client; }
            private set
            {
                _Client = value;
                UpdateUI();
            }
        }

        public DataDialogMode Mode { get; }

        private void InitializeRequirement()
        {
            ExecutivePositionComboBox.Items.AddRange(new string[] { "PRESIDENT", "GENERAL MANAGER" });
        }

        private void UpdateUI()
        {
            UpdateModeOnUI();
            UpdateClientOnUI();
        }

        private void UpdateModeOnUI()
        {
            switch (Mode)
            {
                case DataDialogMode.None:
                    Text = "Undefined Operation";
                    break;
                case DataDialogMode.Add:
                    Text = "Add new Client";
                    break;
                case DataDialogMode.Edit:
                    Text = "Edit Client";
                    break;
            }
        }

        private void UpdateClientOnUI()
        {
            LegitimateCheckBox.Checked = Client?.Legitimate ?? false;
            CompanyNameTextBox.Text = Client?.CompanyName;
            AddressTextBox.Text = Client?.Address;
            TINTextBox.Text = Client?.Tin;
            ContactPersonFirstNameTextBox.Text = Client?.FirstName;
            ContactPersonLastNameTextBox.Text = Client?.LastName;
            ContactPersonTitleTextBox.Text = Client?.Title;
            ContactPersonPositionTextBox.Text = Client?.Position;
            ContactPersonEmailAddressTextBox.Text = Client?.EmailAddress;
            ContactPersonContactNumberTextBox.Text = Client?.ContactNumber;
            ExecutiveNameTextBox.Text = Client?.PresidentName;
            ExecutivePositionComboBox.SelectedItem = Client?.Designation;
            ExecutiveTelephoneNumberTextBox.Text = Client?.PresidentTelephoneNumber;
            ExecutiveMobileNumberTextBox.Text = Client?.PresidentMobileNumber;
        }

        private void AddEditClientDialog_Load(object sender, EventArgs e)
        {
            InitializeRequirement();
            UpdateUI();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, you want to cancel?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.CompanyName = CompanyNameTextBox.Text;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.Address = AddressTextBox.Text;
            }
        }

        private void TINTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.Tin = TINTextBox.Text;
            }
        }

        private void ContactPersonFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.FirstName = ContactPersonFirstNameTextBox.Text;
            }
        }

        private void ContactPersonLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.LastName = ContactPersonLastNameTextBox.Text;
            }
        }

        private void ContactPersonTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.Title = ContactPersonTitleTextBox.Text;
            }
        }

        private void ContactPersonPositionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.Position = ContactPersonPositionTextBox.Text;
            }
        }

        private void ContactPersonEmailAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.EmailAddress = ContactPersonEmailAddressTextBox.Text;
            }
        }

        private void ContactPersonContactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.ContactNumber = ContactPersonEmailAddressTextBox.Text;
            }
        }

        private void ExecutiveNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.PresidentName = ExecutiveNameTextBox.Text;
            }
        }

        private void ExecutivePositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.Designation = (string)ExecutivePositionComboBox.SelectedItem;
            }
        }

        private void ExecutiveTelephoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.PresidentTelephoneNumber = ExecutiveTelephoneNumberTextBox.Text;
            }
        }

        private void ExecutiveMobileNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Client != null)
            {
                Client.PresidentMobileNumber = ExecutiveMobileNumberTextBox.Text;
            }
        }
    }
}
