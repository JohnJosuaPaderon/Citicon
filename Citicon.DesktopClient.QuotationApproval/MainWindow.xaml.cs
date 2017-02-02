using Citicon.Data;
using Citicon.DataManager;
using Citicon.DesktopClient.Common;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Citicon.DesktopClient.QuotationApproval
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClientDisplayControl_NextButtonClick(object sender, Views.ClientDisplayNextButtonClickEventArgs e)
        {
            if (e.SelectedClient == null)
            {
                MessageBox.Show("No Selected Client", "Client", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Transitioner.SelectedItem = null;
            Transitioner.SelectedItem = ProjectDisplaySlide;
            ProjectDisplayControl.SelectedClient = e.SelectedClient;
        }

        private void ProjectDisplayControl_PreviousButtonClick(object sender, RoutedEventArgs e)
        {
            Transitioner.SelectedItem = null;
            Transitioner.SelectedItem = ClientDisplaySlide;
        }

        private void ProjectDisplayControl_NextButtonClick(object sender, Views.ProjectDisplayNextButtonClickEventArgs e)
        {
            if (e.SelectedProject == null)
            {
                MessageBox.Show("No Selected Project", "Project", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Transitioner.SelectedItem = null;
            Transitioner.SelectedItem = QuotationDisplaySlide;
            QuotationDisplayControl.SelectedProject = e.SelectedProject;
        }

        private void QuotationDisplayControl_PreviousButtonClick(object sender, RoutedEventArgs e)
        {
            Transitioner.SelectedItem = null;
            Transitioner.SelectedItem = ProjectDisplaySlide;
        }

        private void LoginControl_LoggedIn(object sender, LoggedInEventArgs e)
        {
            if (e.User.Module == Module.CurrentModule)
            {
                var quotationUser = QuotationUserManager.GetByIdAsync(e.User.Id).Result;

                Menu.SelectedIndex = -1;

                if (quotationUser.RedirectToFinalApproval)
                {
                    Menu.SelectedIndex = 1;
                }
                else
                {
                    Menu.SelectedIndex = 0;
                }

                MenuToggleButton.IsEnabled = true;
                CurrentUser_DisplayName.Text = quotationUser.DisplayName;
            }
            else
            {
                MessageBox.Show("This user is not allowed to use this system application.");
            }
        }

        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MenuToggleButton.IsChecked = false;

            switch (Menu.SelectedIndex)
            {
                case 0:
                    Transitioner.SelectedItem = ClientDisplaySlide;
                    ClientDisplayControl.Focus();
                    break;
                case 1:
                    Transitioner.SelectedItem = QuotationForFinalApprovalDisplaySlide;
                    QuotationForFinalApprovalDisplayControl.Focus();
                    break;
                case 2:
                    Transitioner.SelectedItem = ProjectDesignForApprovalSlide;
                    ProjectDesignForApproval.Focus();
                    break;
            }
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            User.CurrentUser = null;
            MenuToggleButton.IsChecked = false;
            MenuToggleButton.IsEnabled = false;
            Transitioner.SelectedItem = LoginSlide;
        }
    }
}
