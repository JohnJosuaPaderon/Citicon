using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Windows.Forms;

namespace Citicon.Inventory
{
    public partial class LoginForm : Form
    {
        UserManager userManager;
        public LoginForm()
        {
            InitializeComponent();
            userManager = new UserManager();
            userManager.ExceptionCatched += ExceptionCatched;
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            userManager.Login(tbxUsername.Text, tbxPassword.Text);
            if (User.CurrentUser != null)
            {
                if (User.CurrentUser.Active)
                {
                    if (User.CurrentUser.Module == Module.CurrentModule || User.CurrentUser.Module == Supports.AdministrativeModule)
                    {
                        Hide();
                        (new MainForm()).ShowDialog();
                        tbxUsername.Text = string.Empty;
                        tbxPassword.Text = string.Empty;
                        Show();
                    }
                    else DisplayError("ACCESS DENIED!");
                }
                else DisplayError("INACTIVE USER!");
            }
            else DisplayError("USER NOT FOUND!");
        }
        private void DisplayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TextBox_Login(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Login();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
