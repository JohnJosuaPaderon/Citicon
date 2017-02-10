using Citicon.Data;
using Citicon.DataManager;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Citicon.DesktopClient.QuotationApproval.Views
{
    /// <summary>
    /// Interaction logic for QuotationForFinalApprovalDisplayControl.xaml
    /// </summary>
    public partial class QuotationForFinalApprovalDisplayControl : UserControl
    {
        public QuotationForFinalApprovalDisplayControl()
        {
            InitializeComponent();
        }

        #region SelectedQuotation
        public Quotation SelectedQuotation
        {
            get { return (Quotation)GetValue(SelectedQuotationProperty); }
            private set
            {
                Dispatcher.Invoke(() =>
                {
                    tbxQuotation_Date.Text = string.Empty;
                    tbxQuotation_Number.Text = string.Empty;
                    tbxQuotation_Client.Text = string.Empty;
                    tbxQuotation_ClientAddress.Text = string.Empty;
                    tbxQuotation_Project.Text = string.Empty;
                    tbxQuotation_ProjectLocation.Text = string.Empty;

                    if (value != null)
                    {
                        tbxQuotation_Number.Text = value.ToString();
                        tbxQuotation_Date.Text = value.QuotationDate.ToString("MMMM dd, yyyy");
                        tbxQuotation_Client.Text = value.Project.Client.ToString();
                        tbxQuotation_ClientAddress.Text = value.Project.Client.Address;
                        tbxQuotation_Project.Text = value.Project.ToString();
                        tbxQuotation_ProjectLocation.Text = value.Project.Location;
                        rtbxNoteDetails.Selection.Text = string.Empty;

                        if (!string.IsNullOrWhiteSpace(value.NoteDetails))
                        {
                            try
                            {
                                using (var memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(value.NoteDetails)))
                                {
                                    rtbxNoteDetails.Selection.Load(memoryStream, DataFormats.Rtf);
                                }
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                        }

                    }

                    SetValue(SelectedQuotationProperty, value);
                });
            }
        }

        // Using a DependencyProperty as the backing store for SelectedQuotation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedQuotationProperty =
            DependencyProperty.Register("SelectedQuotation", typeof(Quotation), typeof(QuotationForFinalApprovalDisplayControl), new PropertyMetadata(null));
        #endregion

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (dgvQuotationList.Items.Count == 0)
            {
                await LoadForFinalApprovalQuotationListAsync(); 
            }
        }

        private async Task LoadForFinalApprovalQuotationListAsync()
        {
            try
            {
                var quotations = await QuotationManager.GetListForFinalApprovalAsync();

                Dispatcher.Invoke(() => dgvQuotationList.Items.Clear());

                if (quotations != null)
                {
                    Parallel.Invoke(() =>
                    {
                        foreach (Quotation quotation in quotations)
                        {
                            Dispatcher.Invoke(() => dgvQuotationList.Items.Add(quotation));
                        }
                    });
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnFinalApproved_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedQuotation == null)
            {
                MessageBox.Show("No selected quotation.", "Quotation for Final Approval", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var task = QuotationManager.UpdateStatusAsync(SelectedQuotation, QuotationStatus.FinalApproved);
            task.ContinueWith(DislayQuotationResult);
        }

        private void btnForRevision_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedQuotation == null)
            {
                MessageBox.Show("No selected quotation.", "Quotation for Final Approval", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var task = QuotationManager.UpdateStatusAsync(SelectedQuotation, QuotationStatus.ForRevision);
            task.ContinueWith(DislayQuotationResult);
        }

        private void dgvQuotationList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedQuotation = (Quotation)dgvQuotationList.SelectedItem;
        }

        private void DislayQuotationResult(Task<Quotation> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                Dispatcher.Invoke(() => dgvQuotationList.Items.Remove(task.Result));
                MessageBox.Show("Success!", $"Quotation for Final Approval - {QuotationStatusManager.ToDisplay(task.Result.Status)}", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("An error occured.", "Quotation for Final Approval", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            await LoadForFinalApprovalQuotationListAsync();
        }

        private void btnViewNoteDetailsInWord_Click(object sender, RoutedEventArgs e)
        {
            if (!Supports.OpenFileQuotationFile(SelectedQuotation?.ToString()))
            {
                MessageBox.Show("Unable to view quotation");
            }

            //if (!string.IsNullOrWhiteSpace(SelectedQuotation?.NoteDetails))
            //{
            //    Supports.OpenRtf(SelectedQuotation.NoteDetails);
            //}
            //else
            //{

            //    MessageBox.Show("Unable to view in word.");
            //}
        }
    }
}
