using System;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public sealed class MessageDisplay
    {
        static MessageDisplay()
        {
            Instance = new MessageDisplay();
        }

        public static MessageDisplay Instance { get; }

        public void Exception(Exception exception)
        {
            MessageBox.Show(exception.Message, "An Exception occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warning(string message)
        {
            MessageBox.Show(message, "Citicon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Inform(string message)
        {
            MessageBox.Show(message, "Citicon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Error(string message)
        {
            MessageBox.Show(message, "Citicon", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
