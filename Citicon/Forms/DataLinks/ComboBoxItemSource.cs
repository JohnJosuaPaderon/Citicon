using System;
using System.Windows.Forms;

namespace Citicon.Forms.DataLinks
{
    public class ComboBoxItemSource<T> where T : class
    {
        public ComboBoxItemSource(ComboBox comboBox)
        {
            _ComboBox = comboBox ?? throw new ArgumentNullException(nameof(comboBox));
        }

        private readonly ComboBox _ComboBox;

        public void Add(T value)
        {
            _ComboBox.Items.Add(value);
        }

        public void Clear()
        {
            _ComboBox.Items.Clear();
        }

        public T SelectedItem
        {
            get
            {
                return _ComboBox.SelectedItem as T;
            }
            set
            {
                _ComboBox.SelectedItem = value;
            }
        }
    }
}
