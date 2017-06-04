using System.ComponentModel;
using System.Windows.Forms;

namespace Citicon.UI.Controls
{
    public partial class TextBoxField : UserControl
    {
        public TextBoxField()
        {
            InitializeComponent();
        }

        public string Caption
        {
            get { return CaptionLabel.Text; }
            set
            {
                if (CaptionLabel.Text == value) return;

                CaptionLabel.Text = value;
                CaptionLabel.Text = value;

            }
        }

        [Browsable(true)]
        public override string Text
        {
            get { return TextBox.Text; }
            set
            {
                if (TextBox.Text == value) return;

                TextBox.Text = value;
                TextBox.Text = value;
            }
        }
    }
}
