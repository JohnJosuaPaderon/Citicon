﻿using Citicon.Data;
using Citicon.DataManager;
using Citicon.DesktopClient.Common;
using Citicon.Forms;
using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;

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
            GlobalTitleChanged += MainWindow_GlobalTitleChanged;
        }

        private void MainWindow_GlobalTitleChanged(object sender, EventArgs e)
        {
            GeneralTitle.Text = GlobalTitle;
        }

        private static string _GlobalTitle;

        public static string GlobalTitle
        {
            get { return _GlobalTitle; }
            set
            {
                if (_GlobalTitle != value)
                {
                    _GlobalTitle = value;
                    GlobalTitleChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        private static event EventHandler GlobalTitleChanged;

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
                QuotationUser.CurrentQuotationUser = quotationUser;
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

        private async void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MenuToggleButton.IsChecked = false;

            switch (Menu.SelectedIndex)
            {
                case 0:
                    GeneralTitle.Text = "Quotation Approval";
                    Transitioner.SelectedItem = ClientDisplaySlide;
                    ClientDisplayControl.Focus();
                    break;
                case 1:
                    GeneralTitle.Text = "Quotation Approval";
                    Transitioner.SelectedItem = QuotationForFinalApprovalDisplaySlide;
                    QuotationForFinalApprovalDisplayControl.Focus();
                    break;
                case 2:
                    GeneralTitle.Text = "Quotation Approval";
                    Transitioner.SelectedItem = ProjectDesignForApprovalSlide;
                    ProjectDesignForApproval.Focus();
                    break;
                case 3:
                    GeneralTitle.Text = "Quotation Approval";
                    var form = new DeliverySchedulerForm();
                    WindowInteropHelper wih = new WindowInteropHelper(this);
                    form.Show();
                    break;
                case 4:
                    GeneralTitle.Text = "Scheduled Design Delivery";
                    Transitioner.SelectedItem = ScheduledDesignDeliveryManagementSlide;
                    ScheduledDesignDeliveryManagement.InitializeDisplay();
                    await ScheduledDesignDeliveryManagement.GetScheduledDesignListAsync();
                    break;
                //case 5:
                //    GeneralTitle.Text = "Cheque Cancellation";
                //    Transitioner.SelectedItem = ChequeCancellationSlide;

                //    break;
            }
        }

        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            User.CurrentUser = null;
            MenuToggleButton.IsChecked = false;
            MenuToggleButton.IsEnabled = false;
            Transitioner.SelectedItem = LoginSlide;
        }
    }
}
