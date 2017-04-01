using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Citicon.DesktopClient.QuotationApproval.Views
{
    /// <summary>
    /// Interaction logic for QuotationDisplayControl.xaml
    /// </summary>
    public partial class QuotationDisplayControl : UserControl
    {
        public QuotationDisplayControl()
        {
            InitializeComponent();
        }

        #region SelectedProject
        public Project SelectedProject
        {
            get { return (Project)GetValue(SelectedProjectProperty); }
            set
            {
                Dispatcher.Invoke(() =>
                {
                    tbxProject_Name.Text = string.Empty;
                    tbxProject_Location.Text = string.Empty;
                    dgvQuotationList.Items.Clear();

                    if (value != null)
                    {
                        tbxProject_Name.Text = value.Name;
                        tbxProject_Location.Text = value.Location;
                    }

                    SetValue(SelectedProjectProperty, value);
                });

                if (value != null)
                {
                    Task.WaitAll(LoadQuotationListAsync());
                }
            }
        }

        // Using a DependencyProperty as the backing store for SelectedProject.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedProjectProperty =
            DependencyProperty.Register("SelectedProject", typeof(Project), typeof(QuotationDisplayControl), new PropertyMetadata(null));
        #endregion

        #region SelectedQuotation
        public Quotation SelectedQuotation
        {
            get { return (Quotation)GetValue(SelectedQuotationProperty); }
            set
            {
                Dispatcher.Invoke(() =>
                {
                    tbxQuotation_QuotationNumber.Text = string.Empty;
                    tbxQuotation_QuotationDate.Text = string.Empty;
                    rtbxNoteDetails.Selection.Text = string.Empty;

                    if (value != null)
                    {
                        tbxQuotation_QuotationNumber.Text = value.ToString();
                        tbxQuotation_QuotationDate.Text = value.QuotationDate.ToString("MMMM dd, yyyy");
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
            DependencyProperty.Register("SelectedQuotation", typeof(Quotation), typeof(QuotationDisplayControl), new PropertyMetadata(null));
        #endregion

        public event RoutedEventHandler PreviousButtonClick;

        private async Task LoadQuotationListAsync()
        {
            //var task = QuotationManager.GetForApprovalMetaDataListByProjectAsync(SelectedProject);
            //task.ContinueWith(DisplayQuotationList);
            try
            {
                var quotations = await QuotationManager.GetForApprovalMetaDataListByProjectAsync(SelectedProject);

                Dispatcher.Invoke(() => dgvQuotationList.Items.Clear());

                if (quotations != null)
                {
                    foreach (Quotation quotation in quotations)
                    {
                        Dispatcher.Invoke(() => dgvQuotationList.Items.Add(quotation));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void DisplayQuotationList(Task<IEnumerable<Quotation>> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                if (task.Result != null)
                {
                    foreach (Quotation quotation in task.Result)
                    {
                        Dispatcher.Invoke(() => dgvQuotationList.Items.Add(quotation));
                    }
                }
            }
        }

        private void DgvQuotationList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedQuotation = (Quotation)dgvQuotationList.SelectedItem;
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            PreviousButtonClick?.Invoke(this, new RoutedEventArgs());
        }

        private void BtnApproved_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedQuotation == null)
            {
                MessageBox.Show("Selected Quotation!", "Quotation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var task = QuotationManager.UpdateStatusAsync(SelectedQuotation, QuotationStatus.Approved);
            task.ContinueWith(DisplayQuotationResult);
        }

        private void DisplayQuotationResult(Task<Quotation> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                Dispatcher.Invoke(() => dgvQuotationList.Items.Remove(task.Result));
                MessageBox.Show("Success!", $"Quotation for Final Approval - {QuotationStatusManager.ToDisplay(task.Result.Status)}", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("An error occured.");
            }
        }

        private void BtnForRevision_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedQuotation == null)
            {
                MessageBox.Show("Selected Quotation!", "Quotation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var task = QuotationManager.UpdateStatusAsync(SelectedQuotation, QuotationStatus.ForRevision);
            task.ContinueWith(DisplayQuotationResult);
        }

        private void BtnFinalApproved_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedQuotation == null)
            {
                MessageBox.Show("Selected Quotation!", "Quotation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var task = QuotationManager.UpdateStatusAsync(SelectedQuotation, QuotationStatus.FinalApproved);
            task.ContinueWith(DisplayQuotationResult);
        }

        private async void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            await LoadQuotationListAsync();
        }

        private void BtnViewNoteDetailsInWord_Click(object sender, RoutedEventArgs e)
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
