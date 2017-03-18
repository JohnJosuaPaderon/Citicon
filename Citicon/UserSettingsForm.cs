using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Citicon
{
    public partial class UserSettingsForm : Form
    {
        private UserManager userManager;
        private Color errorBack;
        private Color errorFore;
        private Color changesBack;
        private Color changesFore;
        private Color normalBack;
        private Color normalFore;
        public UserSettingsForm()
        {
            InitializeComponent();
            userManager = new UserManager();
            userManager.ExceptionCatched += ExceptionCatched;
            userManager.Updated += UserManager_Updated;
            userManager.UpdatedUnsuccessful += UserManager_UpdatedUnsuccessful;
        }

        private void UserManager_UpdatedUnsuccessful(User e)
        {
            MessageBox.Show("Unable to save changes!");
        }

        private void UserManager_Updated(User e)
        {
            MessageBox.Show("Successfully changed information!");
            ckbxEditDisplayName.Checked = false;
            ckbxEditUsername.Checked = false;
            ckbxChangePassword.Checked = false;
            ResetFields();
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {
            btnAddNewUser.Visible = User.CurrentUser.Admin;
            normalBack = Color.White;
            normalFore = Color.Black;
            changesBack = Color.LightGray;
            changesFore = Color.Black;
            errorBack = Color.Firebrick;
            errorFore = Color.White;
            ResetFields();
        }

        private void ResetFields()
        {
            if (!ckbxEditDisplayName.Checked) tbxUsername.Text = User.CurrentUser?.Username;
            if (!ckbxEditUsername.Checked) tbxDisplayName.Text = User.CurrentUser?.DisplayName;
            if (!ckbxChangePassword.Checked)
            {
                tbxPassword.Text = User.CurrentUser?.Password;
                tbxCurrentPassword.Text = string.Empty;
                tbxCurrentPassword.BackColor = normalBack;
                tbxCurrentPassword.ForeColor = normalFore;
                tbxNewPassword.Text = string.Empty;
                tbxNewPassword.BackColor = normalBack;
                tbxNewPassword.ForeColor = normalFore;
                tbxReTypePassword.Text = string.Empty;
                tbxReTypePassword.BackColor = normalBack;
                tbxReTypePassword.ForeColor = normalFore;
            }
        }

        private void CkbxEditDisplayName_CheckedChanged(object sender, EventArgs e)
        {
            tbxDisplayName.Enabled = ckbxEditDisplayName.Checked;
            ResetFields();
        }

        private void CkbxEditUsername_CheckedChanged(object sender, EventArgs e)
        {
            tbxUsername.Enabled = ckbxEditUsername.Checked;
            ResetFields();
        }

        private void CkbxChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ckbxChangePassword.Checked;
            lblCurrentPassword.Enabled = check;
            lblNewPassword.Enabled = check;
            lblReTypePassword.Enabled = check;
            tbxCurrentPassword.Enabled = check;
            tbxNewPassword.Enabled = check;
            tbxReTypePassword.Enabled = check;
            ResetFields();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbxDisplayName_TextChanged(object sender, EventArgs e)
        {
            if (tbxDisplayName.Text.Trim() == string.Empty)
            {
                tbxDisplayName.BackColor = errorBack;
                tbxDisplayName.ForeColor = errorFore;
            }
            else if (tbxDisplayName.Text.Trim() != User.CurrentUser?.DisplayName)
            {
                tbxDisplayName.BackColor = changesBack;
                tbxDisplayName.ForeColor = changesFore;
            }
            else
            {
                tbxDisplayName.BackColor = normalBack;
                tbxDisplayName.ForeColor = normalFore;
            }
        }

        private void TbxUsername_TextChanged(object sender, EventArgs e)
        {
            if (tbxUsername.Text.Trim() == string.Empty)
            {
                tbxUsername.BackColor = errorBack;
                tbxUsername.ForeColor = errorFore;
            }
            else if (tbxUsername.Text.Trim() != User.CurrentUser?.Username)
            {
                tbxUsername.BackColor = changesBack;
                tbxUsername.ForeColor = changesFore;
            }
            else
            {
                tbxUsername.BackColor = normalBack;
                tbxUsername.ForeColor = normalFore;
            }
        }

        private void TbxCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbxCurrentPassword.Text.Trim() != User.CurrentUser?.Password)
            {
                tbxCurrentPassword.BackColor = errorBack;
                tbxCurrentPassword.ForeColor = errorFore;
            }
            else
            {
                tbxCurrentPassword.BackColor = normalBack;
                tbxCurrentPassword.ForeColor = normalFore;
            }
        }

        private void TbxNewPassword_TextChanged(object sender, EventArgs e)
        {
            var newPassword = tbxNewPassword.Text.Trim();
            if (newPassword == string.Empty || newPassword == User.CurrentUser?.Password)
            {
                tbxNewPassword.BackColor = errorBack;
                tbxNewPassword.ForeColor = errorFore;
            }
            else
            {
                tbxNewPassword.BackColor = changesBack;
                tbxNewPassword.ForeColor = changesFore;
            }
        }

        private void TbxReTypePassword_TextChanged(object sender, EventArgs e)
        {
            var reTypePassword = tbxReTypePassword.Text.Trim();
            var newPassword = tbxNewPassword.Text.Trim();
            if (reTypePassword != newPassword)
            {
                tbxReTypePassword.BackColor = errorBack;
                tbxReTypePassword.ForeColor = errorFore;
            }
            else
            {
                tbxReTypePassword.BackColor = changesBack;
                tbxReTypePassword.ForeColor = changesFore;
            }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            var activeDisplayName = User.CurrentUser?.DisplayName;
            var activeUsername = User.CurrentUser?.Username;
            var activePassword = User.CurrentUser?.Password;
            var newDisplayName = tbxDisplayName.Text.Trim();
            var newUsername = tbxUsername.Text.Trim();
            var currentPassword = tbxCurrentPassword.Text.Trim();
            var newPassword = tbxNewPassword.Text.Trim();
            var reTypePassword = tbxReTypePassword.Text.Trim();
            var displayNameChanges = false;
            var usernameChanges = false;
            var confirmedCurrentPassword = false;
            var cofirmedNewPassword = false;
            if (ckbxEditDisplayName.Checked)
            {
                if (activeDisplayName != newDisplayName) displayNameChanges = true;
                else MessageBox.Show("Display Name has no changes!");
            }
            if (ckbxEditUsername.Checked)
            {
                if (activeUsername != newUsername) usernameChanges = true;
                else MessageBox.Show("Username has no changes!");
            }
            if (ckbxChangePassword.Checked)
            {
                if (activePassword == currentPassword)
                {
                    confirmedCurrentPassword = true;
                    if (newPassword == reTypePassword) cofirmedNewPassword = true;
                    else MessageBox.Show("New password doesn't match to confirmation password!");
                }
                else MessageBox.Show("Current Password does not matched!");
            }
            if (displayNameChanges || usernameChanges || (confirmedCurrentPassword && cofirmedNewPassword))
            {
                if (displayNameChanges) User.CurrentUser.DisplayName = newDisplayName;
                if (usernameChanges) User.CurrentUser.Username = newUsername;
                if (confirmedCurrentPassword && cofirmedNewPassword) User.CurrentUser.Password = newPassword;
                userManager.Update(User.CurrentUser);
            }
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();
            form.ShowDialog();
        }
    }
}