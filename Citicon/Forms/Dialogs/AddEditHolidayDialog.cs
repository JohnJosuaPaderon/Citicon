using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Dialogs
{
    public partial class AddEditHolidayDialog : Form
    {
        public AddEditHolidayDialog()
        {
            InitializeRequirements();
            InitializeComponent();
            Holiday = new Holiday();
            DialogMode = DataDialogMode.Add;
        }

        public AddEditHolidayDialog(Holiday holiday)
        {
            InitializeRequirements();
            InitializeComponent();
            Holiday = holiday ?? throw new ArgumentNullException(nameof(holiday));
            DialogMode = DataDialogMode.Edit;
        }

        public Holiday Holiday { get; private set; }
        public DataDialogMode DialogMode { get; private set; }
        private HolidayTypeManager HolidayTypeManager;
        private HolidayManager HolidayManager;

        private void InitializeRequirements()
        {
            HolidayTypeManager = new HolidayTypeManager();
            HolidayManager = new HolidayManager();
        }

        private void UpdateDialogModeUI()
        {
            switch (DialogMode)
            {
                case DataDialogMode.None:
                    Text = "Unknown operation.";
                    break;
                case DataDialogMode.Add:
                    Text = "Add new Holiday";
                    break;
                case DataDialogMode.Edit:
                    Text = "Edit existing Holiday";
                    break;
            }
        }

        private void UpdateHolidayUI()
        {
            var dateOccur = Holiday?.DateOccur ?? DateTime.Now;
            NameTextBox.Text = Holiday?.Name;
            DateOccurDateTimePicker.Value = dateOccur < DateOccurDateTimePicker.MinDate ? DateOccurDateTimePicker.MinDate : dateOccur > DateOccurDateTimePicker.MaxDate ? DateOccurDateTimePicker.MaxDate : dateOccur;
            TypeComboBox.SelectedItem = Holiday?.Type;
        }

        private void CancelHolidayButton_Click(object sender, EventArgs e)
        {
            var messageResult = MessageBox.Show("Are you sure, do you really want to cancel and close this dialog?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messageResult != DialogResult.Yes)
            {
                Close();
            }
        }

        private async Task GetHolidayTypeListAsync()
        {
            TypeComboBox.Items.Clear();

            try
            {
                var types = await HolidayTypeManager.GetListAsync();

                if (types != null && types.Any())
                {
                    TypeComboBox.Items.AddRange(types.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task AddAsync()
        {
            try
            {
                if (Holiday != null)
                {
                    Holiday = await HolidayManager.InsertAsync(this.Holiday);

                    if (Holiday != null)
                    {
                        MessageBox.Show("Holiday successfully added.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add holiday.");
                    }
                }
                else
                {
                    MessageBox.Show("No holiday to add.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task EditAsync()
        {
            try
            {
                if (Holiday != null)
                {
                    Holiday = await HolidayManager.UpdateAsync(this.Holiday);

                    if (Holiday != null)
                    {
                        MessageBox.Show("Holiday successfully modified.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to edit holiday.");
                    }
                }
                else
                {
                    MessageBox.Show("No holiday to modify.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void AddEditHolidayDialog_Load(object sender, EventArgs e)
        {
            await GetHolidayTypeListAsync();

            UpdateHolidayUI();
            UpdateDialogModeUI();
        }

        private async void SaveHolidayButton_Click(object sender, EventArgs e)
        {
            switch (DialogMode)
            {
                case DataDialogMode.None:
                    MessageBox.Show("No operation to be executed.");
                    break;
                case DataDialogMode.Add:
                    await AddAsync();
                    break;
                case DataDialogMode.Edit:
                    await EditAsync();
                    break;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Holiday != null && Holiday.Name != NameTextBox.Text)
            {
                Holiday.Name = NameTextBox.Text;
            }
        }

        private void DateOccurDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (Holiday != null && Holiday.DateOccur != DateOccurDateTimePicker.Value)
            {
                Holiday.DateOccur = DateOccurDateTimePicker.Value;
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = TypeComboBox.SelectedItem as HolidayType;

            if (Holiday != null && Holiday.Type != type)
            {
                Holiday.Type = type;
            }
        }
    }
}
