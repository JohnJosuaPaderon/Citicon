using System.Windows.Forms;

namespace Citicon.WindowsForm
{
    public static class DataGridViewCellCollectionExtension
    {
        private static DataGridViewCellCollection AddTextBoxBase(this DataGridViewCellCollection instance, object value)
        {
            var cell = new DataGridViewTextBoxCell
            {
                Value = value
            };

            instance.Add(cell);
            return instance;
        }

        public static DataGridViewCellCollection AddTextBox(this DataGridViewCellCollection instance, object value)
        {
            return instance.AddTextBoxBase(value);
        }
    }
}
