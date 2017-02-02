using Citicon.Data;
using Citicon.DataManager;
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

namespace Citicon.DesktopClient.QuotationApproval.Views
{
    /// <summary>
    /// Interaction logic for ClientDisplayControl.xaml
    /// </summary>
    public partial class ClientDisplayControl : UserControl
    {
        public ClientDisplayControl()
        {
            InitializeComponent();
        }


        #region SelectedClient
        public Client SelectedClient
        {
            get { return (Client)GetValue(SelectedClientProperty); }
            private set
            {
                Dispatcher.Invoke(() =>
                {
                    tbxGeneral_CompanyName.Text = string.Empty;
                    tbxGeneral_Address.Text = string.Empty;
                    tbxGeneral_EmailAddress.Text = string.Empty;
                    tbxGeneral_ContactNumber.Text = string.Empty;

                    tbxExecutive_Name.Text = string.Empty;
                    tbxExecutive_Position.Text = string.Empty;
                    tbxExecutive_TelephoneNumber.Text = string.Empty;
                    tbxExecutive_MobileNumber.Text = string.Empty;

                    tbxRepresentative_Name.Text = string.Empty;
                    tbxRepresentative_Position.Text = string.Empty;

                    if (value != null)
                    {
                        tbxGeneral_CompanyName.Text = value.CompanyName;
                        tbxGeneral_Address.Text = value.Address;
                        tbxGeneral_EmailAddress.Text = value.EmailAddress;
                        tbxGeneral_ContactNumber.Text = value.ContactNumber;

                        tbxExecutive_Name.Text = value.PresidentName;
                        tbxExecutive_Position.Text = value.Designation;
                        tbxExecutive_TelephoneNumber.Text = value.PresidentTelephoneNumber;
                        tbxExecutive_MobileNumber.Text = value.PresidentMobileNumber;

                        tbxRepresentative_Name.Text = $"{value.Title} {value.FirstName} {value.LastName}";
                        tbxRepresentative_Position.Text = value.Position;
                    }

                    SetValue(SelectedClientProperty, value);
                });

            }
        }

        // Using a DependencyProperty as the backing store for SelectedClient.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedClientProperty =
            DependencyProperty.Register("SelectedClient", typeof(Client), typeof(ClientDisplayControl), new PropertyMetadata(null));
        #endregion

        public event ClientDisplayNextButtonClickEventHandler NextButtonClick;

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (dgvClientList.Items.Count == 0)
            {
                await LoadClientListAsync();
            }
        }

        private async Task LoadClientListAsync()
        {
            try
            {
                var list = await ClientManager.GetMetaDataListWithQuotationForApprovalAsync();

                Dispatcher.Invoke(() => dgvClientList.Items.Clear());

                if (list != null)
                {
                    foreach (Client client in list)
                    {
                        Dispatcher.Invoke(() => dgvClientList.Items.Add(client));
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        //private void DisplayClientList(Task<IEnumerable<Client>> task)
        //{
        //    if (task.Status == TaskStatus.RanToCompletion)
        //    {
        //        Dispatcher.Invoke(() =>
        //        {
        //            dgvClientList.Items.Clear();

        //            if (task.Result != null)
        //            {
        //                foreach (Client client in task.Result)
        //                {
        //                    dgvClientList.Items.Add(client);
        //                }
        //            }
        //        });
        //    }
        //}

        private void dgvClientList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedClient = (Client)dgvClientList.SelectedItem;
            GetById();
        }

        private void GetById()
        {
            var task = ClientManager.GetByIdAsync(SelectedClient.Id);
            task.ContinueWith(DisplayClientDetails);
        }

        private void DisplayClientDetails(Task<Client> task)
        {
            if (task.Status == TaskStatus.RanToCompletion)
            {
                SelectedClient = task.Result;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            NextButtonClick?.Invoke(this, new ClientDisplayNextButtonClickEventArgs(SelectedClient));
        }

        private async void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            await LoadClientListAsync();
        }
    }
}
