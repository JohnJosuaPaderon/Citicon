using System.Windows.Forms;
using Citicon.Data;

namespace Citicon.Forms.Controls
{
    public partial class RoutePreview : UserControl
    {
        public RoutePreview()
        {
            InitializeComponent();
        }

        private DeliveryRoute _Route;

        public DeliveryRoute Route
        {
            get { return _Route; }
            set
            {
                if (_Route != value)
                {
                    _Route = value;
                    OnRouteChanged();
                }
            }
        }

        private void OnRouteChanged()
        {
            NameTextBox.Text = Route?.Name;
            FromTextBox.Text = Route?.StartPoint;
            ToTextBox.Text = Route?.EndPoint;
            RateTextBox.Text = Route?.Rate.ToString("#,##0.00");
        }
    }
}
