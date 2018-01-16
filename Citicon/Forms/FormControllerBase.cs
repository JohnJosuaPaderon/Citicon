using System.Windows.Forms;

namespace Citicon.Forms
{
    public abstract class FormControllerBase<TForm> where TForm : Form
    {
        public FormControllerBase(TForm form)
        {
            _Form = form;
            _MessageDisplay = MessageDisplay.Instance;
        }

        protected readonly TForm _Form;
        protected readonly MessageDisplay _MessageDisplay;
    }
}
