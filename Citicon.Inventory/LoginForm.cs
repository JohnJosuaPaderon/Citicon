using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
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
                    else displayError("ACCESS DENIED!");
                }
                else displayError("INACTIVE USER!");
            }
            else displayError("USER NOT FOUND!");
        }
        private void displayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TextBox_Login(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) login();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
