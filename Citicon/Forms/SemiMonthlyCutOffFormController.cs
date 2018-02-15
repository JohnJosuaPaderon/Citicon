using Citicon.Data;
using Citicon.Forms.DataLinks;
using System;
using System.Linq;

namespace Citicon.Forms
{
    internal sealed class SemiMonthlyCutOffFormController : FormControllerBase<SemiMonthlyCutOffForm>
    {
        public SemiMonthlyCutOffFormController(SemiMonthlyCutOffForm form, DateTimeRange dateTimeRange) : base(form)
        {
            _Months = new ComboBoxItemSource<Month>(_Form.MonthComboBox);
            DateTimeRange = dateTimeRange;
        }

        private readonly ComboBoxItemSource<Month> _Months;

        public DateTimeRange DateTimeRange { get; private set; }

        public void Initialize()
        {
            _Form.YearNumericUpDown.Maximum = DateTime.Now.Year;
            LoadMonths();

            if (DateTimeRange != null)
            {
                if (DateTimeRange.Begin.Year >= _Form.YearNumericUpDown.Minimum)
                {
                    if (DateTimeRange.Begin.Year <= _Form.YearNumericUpDown.Maximum)
                    {
                        _Form.YearNumericUpDown.Value = DateTimeRange.Begin.Year;
                    }
                    else
                    {
                        _Form.YearNumericUpDown.Value = _Form.YearNumericUpDown.Maximum;
                    }
                }
                else
                {
                    _Form.YearNumericUpDown.Value = DateTime.Now.Year;
                }
                
                _Months.SelectedItem = Month.AllMonths.FirstOrDefault(month => month.Id == DateTimeRange.Begin.Month);

                if (DateTimeRange.Begin.Day == 1)
                {
                    _Form.FirstCutOffRadioButton.Checked = true;
                }
                else
                {
                    _Form.SecondCutOffRadioButton.Checked = true;
                }
            }
        }

        public void Done()
        {
            if (_Months.SelectedItem == null)
            {
                _MessageDisplay.Error("No selected month.");
                return;
            }

            var year = Convert.ToInt32(_Form.YearNumericUpDown.Value);
            var month = _Months.SelectedItem.Id;
            var dayBegin = _Form.FirstCutOffRadioButton.Checked ? 1 : 16;
            var dayEnd = _Form.FirstCutOffRadioButton.Checked ? 15 : DateTime.DaysInMonth(year, month);

            DateTimeRange = new DateTimeRange(new DateTime(year, month, dayBegin), new DateTime(year, month, dayEnd));

            _Form.Close();
        }

        public void Cancel()
        {
            DateTimeRange = null;
            _Form.Close();
        }

        private void LoadMonths()
        {
            _Months.Clear();

            foreach (var month in Month.AllMonths)
            {
                _Months.Add(month);
            }
        }
    }
}
