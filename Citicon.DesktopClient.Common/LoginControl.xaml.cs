using Citicon.Data;
using Citicon.DataManager;
using System.Windows;
using System.Windows.Controls;

namespace Citicon.DesktopClient.Common
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
            UserManager = new UserManager();
        }

        private UserManager UserManager;

        public event LoggedInEventHandler LoggedIn;

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            UserManager.LoginCurrent(tbxUsername.Text, tbxPassword.Password);

            if (User.CurrentUser == null)
            {
                MessageBox.Show("Failed to log-in.");
            }
            else
            {
                tbxUsername.Text = string.Empty;
                tbxPassword.Password = string.Empty;
                OnLoggedIn(User.CurrentUser);
            }
        }

        protected virtual void OnLoggedIn(User user)
        {
            LoggedIn?.Invoke(this, new LoggedInEventArgs(user));
        }

        private void tbxUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            Supports.OpenTouchKeyboard();
        }

        private void tbxUsername_GotTouchCapture(object sender, System.Windows.Input.TouchEventArgs e)
        {
            Supports.OpenTouchKeyboard();
        }

        private void tbxPassword_GotTouchCapture(object sender, System.Windows.Input.TouchEventArgs e)
        {
            Supports.OpenTouchKeyboard();
        }
    }
}
