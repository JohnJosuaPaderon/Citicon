using Citicon.Data;
using System.Windows;

namespace Citicon.DesktopClient.QuotationApproval.Views
{
    public delegate void ClientDisplayNextButtonClickEventHandler(object sender, ClientDisplayNextButtonClickEventArgs e);

    public class ClientDisplayNextButtonClickEventArgs : RoutedEventArgs
    {
        public ClientDisplayNextButtonClickEventArgs(Client selectedClient)
        {
            SelectedClient = selectedClient;
        }

        public Client SelectedClient { get; }
    }
}
