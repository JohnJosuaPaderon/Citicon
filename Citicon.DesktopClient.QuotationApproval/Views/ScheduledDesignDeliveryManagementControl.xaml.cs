using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Citicon.DesktopClient.QuotationApproval.Views
{
    /// <summary>
    /// Interaction logic for ScheduledDesignDeliveryManagementControl.xaml
    /// </summary>
    public partial class ScheduledDesignDeliveryManagementControl : UserControl
    {
        public ScheduledDesignDeliveryManagementControl()
        {
            InitializeComponent();
            StatusComboBox.Items.Add(ScheduledProjectDesignStatus.Pending);
            StatusComboBox.Items.Add(ScheduledProjectDesignStatus.Approved);
            StatusComboBox.Items.Add(ScheduledProjectDesignStatus.FinalApproved);
            StatusComboBox.Items.Add(ScheduledProjectDesignStatus.Rejected);

            StatusComboBox.SelectedItem = ScheduledProjectDesignStatus.Pending;
        }

        private ScheduledProjectDesignManager ScheduledProjectDesignManager = new ScheduledProjectDesignManager();

        private void ScheduledProjectDesignDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public async Task GetScheduledDesignListAsync()
        {
            ScheduledProjectDesignDataGrid.Items.Clear();

            if (StatusComboBox.SelectedItem is ScheduledProjectDesignStatus status && status != null)
            {
                try
                {
                    var list = await ScheduledProjectDesignManager.GetListByStatusAsync(status);

                    if (list != null && list.Any())
                    {
                        foreach (var item in list)
                        {
                            ScheduledProjectDesignDataGrid.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task UpdateAsync(string nothingToDo, string failed, string success, ScheduledProjectDesignStatus status)
        {
            if (ScheduledProjectDesignDataGrid.SelectedItem is ScheduledProjectDesign selected && selected != null)
            {
                try
                {
                    selected.Status = status;
                    var scheduledProjectDesign = await ScheduledProjectDesignManager.UpdateAsync(selected);

                    if (scheduledProjectDesign != null)
                    {
                        await GetScheduledDesignListAsync();
                        MessageBox.Show(success);
                    }
                    else
                    {
                        MessageBox.Show(failed);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(nothingToDo);
            }
        }

        private async void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            await UpdateAsync("No selected Scheduled delivery to reject.", "Failed to reject schedule.", "Schedule successfully rejected.", ScheduledProjectDesignStatus.Rejected);
        }

        private async void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            await UpdateAsync("No selected Scheduled delivery to approve.", "Failed to approve schedule.", "Schedule successfully approved.", ScheduledProjectDesignStatus.Approved);
        }

        private async void FinalApproveButton_Click(object sender, RoutedEventArgs e)
        {
            await UpdateAsync("No selected Scheduled delivery to be final approved.", "Failed to final approve schedule.", "Final approval has been set successfully.", ScheduledProjectDesignStatus.FinalApproved);
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ScheduledProjectDesignDataGrid.SelectedItem is ScheduledProjectDesign selected && selected != null)
            {
                var result = MessageBox.Show("Do you really want to delete the selected schedule?", "Schedule Deletion Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        selected = await ScheduledProjectDesignManager.DeleteAsync(selected);

                        if (selected != null)
                        {
                            await GetScheduledDesignListAsync();
                            MessageBox.Show("Successfully deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private async void StatusComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await GetScheduledDesignListAsync();
        }

        public void InitializeDisplay()
        {
            ApproveButton.Visibility = QuotationUser.CurrentQuotationUser?.RedirectToFinalApproval ?? false ? Visibility.Collapsed : Visibility.Visible;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
