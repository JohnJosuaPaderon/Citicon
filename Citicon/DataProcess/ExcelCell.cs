namespace Citicon.DataProcess
{
    public struct ExcelCell
    {
        public ExcelCell(int point)
        {
            RowIndex = point;
            ColumnIndex = point;
        }

        public ExcelCell(int rowIndex, int columnIndex)
        {
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
        }

        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }
}
