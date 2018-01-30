﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Citicon.Forms.DataLinks
{
    public class DataGridViewItemSource<T> where T : class
    {
        public DataGridViewItemSource(DataGridView dataGridView, Func<T, DataGridViewRow> addRow, Func<string> getItemColumnName)
        {
            _DataGridView = dataGridView ?? throw new ArgumentNullException(nameof(dataGridView));
            _AddRow = addRow ?? throw new ArgumentNullException(nameof(addRow));
            _GetItemColumnName = getItemColumnName ?? throw new ArgumentNullException(nameof(getItemColumnName));
        }

        private readonly Func<T, DataGridViewRow> _AddRow;
        private readonly DataGridView _DataGridView;
        private readonly Func<string> _GetItemColumnName;

        public T SelectedItem
        {
            get
            {
                if (_DataGridView.SelectedRows.Count == 1)
                {
                    return _DataGridView.SelectedRows[0].Cells[_GetItemColumnName()].Value as T;
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
            _DataGridView.Rows.Add(_AddRow(value));
        }

        public void AddRange(IEnumerable<T> values)
        {
            foreach (var value in values)
            {
                _DataGridView.Rows.Add(_AddRow(value));
            }
        }

        public void Clear()
        {
            _DataGridView.Rows.Clear();
        }

        public void Remove(T value)
        {
            if (value != null && _DataGridView.Rows.Count > 0)
            {
                var deletableRow = default(DataGridViewRow);

                foreach (DataGridViewRow row in _DataGridView.Rows)
                {
                    if (row.Cells[_GetItemColumnName()].Value is T rowValue && Equals(value, rowValue))
                    {
                        deletableRow = row;
                        break;
                    }
                }

                _DataGridView.Rows.Remove(deletableRow);
            }
        }
    }
}
