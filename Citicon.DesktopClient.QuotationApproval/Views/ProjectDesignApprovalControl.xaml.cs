using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Citicon.Data;

namespace Citicon.DesktopClient.QuotationApproval.Views
{
    /// <summary>
    /// Interaction logic for ProjectDesignApprovalControl.xaml
    /// </summary>
    public partial class ProjectDesignApprovalControl : UserControl
    {
        public ProjectDesignApprovalControl()
        {
            InitializeComponent();
        }

        #region SelectedProjectDesign
        public ProjectDesign SelectedProjectDesign
        {
            get { return (ProjectDesign)GetValue(SelectedProjectDesignProperty); }
            set
            {
                Dispatcher.Invoke(() =>
                {
                    tbxAggregate.Text = string.Empty;
                    tbxCementFactor.Text = string.Empty;
                    tbxClient.Text = string.Empty;
                    tbxMixType.Text = string.Empty;
                    tbxPricePerCubicMeter.Text = string.Empty;
                    tbxProject.Text = string.Empty;
                    tbxPsi.Text = string.Empty;
                    tbxStrength.Text = string.Empty;
                });
                Dispatcher.Invoke(() =>
                {
                    if (value != null)
                    {
                        tbxAggregate.Text = value.Aggregate.ToString();
                        tbxCementFactor.Text = value.CementFactor.ToString("#,##0.0##");
                        tbxClient.Text = value.Project.Client.ToString();
                        tbxMixType.Text = value.MixType.ToString();
                        tbxPricePerCubicMeter.Text = value.PricePerCubicMeter.ToString("#,##0.00");
                        tbxProject.Text = value.Project.ToString();
                        tbxPsi.Text = value.Psi.ToString("###0");
                        tbxStrength.Text = value.Strength.ToString();
                    }

                    SetValue(SelectedProjectDesignProperty, value);
                });
            }
        }

        // Using a DependencyProperty as the backing store for SelectedProjectDesign.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedProjectDesignProperty =
            DependencyProperty.Register("SelectedProjectDesign", typeof(ProjectDesign), typeof(ProjectDesignApprovalControl), new PropertyMetadata(null));
        #endregion

        private async void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            await LoadProjectDesignsAsync();
        }

        private async Task LoadProjectDesignsAsync()
        {
            //var task = ProjectDesignManager.GetListForApprovalAsync();
            //task.ContinueWith(DisplayProjectDesigns);
            try
            {
                var projectDesigns = await ProjectDesignManager.GetListForApprovalAsync();

                Dispatcher.Invoke(() => dgvProjectDesigns.Items.Clear());

                if (projectDesigns != null)
                {
                    foreach (ProjectDesign projectDesign in projectDesigns)
                    {
                        Dispatcher.Invoke(() => dgvProjectDesigns.Items.Add(projectDesign));
                    }
                }

            }
            catch (Exception)
            {
                
            }
        }

        private void DisplayProjectDesigns(Task<IEnumerable<ProjectDesign>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                Dispatcher.Invoke(() => dgvProjectDesigns.Items.Clear());

                if (task.Result != null)
                {
                    foreach (ProjectDesign projectDesign in task.Result)
                    {
                        Dispatcher.Invoke(() => dgvProjectDesigns.Items.Add(projectDesign));
                    }
                }
            }
            else
            {

            }
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (dgvProjectDesigns.Items.Count == 0)
            {
                await LoadProjectDesignsAsync(); 
            }
        }

        private void DgvProjectDesigns_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedProjectDesign = (ProjectDesign)dgvProjectDesigns.SelectedItem;
        }

        private void BtnApprove_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedProjectDesign != null)
            {
                ApproveProjectDesign();
            }
            else
            {
                MessageBox.Show("No Selected Project Design to approve.", "Project Design Approval", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ApproveProjectDesign()
        {
            var task = ProjectDesignManager.ApproveAsync(SelectedProjectDesign);
            task.ContinueWith(DisplayApproveProjectDesignResult);
        }

        private void DisplayApproveProjectDesignResult(Task<ProjectDesign> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    MessageBox.Show("Successfully approved!", "Project Design Approval", MessageBoxButton.OK, MessageBoxImage.Information);
                    Dispatcher.Invoke(() => dgvProjectDesigns.Items.Remove(task.Result));
                }
                else
                {
                    MessageBox.Show("Approval not saved!", "Project Design Approval", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("An error occured during approving project design.", "Project Design Approval", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TbxPricePerCubicMeter_LostFocus(object sender, RoutedEventArgs e)
        {
            LostPricePerCubicMeter();
        }

        private void LostPricePerCubicMeter()
        {
            if (SelectedProjectDesign != null)
            {
                SelectedProjectDesign.PricePerCubicMeter = Parse(tbxPricePerCubicMeter.Text.Trim());
                tbxPricePerCubicMeter.Text = SelectedProjectDesign.PricePerCubicMeter.ToString("#,##0.00");
            }
        }

        public decimal Parse(string value)
        {
            value = value.Replace(",", "");
            value.Replace(" ", "");
            decimal.TryParse(value, out decimal amount);
            return amount;
        }

        private void TbxPricePerCubicMeter_GotTouchCapture(object sender, TouchEventArgs e)
        {
            Supports.OpenTouchKeyboard();
        }

        private void TbxPricePerCubicMeter_LostTouchCapture(object sender, TouchEventArgs e)
        {
            LostPricePerCubicMeter();
        }
    }
}
