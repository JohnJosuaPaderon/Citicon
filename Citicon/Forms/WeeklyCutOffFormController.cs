using Citicon.Data;
using System;

namespace Citicon.Forms
{
    internal sealed class WeeklyCutOffFormController : FormControllerBase<WeeklyCutOffForm>
    {
        public WeeklyCutOffFormController(WeeklyCutOffForm form, DateTimeRange cutOff) : base(form)
        {
            CutOff = cutOff;
        }

        public DateTimeRange CutOff { get; private set; }

        public void Initialize()
        {
            if (CutOff != null)
            {
                if (CutOff.Begin > _Form.FromDateTimePicker.MinDate && CutOff.Begin < _Form.FromDateTimePicker.MaxDate)
                {
                    _Form.FromDateTimePicker.Value = CutOff.Begin;
                }
                else
                {
                    _Form.FromDateTimePicker.Value = DateTime.Now.AddDays(-7);
                }

                if (CutOff.End > _Form.ToDateTimePicker.MinDate && CutOff.End < _Form.ToDateTimePicker.MaxDate)
                {
                    _Form.ToDateTimePicker.Value = CutOff.End;
                }
                else
                {
                    _Form.ToDateTimePicker.Value = DateTime.Now;
                }
            }
        }

        internal void TryAutoSetEndDate()
        {
            if (!_Form.ToCheckBox.Checked)
            {
                SetAutoEndDate();
            }
        }

        public void ManualEndDate()
        {
            if (_Form.ToCheckBox.Checked)
            {
                _Form.ToDateTimePicker.Enabled = true;
            }
            else
            {
                _Form.ToDateTimePicker.Enabled = false;
                SetAutoEndDate();
            }
        }

        private void SetAutoEndDate()
        {
            _Form.ToDateTimePicker.Value = _Form.FromDateTimePicker.Value.AddDays(7);
        }

        public void Done()
        {
            CutOff.Begin = _Form.FromDateTimePicker.Value;
            CutOff.End = _Form.ToDateTimePicker.Value;
            _Form.Close();
        }

        public void Cancel()
        {
            CutOff = null;
            _Form.Close();
        }
    }
}
