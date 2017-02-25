using System;
using System.Configuration;
using System.IO;
using System.Text;

namespace Citicon.Reports
{
    public sealed class SemiMonthlyPayrollExportConfiguration
    {
        public SemiMonthlyPayrollExportConfiguration()
        {
            var configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = ConfigurationManager.AppSettings["SemiMonthlyPayrollExportConfigFile"];
            Source = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

            BranchCell = GetCell("Branch");
            PayrollRangeCell = GetCell("Payroll_Range");
        }

        public Configuration Source { get; }
        private KeyValueConfigurationCollection AppSettings => Source.AppSettings.Settings;

        private int GetCellColumnIndex(string key)
        {
            int cellColumnIndex;
            int.TryParse(AppSettings[string.Format("Cell.ColumnIndex[{0}]", key)].Value, out cellColumnIndex);

            return cellColumnIndex;
        }

        private int GetCellRowIndex(string key)
        {
            int cellRowIndex;
            int.TryParse(AppSettings[string.Format("Cell.RowIndex[{0}]", key)].Value, out cellRowIndex);

            return cellRowIndex;
        }

        private ExcelCell GetCell(string key)
        {
            var cell = new ExcelCell();
            cell.ColumnIndex = GetCellColumnIndex(key);
            cell.RowIndex = GetCellRowIndex(key);

            return cell;
        }

        public int ColumnIndex(SemiMonthlyPayrollExportConfigurationColumnIndex columnIndex)
        {
            return Convert.ToInt32(AppSettings[string.Format("ColumnIndex[{0}]", columnIndex.ToString())].Value);
        }

        public string Formula(SemiMonthlyPayrollExportConfigurationColumnIndex columnIndex, int rowIndex)
        {
            string formula = AppSettings[string.Format("Formula[{0}]", columnIndex.ToString())].Value;
            var stringBuilder = new StringBuilder(formula);

            foreach (var item in Enum.GetNames(typeof(SemiMonthlyPayrollExportConfigurationColumnIndex)))
            {
                SemiMonthlyPayrollExportConfigurationColumnIndex itemColumnIndex;
                Enum.TryParse(item, out itemColumnIndex); 
                stringBuilder = stringBuilder.Replace(string.Format("[{0}]", item), string.Format("{0}{1}", GetExcelColumnName(ColumnIndex(itemColumnIndex)), rowIndex));
            }

            var formulaBuilder = new StringBuilder();
            formulaBuilder.AppendFormat("={0}", stringBuilder.ToString());

            return formulaBuilder.ToString();
        }

        private string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = string.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (dividend - modulo) / 26;
            }

            return columnName;
        }

        public string TemplateFile
        {
            get
            {
                return AppSettings["Template"].Value;
            }
        }

        public int PayrollItemsRowMargin
        {
            get
            {
                return Convert.ToInt32(AppSettings["Payroll_Items_Row_Margin"].Value);
            }
        }

        public string SaveDirectory
        {
            get
            {
                var directory = AppSettings["Save_Directory"].Value;

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                return directory;
            }
        }

        public ExcelCell PayrollRangeCell { get; }
        public ExcelCell BranchCell { get; }
    }

    public class ExcelCell
    {
        public ExcelCell()
        {
            ColumnIndex = 1;
            RowIndex = 1;
        }

        public ExcelCell(int columnIndex, int rowIndex)
        {
            ColumnIndex = columnIndex;
            RowIndex = rowIndex;
        }

        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
    }

    public enum SemiMonthlyPayrollExportConfigurationColumnIndex
    {
        Counter,
        Employee,
        VLSL,
        Rate,
        Basic_Pay,
        Regular_Working_Hours,
        Regular_Overtime_Pay,
        ND_OT_Hours,
        NT_125_Percent,
        Sunday_Hours,
        Sunday_Pay,
        Special_Holiday_Hours,
        Special_Holiday_Pay,
        Special_Holiday_Overtime_Hours,
        Special_Holiday_Overtime_Pay,
        Overtime_Allowance,
        Allowance,
        Gross_Pay,
        With_Holding_Tax,
        SSS,
        SSS_Loan,
        Pagibig_Loan,
        Cash_Advance,
        Sun_Cell_Bill,
        Total_Deduction,
        Net_Pay
    }
}
