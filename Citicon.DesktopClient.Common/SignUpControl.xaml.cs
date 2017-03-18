using Citicon.Data;
using Citicon.DataManager;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Citicon.DesktopClient.Common
{
    /// <summary>
    /// Interaction logic for SignUpControl.xaml
    /// </summary>
    public partial class SignUpControl : UserControl
    {
        public SignUpControl()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateInfo())
            {
                InsertUser();
            }
        }

        private bool ValidateInfo()
        {
            if (string.IsNullOrWhiteSpace(tbxDisplayName.Text))
            {
                MessageBox.Show("Display name should not be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbxUsername.Text))
            {
                MessageBox.Show("Username should not be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbxPassword.Password))
            {
                MessageBox.Show("Password should not be empty.");
                return false;
            }

            if (tbxPassword.Password != tbxConfirmPassword.Password)
            {
                MessageBox.Show("Password don't matched.");
                return false;
            }

            return true;
        }

        private void InsertUser()
        {
            User user = new User()
            {
                Username = tbxUsername.Text,
                Password = tbxPassword.Password,
                DisplayName = tbxDisplayName.Text
            };
            if (ckbxQuotationUser.IsChecked.Value)
            {
                var quotationUser = new QuotationUser(user)
                {
                    RedirectToFinalApproval = ckbxQuotation_RedirectToFinalApproval.IsChecked.Value
                };
                var insertQuotationUserTask = QuotationUserManager.InsertAsync(quotationUser);
                insertQuotationUserTask.ContinueWith(DisplayInsertQuotationUserResult);
            }
            else
            {
                var insertUserTask = UserManager.InsertAsync(user);
                insertUserTask.ContinueWith(DisplayInsertUserResult);
            }
        }

        private void DisplayInsertQuotationUserResult(Task<QuotationUser> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                MessageBox.Show("Quotation user has been saved!", "User Sign-up", MessageBoxButton.OK, MessageBoxImage.Information);
                Dispatcher.Invoke(ClearFields);
            }
            else
            {
                MessageBox.Show("An error occured on saving quotation user.", "User Sign-up", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DisplayInsertUserResult(Task<User> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                MessageBox.Show("User has been saved!", "User Sign-up", MessageBoxButton.OK, MessageBoxImage.Information);
                Dispatcher.Invoke(ClearFields);
            }
            else
            {
                MessageBox.Show("An error occured on saving user.", "User Sign-up", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearFields()
        {
            tbxDisplayName.Text = string.Empty;
            tbxUsername.Text = string.Empty;
            tbxPassword.Password = string.Empty;
            tbxConfirmPassword.Password = string.Empty;
            ckbxQuotationUser.IsChecked = false;
            ckbxQuotation_RedirectToFinalApproval.IsChecked = false;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }
    }
}
