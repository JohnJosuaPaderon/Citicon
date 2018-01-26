using System.Windows.Forms;

namespace Citicon.WindowsForm
{
    public static class DataGridViewRowExtension
    {
        public static DataGridViewRow SetHeight(this DataGridViewRow instance, int height)
        {
            instance.Height = height;
            return instance;
        }

        public static DataGridViewRow AddTextBoxCell(this DataGridViewRow instance, object value)
        {
            instance.Cells.AddTextBox(value);
            return instance;
        }

        public static DataGridViewRow AddCheckBoxCell(this DataGridViewRow instance, bool value)
        {
            instance.Cells.AddCheckBox(value);
            return instance;
        }
    }
}
