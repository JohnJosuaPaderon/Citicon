using System.Windows.Forms;
using Citicon.Data;
using System;

namespace Citicon.Forms.Controls
{
    public partial class ClientViewControl : UserControl
    {
        public ClientViewControl()
        {
            InitializeComponent();
        }

        private Client _Client;

        public Client Client
        {
            get { return _Client; }
            set
            {
                _Client = value;
                UpdateUI();
            }
        }

        private void UpdateUI()
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
            ExecutivePositionTextBox.Text = Client?.Designation;
            ExecutiveTelephoneNumberTextBox.Text = Client?.PresidentTelephoneNumber;
            ExecutiveMobileNumberTextBox.Text = Client?.PresidentMobileNumber;
        }

        private void LegitimateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Client != null && Client.Legitimate != LegitimateCheckBox.Checked)
            {
                LegitimateCheckBox.Checked = Client.Legitimate;
            }
        }
    }
}
