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
            if (ScheduledProjectDesignDataGrid.SelectedItems.Count > 0)
            {
                try
                {
                    bool isSuccess = true;
                    foreach (var item in ScheduledProjectDesignDataGrid.SelectedItems)
                    {
                        if (item is ScheduledProjectDesign selected && selected != null)
                        {
                            selected.Status = status;
                            var scheduledProjectDesign = await ScheduledProjectDesignManager.UpdateAsync(selected);

                            if (scheduledProjectDesign != null)
                            {
                            }
                            else
                            {
                                isSuccess = false;
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show(nothingToDo);
                        }
                    }

                    if (isSuccess)
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
            await UpdateAsync("No selected Scheduled delivery to reject.", "Failed to reject schedule.", "Schedules successfully rejected.", ScheduledProjectDesignStatus.Rejected);
        }

        private async void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            await UpdateAsync("No selected Scheduled delivery to approve.", "Failed to approve schedule.", "Schedules successfully approved.", ScheduledProjectDesignStatus.Approved);
        }

        private async void FinalApproveButton_Click(object sender, RoutedEventArgs e)
        {
            await UpdateAsync("No selected Scheduled delivery to be final approved.", "Failed to final approve schedule.", "Final approval has been set successfully.", ScheduledProjectDesignStatus.FinalApproved);
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ScheduledProjectDesignDataGrid.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Do you really want to delete the selected schedule(s)?", "Schedule Deletion Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        bool success = true;
                        foreach (var item in ScheduledProjectDesignDataGrid.SelectedItems)
                        {
                            if (item is ScheduledProjectDesign selected && selected != null)
                            {
                                selected = await ScheduledProjectDesignManager.DeleteAsync(selected);

                                if (selected != null)
                                {
                                    await GetScheduledDesignListAsync();
                                }
                                else
                                {
                                    success = false;
                                    break;
                                }
                            }
                        }

                        if (success)
                        {
                            MessageBox.Show("Successfully deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Some schedules are not deleted successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No schedules to be deleted.");
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

        private void SelectAllButton_Click(object sender, RoutedEventArgs e)
        {
            ScheduledProjectDesignDataGrid.SelectAll();
        }
    }
}
