using Citicon.Data;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class EmployeeTimeLogForm : Form
    {
        public EmployeeTimeLogForm(Employee employee, DateTimeRange cutOff)
        {
            InitializeComponent();
            _Controller = new EmployeeTimeLogFormController(this, employee, cutOff);
        }

        private readonly EmployeeTimeLogFormController _Controller;
        public bool HasChanges => _Controller.HasChanges;

        private async void EmployeeTimeLogForm_Load(object sender, System.EventArgs e)
        {
            await _Controller.InitializeAsync();
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            _Controller.Close();
        }

        private async void DeleteButton_Click(object sender, System.EventArgs e)
        {
            await _Controller.DeleteAsync();
        }

        private async void SaveChangesButton_Click(object sender, System.EventArgs e)
        {
            await _Controller.SaveChangesAsync();
        }
    }
}
