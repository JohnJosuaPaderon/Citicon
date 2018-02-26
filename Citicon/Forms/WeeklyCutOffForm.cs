using Citicon.Data;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class WeeklyCutOffForm : Form
    {
        public static DateTimeRange Change(DateTimeRange cutOff)
        {
            var instance = new WeeklyCutOffForm(cutOff);
            instance.ShowDialog();
            return instance._Controller.CutOff;
        }

        private WeeklyCutOffForm(DateTimeRange cutOff)
        {
            InitializeComponent();
            _Controller = new WeeklyCutOffFormController(this, cutOff);
        }

        private readonly WeeklyCutOffFormController _Controller;

        private void ToLabel_CheckedChanged(object sender, System.EventArgs e)
        {
            _Controller.ManualEndDate();
        }

        private void FromDateTimePicker_ValueChanged(object sender, System.EventArgs e)
        {
            _Controller.TryAutoSetEndDate();
        }

        private void WeeklyCutOffForm_Load(object sender, System.EventArgs e)
        {
            _Controller.Initialize();
        }

        private void DoneButton_Click(object sender, System.EventArgs e)
        {
            _Controller.Done();
        }

        private void CancelFormButton_Click(object sender, System.EventArgs e)
        {
            _Controller.Cancel();
        }
    }
}
