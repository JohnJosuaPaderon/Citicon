using Citicon.Data;
using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class SemiMonthlyCutOffForm : Form
    {
        public static DateTimeRange Change(DateTimeRange dateTimeRange)
        {
            var form = new SemiMonthlyCutOffForm(dateTimeRange);
            form.ShowDialog();
            return form.DateTimeRange;
        }

        public SemiMonthlyCutOffForm(DateTimeRange dateTimeRange)
        {
            InitializeComponent();
            _Controller = new SemiMonthlyCutOffFormController(this, dateTimeRange);
        }

        private readonly SemiMonthlyCutOffFormController _Controller;
        public DateTimeRange DateTimeRange => _Controller.DateTimeRange;

        private void DoneButton_Click(object sender, EventArgs e)
        {
            _Controller.Done();
        }

        private void SemiMonthlyCutOffForm_Load(object sender, EventArgs e)
        {
            _Controller.Initialize();
        }

        private void CancelFormButton_Click(object sender, EventArgs e)
        {
            _Controller.Cancel();
        }
    }
}
