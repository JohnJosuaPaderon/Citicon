namespace Citicon.DataProcess
{
    public static class ExcelCellParser
    {
        public static ExcelCell Parse(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return new ExcelCell(1);
            }
            else
            {
                var segments = value.Split(',');

                if (segments != null && segments.Length == 2)
                {
                    if (int.TryParse(segments[0], out int row) && int.TryParse(segments[1], out int column))
                    {
                        return new ExcelCell(row, column);
                    }
                    else
                    {
                        return new ExcelCell(1);
                    }
                }
                else
                {
                    return new ExcelCell(1);
                }
            }
        }
    }
}
