using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Citicon.Forms.DataLinks
{
    public class DataGridViewItemSource<T> : IEnumerable<T>, IDisposable
        where T : class
    {
        public DataGridViewItemSource(DataGridView dataGridView, Func<T, DataGridViewRow> addRow, string itemColumnName)
        {
            _Items = new List<T>();
            _DataGridView = dataGridView ?? throw new ArgumentNullException(nameof(dataGridView));
            _AddRow = addRow ?? throw new ArgumentNullException(nameof(addRow));
            _ItemColumnName = itemColumnName ?? throw new ArgumentNullException(nameof(itemColumnName));

            _DataGridView.SelectionChanged += SelectionChanged;
        }

        public DataGridViewItemSource(DataGridView dataGridView, Func<T, DataGridViewRow> addRow, Action<T> selectedItemChanged, string itemColumnName, Action<DataGridViewRow, T> refreshRow)
        {
            _Items = new List<T>();
            _DataGridView = dataGridView ?? throw new ArgumentNullException(nameof(dataGridView));
            _AddRow = addRow ?? throw new ArgumentNullException(nameof(addRow));
            _ItemColumnName = itemColumnName ?? throw new ArgumentNullException(nameof(itemColumnName));
            _SelectedItemChanged = selectedItemChanged;
            _RefreshRow = refreshRow;

            _DataGridView.SelectionChanged += SelectionChanged;
        }

        private readonly Func<T, DataGridViewRow> _AddRow;
        private readonly Action<T> _SelectedItemChanged;
        private readonly Action<DataGridViewRow, T> _RefreshRow;
        private readonly DataGridView _DataGridView;
        private readonly List<T> _Items;
        private readonly string _ItemColumnName;

        public T SelectedItem
        {
            get
            {
                if (_DataGridView.SelectedRows.Count == 1)
                {
                    var result = _DataGridView.SelectedRows[0].Cells[_ItemColumnName].Value as T;
                    return result;
                }
                else
                {
                    return null;
                }
            }
        }

        public int Count => _DataGridView.Rows.Count;

        public void Add(T value)
        {
            _Items.Add(value);
            _DataGridView.Rows.Add(_AddRow(value));
        }

        public void AddRange(IEnumerable<T> values)
        {
            foreach (var value in values)
            {
                _Items.Add(value);
                _DataGridView.Rows.Add(_AddRow(value));
            }
        }

        public void Clear()
        {
            _Items.Clear();
            _DataGridView.Rows.Clear();
        }

        public void Remove(T value)
        {
            if (value != null && _DataGridView.Rows.Count > 0)
            {
                var deletableRow = default(DataGridViewRow);

                foreach (DataGridViewRow row in _DataGridView.Rows)
                {
                    if (row.Cells[_ItemColumnName].Value is T rowValue && Equals(value, rowValue))
                    {
                        deletableRow = row;
                        break;
                    }
                }

                _Items.Remove(value);
                _DataGridView.Rows.Remove(deletableRow);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            _DataGridView.SelectionChanged -= SelectionChanged;
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            _SelectedItemChanged?.Invoke(SelectedItem);
        }

        private void RepaintSelectedItem()
        {
            _DataGridView.Refresh();
        }

        public void RefreshSelected()
        {
            _RefreshRow(_DataGridView.SelectedRows[0], SelectedItem);
        }
    }
}
