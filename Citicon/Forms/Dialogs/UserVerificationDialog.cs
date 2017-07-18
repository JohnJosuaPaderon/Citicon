using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public enum UserVerificationMode
    {
        OtherUser,
        SameUser
    }

    public partial class UserVerificationDialog : Form
    {
        private readonly UserManager UserManager;

        public static (bool Verified, User Verifier) VerifyOther()
        {
            var dialog = new UserVerificationDialog(UserVerificationMode.OtherUser);
            dialog.ShowDialog();

            return (dialog.Verified, dialog.Verifier);
        }

        private UserVerificationDialog(UserVerificationMode mode)
        {
            UserManager = new UserManager();
            InitializeComponent();
            Mode = mode;
        }

        private UserVerificationMode _Mode;

        public UserVerificationMode Mode
        {
            get
            {
                return _Mode;
            }
            private set
            {
                _Mode = value;
                OnModeChanged();
            }
        }

        public bool Verified { get; private set; } = false;
        public User Verifier { get; private set; }

        private void OnModeChanged()
        {
            switch (Mode)
            {
                case UserVerificationMode.OtherUser:
                    MessageLabel.Text = "User should not be the current logged-in user.";
                    break;
                case UserVerificationMode.SameUser:
                    MessageLabel.Text = "User should be the current logged-in user.";
                    break;
            }
        }

        private void UserVerificationDialog_Load(object sender, EventArgs e)
        {
            Verified = false;
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            Verifier = UserManager.Login(UsernameTextBox.Text, PasswordTextBox.Text);
            
            if (Verifier != null)
            {
                var sameUser = Verifier.Id == User.CurrentUser.Id;
                switch (Mode)
                {
                    case UserVerificationMode.OtherUser:
                        if (sameUser)
                            MessageBox.Show(MessageLabel.Text);
                        else
                            Verified = true;
                        break;
                    case UserVerificationMode.SameUser:
                        if (!sameUser)
                            MessageBox.Show(MessageLabel.Text);
                        else
                            Verified = true;
                        break;
                }

                if (Verified)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void CancelVerifyButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
