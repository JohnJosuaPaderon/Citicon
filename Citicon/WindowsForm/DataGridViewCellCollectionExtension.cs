using System.Drawing;
using System.Windows.Forms;

namespace Citicon.WindowsForm
{
    public static class DataGridViewCellCollectionExtension
    {
        private static DataGridViewCellCollection AddTextBoxBase(this DataGridViewCellCollection instance, object value, Color? backColor)
        {
            var cell = new DataGridViewTextBoxCell
            {
                Value = value
            };

            if (backColor != null)
            {
                cell.Style.BackColor = backColor.Value;
            }

            instance.Add(cell);
            return instance;
        }

        private static DataGridViewCellCollection AddCheckBoxBase(this DataGridViewCellCollection instance, bool value)
        {
            var cell = new DataGridViewCheckBoxCell
            {
                Value = value
            };

            instance.Add(cell);
            return instance;
        }

        public static DataGridViewCellCollection AddTextBox(this DataGridViewCellCollection instance, object value)
        {
            return instance.AddTextBoxBase(value, null);
        }

        public static DataGridViewCellCollection AddTextBox(this DataGridViewCellCollection instance, object value, Color backColor)
        {
            return instance.AddTextBoxBase(value, backColor);
        }

        public static DataGridViewCellCollection AddCheckBox(this DataGridViewCellCollection instance, bool value)
        {
            return instance.AddCheckBoxBase(value);
        }
    }
}
