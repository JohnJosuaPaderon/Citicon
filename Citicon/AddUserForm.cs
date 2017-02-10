using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Windows.Forms;

namespace Citicon
{
    public partial class AddUserForm : Form
    {
        User[] users;
        UserManager userManager;
        public AddUserForm()
        {
            InitializeComponent();
            userManager = new UserManager();
            userManager.ExceptionCatched += ExceptionCatched;
            userManager.Added += UserManager_Added;
            userManager.NewItemGenerated += UserManager_NewItemGenerated;
            userManager.AddedUnsuccessful += UserManager_AddedUnsuccessful;
        }

        private void UserManager_NewItemGenerated(User e)
        {
            if (e.Module == Module.CurrentModule) Invoke(new Action(() => dgvUsers.Rows.Add(e)));
        }

        private void UserManager_AddedUnsuccessful(User e)
        {
            displayError("Failed to add user");
        }

        private void UserManager_Added(User e)
        {
            notify("User added successfully!");
            tbxConfirmPassword.Text = string.Empty;
            tbxDisplayName.Text = string.Empty;
            tbxPassword.Text = string.Empty;
            tbxUsername.Text = string.Empty;
            dgvUsers.Rows.Add(e);
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private async void AddUserForm_Load(object sender, EventArgs e)
        {
            users = await userManager.GetListAsync();
        }

        private void displayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void notify(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text.Trim() == string.Empty) { displayError("Username must be valid!"); return; }
            if (tbxPassword.Text.Trim() == string.Empty) { displayError("Password must be valid!"); return; }
            if (tbxConfirmPassword.Text.Trim() != tbxPassword.Text.Trim()) { displayError("Passwords don't match!"); return; }
            if (tbxDisplayName.Text.Trim() == string.Empty) { displayError("Display Name must be valid!"); return; }
            userManager.Add(new User
            {
                Active = true,
                Admin = ckbxAdmin.Checked,
                DisplayName = tbxDisplayName.Text.Trim(),
                Module = Module.CurrentModule,
                Password = tbxPassword.Text.Trim(),
                Username = tbxUsername.Text.Trim(),
                Inventory_OutgoingStocksOnly = ckbxInventory_OutgoingStocks.Checked
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
