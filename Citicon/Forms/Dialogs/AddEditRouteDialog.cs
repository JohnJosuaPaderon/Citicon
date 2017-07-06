using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class AddEditRouteDialog : Form
    {
        public static void AddRoute()
        {
            var dialog = new AddEditRouteDialog(new DeliveryRoute(), DataDialogMode.Add);
            dialog.ShowDialog();
            dialog = null;
        }

        public static void EditRoute(DeliveryRoute route)
        {
            var dialog = new AddEditRouteDialog(route, DataDialogMode.Edit);
            dialog.ShowDialog();
            dialog = null;
        }

        private AddEditRouteDialog(DeliveryRoute route, DataDialogMode mode)
        {
            InitializeComponent();
            Route = route ?? throw new ArgumentNullException(nameof(route));
            Mode = mode;
            RouteManager = new DeliveryRouteManager();
        }

        private readonly DeliveryRouteManager RouteManager;

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

        private DataDialogMode _Mode;

        public DataDialogMode Mode
        {
            get { return _Mode; }
            set
            {
                if (_Mode != value)
                {
                    _Mode = value;
                    OnModeChanged();
                }
            }
        }

        private void OnModeChanged()
        {
            switch (Mode)
            {
                case DataDialogMode.None:
                    Text = "Nothing to do";
                    break;
                case DataDialogMode.Add:
                    Text = "Add new Route";
                    break;
                case DataDialogMode.Edit:
                    Text = "Edit Route";
                    break;
            }
        }

        private void OnRouteChanged()
        {
            NameTextBox.Text = Route.Name;
            FromTextBox.Text = Route.StartPoint;
            ToTextBox.Text = Route.EndPoint;
            RateNumericUpDown.Value = Route.Rate;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case DataDialogMode.None:
                    MessageBox.Show("Nothing to be done.");
                    break;
                case DataDialogMode.Add:
                    await InsertAsync();
                    break;
                case DataDialogMode.Edit:
                    await UpdateAsync();
                    break;
            }
        }

        private void PrepareData()
        {
            Route.Name = NameTextBox.Text;
            Route.StartPoint = FromTextBox.Text;
            Route.EndPoint = ToTextBox.Text;
            Route.Rate = RateNumericUpDown.Value;
        }

        private async Task InsertAsync()
        {
            PrepareData();

            try
            {
                var route = await RouteManager.InsertAsync(Route);

                if (route != null)
                {
                    MessageBox.Show("Route has been added successfully.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to add new route.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task UpdateAsync()
        {
            PrepareData();

            try
            {
                var route = await RouteManager.UpdateAsync(Route);

                if (route != null)
                {
                    MessageBox.Show("Route successfully modified.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to modify route details.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelDialogButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
