using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    public abstract class ExportExcelBase : IDisposable
    {
        public ExportExcelBase()
        {
            PrintOption = ExportExcelPrintOption.None;
        }

        protected Excel.Application Application;
        protected Excel.Workbooks Workbooks;
        protected Excel.Workbook Workbook;
        protected Excel.Sheets Sheets;
        protected Excel.Worksheet Worksheet;
        public ExportExcelPrintOption PrintOption { get; set; }

        public virtual void Execute()
        {
            switch (PrintOption)
            {
                case ExportExcelPrintOption.None:
                    break;
                case ExportExcelPrintOption.CurrentSheet:
                    Worksheet?.PrintOutEx();
                    break;
                case ExportExcelPrintOption.Workbook:
                    Workbook?.PrintOutEx();
                    break;
            }
        }

        public virtual Task ExecuteAsync()
        {
            return Task.Run(() => Execute());
        }

        protected void ApplyBorder(Excel.Range range, Excel.XlBordersIndex borderIndex, Excel.XlLineStyle lineStyle)
        {
            range.Borders[borderIndex].LineStyle = lineStyle;
        }

        protected void ApplyBorder(Excel.Range range, Excel.XlLineStyle lineStyle)
        {
            ApplyBorder(range, Excel.XlBordersIndex.xlEdgeTop, lineStyle);
            ApplyBorder(range, Excel.XlBordersIndex.xlEdgeBottom, lineStyle);
            ApplyBorder(range, Excel.XlBordersIndex.xlEdgeLeft, lineStyle);
            ApplyBorder(range, Excel.XlBordersIndex.xlEdgeRight, lineStyle);
        }

        public virtual void Dispose()
        {
            if (Worksheet != null)
            {
                Marshal.ReleaseComObject(Worksheet);
                Worksheet = null;
            }

            if (Sheets != null)
            {
                Marshal.ReleaseComObject(Sheets);
                Sheets = null;
            }

            if (Workbook != null)
            {
                Workbook.Close();
                Marshal.ReleaseComObject(Workbook);
                Workbook = null;
            }

            if (Workbooks != null)
            {
                Workbooks.Close();
                Marshal.ReleaseComObject(Workbooks);
                Workbooks = null;
            }

            if (Application != null)
            {
                Application.Quit();
                Marshal.ReleaseComObject(Application);
                Application = null;
            }
        }
    }
}
