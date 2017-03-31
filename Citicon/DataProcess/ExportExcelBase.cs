using System;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    public abstract class ExportExcelBase : IDisposable
    {
        protected Excel.Application Application;
        protected Excel.Workbooks Workbooks;
        protected Excel.Workbook Workbook;
        protected Excel.Sheets Sheets;
        protected Excel.Worksheet Worksheet;

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
