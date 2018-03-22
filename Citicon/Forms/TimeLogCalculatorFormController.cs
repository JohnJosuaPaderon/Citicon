using System;
using System.Threading.Tasks;

namespace Citicon.Forms
{
    internal sealed class TimeLogCalculatorFormController : FormControllerBase<TimeLogCalculatorForm>
    {
        public TimeLogCalculatorFormController(TimeLogCalculatorForm form) : base(form)
        {
        }

        public Task SearchAsync()
        {
            throw new NotImplementedException();
        }
    }
}
